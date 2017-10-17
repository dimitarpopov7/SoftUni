namespace _03.Intersection_of_Circles
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstCircVars = Console.ReadLine().Split(' ').Select(double.Parse).ToList();            
            Circle firstCirc = new Circle
            {
                X = firstCircVars[0],
                Y = firstCircVars[1],
                Radius = firstCircVars[2]
            };
            var secondCircVars = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Circle secondCirc = new Circle
            {
                X = secondCircVars[0],
                Y = secondCircVars[1],
                Radius = secondCircVars[2]
            };
            double distance = Math.Sqrt(Math.Pow((firstCirc.X - secondCirc.X), 2) + Math.Pow((firstCirc.Y - secondCirc.Y), 2));
            if (distance <= firstCirc.Radius+secondCirc.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
