namespace _4.Distance_Between_Points
{
    using System;
    public class Program
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        public static void Main()
        {
            var xY = Console.ReadLine().Split(' ');
            
            var firstPoint = new Point
            {
                X = Convert.ToDouble(xY[0]),
                Y = double.Parse(xY[1])
            };

            var aB = Console.ReadLine().Split(' ');

            var secondPoint = new Point
            {
                X = double.Parse(aB[0]),
                Y = double.Parse(aB[1])
            };
            var result =CalcDistance(firstPoint,secondPoint);
            Console.WriteLine($"{result:f3}");
        }
        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;
            var result = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            return result;
        }        
    }
}
