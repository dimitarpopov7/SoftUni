namespace _2.King_s_Gambit.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Interfaces;

    public class Engine
    {
        private King king;
        private List<Person> people;

        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.people = new List<Person>();
        }

        public void Run()
        {
            this.BuildKingdom();
            this.ExecuteCommands();
        }

        private void ExecuteCommands()
        {
            var command = this.reader.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Attack":
                        this.king.OnKingIsAttacked();
                        break;
                    case "Kill":
                        this.RemoveDeadSoldier(command[1]);
                        break;
                    default:
                        break;
                }

                command = this.reader.ReadLine().Split();
            }
        }

        private void RemoveDeadSoldier(string soldierName)
        {
            var soldier = this.people.FirstOrDefault(s => s.Name == soldierName);
            soldier.lives--;
            if (soldier.lives == 0)
            {
                king.KingAttacked -= soldier.KingIsAttacked;
                this.people.Remove(soldier);
            }
        }

        private void BuildKingdom()
        {
            var kingName = this.reader.ReadLine();
            this.king = new King(kingName, this.writer);

            var royalGuardNames = this.reader.ReadLine().Split();
            foreach (var name in royalGuardNames)
            {
                var royalGuard = new RoyalGuard(name, this.writer);
                this.people.Add(royalGuard);
                this.king.KingAttacked += royalGuard.KingIsAttacked;
            }

            var footmanNames = this.reader.ReadLine().Split();
            foreach (var name in footmanNames)
            {
                var footman = new Footman(name, this.writer);
                this.people.Add(footman);
                this.king.KingAttacked += footman.KingIsAttacked;
            }
        }
    }
}
