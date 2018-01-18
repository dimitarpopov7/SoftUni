namespace _8.Military_Elite.Soldiers.SpecialSoldiers
{
    
    using Missions;    
    using Interfaces;
    using System.Collections.Generic;
    using System;

    public class Commando : SpecialSoldier, ICommando
    {
        private List<Mission> missions;
        public Commando(string firstName, string lastName, string id, double salary,string corps, List<Mission> missions) : base(firstName, lastName, id, salary,corps)
        {
            this.Missions = missions;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Corps: {this.Corps}{Environment.NewLine}Missions:{$"{Environment.NewLine}  "}{string.Join($"{Environment.NewLine}  ", this.Missions)}";
        }
        public List<Mission> Missions
        {
            get { return this.missions; }
            set { this.missions = value; }
        }
    }
}