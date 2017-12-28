namespace _9.Pizza_Time
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            /*
            Input:

            4Peperoni 2Margarita 2RunningChiken 4DonVito

            Desired Output:
            
            2 – Margarita, RunningChiken
            4 – Peperoni, DonVito
            */
            var pizzaInfo = Console.ReadLine().Split().Select(x=>(x[0]+" "+x.Substring(1)).Split()).ToList();
            var pizzas = new List<Pizza>();
            foreach (var pizza in pizzaInfo)
            {
                var currentPizza = new Pizza(pizza[1], int.Parse(pizza[0]));
                pizzas.Add(currentPizza);
            }
            var pizzaParty = new Pizza("I Dont get that problem..?!?!",1);
            var dictionary=pizzaParty.SortPizzas(pizzas);
            foreach (var group in dictionary)
            {
                Console.WriteLine($"{group.Key} - {string.Join(", ",group.Value)}");
            }
        }
    }
}