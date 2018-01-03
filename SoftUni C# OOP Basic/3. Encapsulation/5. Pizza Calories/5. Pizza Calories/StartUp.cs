namespace _5.Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                //Pizza
                var pizzaInfo = Console.ReadLine().Split().ToList();
                var pizzaName = pizzaInfo[1];
                var pizzaToppingsNum = int.Parse(pizzaInfo[2]);
                var pizza = new Pizza(pizzaName, pizzaToppingsNum);
                //Dough
               var doughInfo = Console.ReadLine().Split().ToList();
                var flourType = doughInfo[1];
                var bakingType = doughInfo[2];
                var weight = int.Parse(doughInfo[3]);
                var dg = new Dough(flourType, bakingType, weight);
                //Toppings
                var toppingsList = new List<Topping>();
                for (int i = 0; i < pizzaToppingsNum; i++)
                {
                    var toppingInfo = Console.ReadLine().Split().ToList();
                    var tp = new Topping(toppingInfo[1], int.Parse(toppingInfo[2]));
                    toppingsList.Add(tp);
                }
                pizza.Dough = dg;
                pizza.Toppings = toppingsList;
                var cals = pizza.GetCalories(pizza.Dough, pizza.Toppings);
                Console.ReadLine();                
                Console.WriteLine($"{pizzaName} - {cals:f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}