namespace _02.Jedi_Galaxy
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            long ivoStartValue = 0;
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();
            var galaxy = new int[dimensions[0], dimensions[1]];
            FillGalaxy(galaxy);
            var input = Console.ReadLine();
            while (input!="Let the Force be with you")
            {
                var ivoPosition=input.Split().Select(int.Parse).ToList();
                var evilPosition = Console.ReadLine().Split().Select(int.Parse).ToList();

                var ivoRow = ivoPosition[0];
                var ivoCol = ivoPosition[1];

                var evilRow = evilPosition[0];
                var evilCol = evilPosition[1];

                while (evilRow>=0&&evilCol>=0)
                {
                    if (IsInGalaxy(galaxy, evilRow, evilCol))
                    {
                        galaxy[evilRow, evilCol]=0;
                    }
                    evilRow--;
                    evilCol--;
                }
                while (ivoRow>=0&&ivoCol<=galaxy.GetLength(1))
                {
                    if (IsInGalaxy(galaxy,ivoRow, ivoCol))
                    {
                        ivoStartValue += galaxy[ivoRow, ivoCol];
                    }
                    ivoRow--;
                    ivoCol++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(ivoStartValue);
        }
        private static bool IsInGalaxy(int[,] galaxy, int ivoRow, int ivoCol)
        {
            bool result = ivoRow >= 0 && ivoRow < galaxy.GetLength(0) &&
                          ivoCol >= 0 && ivoCol < galaxy.GetLength(1);            
            return result;
        }
        private static int[,] FillGalaxy(int[,] galaxy)
        {
            int currentCount = 0;
            for (int i = 0; i < galaxy.GetLength(0); i++)
            {
                for (int j = 0; j < galaxy.GetLength(1); j++)
                {
                    galaxy[i, j] = currentCount;
                    currentCount++;
                }
            }
            return galaxy;
        }
    }
}
