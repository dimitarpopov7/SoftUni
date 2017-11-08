namespace II.Ladybug
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            var positions = Console.ReadLine().Split().Select(x => int.Parse(x)).Where(x=> x >= 0&&x <fieldSize).ToList();
            var command = Console.ReadLine();
            var field = new int[fieldSize];
            for (int i = 0; i < positions.Count; i++)
            {
                int indexOfLadyBug = positions[i];
                field[indexOfLadyBug] = 1;
            }
            while (command != "end")
            {
                var commandBreakdown = command.Split();
                var ladybugIndex = Convert.ToInt32(commandBreakdown[0]);
                var direction = Convert.ToString(commandBreakdown[1]);
                var steps = Convert.ToInt32(commandBreakdown[2]);
                if (ladybugIndex < 0 || ladybugIndex >= fieldSize)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if(field[ladybugIndex]==0)
                {
                    command = Console.ReadLine();
                    continue;
                }
                MoveLadyBug(field, ladybugIndex, direction, steps);
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",field));
        }
        private static void MoveLadyBug(int[] field, int ladybugIndex, string direction, int steps)
        {
            field[ladybugIndex] = 0;
            var ladyBugFoundPlace = false;
            while (!ladyBugFoundPlace)
            {
                if (direction == "left")
                {
                    ladybugIndex -= steps;
                }
                else if(direction=="right")
                {
                    ladybugIndex += steps;
                }
                if (ladybugIndex < 0||ladybugIndex>=field.Length)
                {
                    ladyBugFoundPlace = true;//ladybug has left the field
                    continue;
                }
                if (field[ladybugIndex] == 1)
                {
                    continue;
                }
                else
                {
                    field[ladybugIndex] = 1;
                    ladyBugFoundPlace = true;
                    continue;
                }
            }            
        }
    }
}
