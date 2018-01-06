namespace _5.Mordor_s_Cruelty_Plan_FP_
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var foodInfo = Console.ReadLine().Split().Select(x => x.ToLower()).ToList();
            int points = 0;
            foreach (var ingrediant in foodInfo)
            {
                points += FoodFactory.GetPoints(ingrediant).PointsOfHappiness;
            }
            var mood = MoodFactory.GetMood(points);
            Console.WriteLine(points);
            Console.WriteLine(mood.GetType().Name);
        }
    }
}