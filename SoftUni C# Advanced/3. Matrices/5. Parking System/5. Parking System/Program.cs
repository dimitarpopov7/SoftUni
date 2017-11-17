namespace _5.Parking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Programe
    {
        public static void Main()
        {
            var size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToList();
            int rows = size[0];
            int cols = size[1];
            var parking = new Dictionary<int, HashSet<int>>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                var entry = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToList();

                var entryRow = entry[0];
                var desiredRow = entry[1];
                var desiredCol = entry[2];
                var parkColumn = 0;
                if (!IsOccupied(parking, desiredRow, desiredCol))
                {
                    parkColumn = desiredCol;
                }
                else
                {
                    for (int i = 1; i < cols - 1; i++)
                    {
                        if (((desiredCol - i) > 0) && !IsOccupied(parking, desiredRow, (desiredCol - i)))
                        {
                            parkColumn = (desiredCol - i);
                            break;
                        }
                        else if (((desiredCol + i) < cols) && !IsOccupied(parking, desiredRow, (desiredCol + i)))
                        {
                            parkColumn = (desiredCol + i);
                            break;
                        }
                    }
                }
                if (parkColumn == 0)
                {
                    Console.WriteLine($"Row {desiredRow} full");
                }
                else
                {
                    parking[desiredRow].Add(parkColumn);
                    int steps = Math.Abs(entryRow - desiredRow) + 1 + parkColumn;
                    Console.WriteLine(steps);
                }
                input = Console.ReadLine();
            }
        }
        private static bool IsOccupied(Dictionary<int, HashSet<int>> parking, int row, int col)
        {
            if (parking.ContainsKey(row))
            {
                if (parking[row].Contains(col))
                {
                    return true;
                }
            }
            else
            {
                parking.Add(row, new HashSet<int>());
            }
            return false;
        }
    }
}
