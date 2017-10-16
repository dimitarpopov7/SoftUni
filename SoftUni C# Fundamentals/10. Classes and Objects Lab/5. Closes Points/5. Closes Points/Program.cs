namespace _5.Closes_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var currentPoint = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();
                points.Add(new Point
                {
                    X = currentPoint[0],
                    Y = currentPoint[1]
                });
            }

            var minDistance = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;
            for (int i = 0; i < points.Count-1; i++)
            {
                for (int k = i+1; k < points.Count; k++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[k];
                    var distance = CalcDistance(firstPoint, secondPoint);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }            
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");
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
