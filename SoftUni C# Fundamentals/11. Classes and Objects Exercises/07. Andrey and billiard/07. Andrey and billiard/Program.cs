namespace _07.Andrey_and_billiard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var stockList = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var typesOfStock = Console.ReadLine().Split('-').ToList();
                stockList[typesOfStock[0]] = double.Parse(typesOfStock[1]);                
            }            
            var listOfCustomers = new List<Order>();
            while (true)
            {
                string entry = Console.ReadLine();
                if (entry=="end of clients")
                {
                    break;
                }
                else
                {
                    var orders = entry.Split('-',',').ToList();
                    string name = orders[0];
                    string product = orders[1];                    
                    int quantity = int.Parse(orders[2]);
                    var currentCustomer = new Order();
                    currentCustomer.Name = name;
                    var temDict = new SortedDictionary<string, int>();
                    temDict[product] = quantity;
                    currentCustomer.ShopList=temDict;
                    
                    if (stockList.ContainsKey(product))
                    {
                        if (listOfCustomers.Any(x=>x.Name==name))
                        {
                            currentCustomer = listOfCustomers.First(x => x.Name == name);
                            if (currentCustomer.ShopList.ContainsKey(product))
                            {
                                currentCustomer.ShopList[product] += quantity;
                            }
                            else
                            {
                                currentCustomer.ShopList.Add(product, quantity);
                            }
                        }
                        else
                        {
                            listOfCustomers.Add(currentCustomer);
                        }
                    }
                }
            }
            double totBill = 0.00;
            foreach (var person in listOfCustomers.OrderBy(x => x.Name))
            {
                Console.WriteLine(person.Name);
                double personalBill = 0.00;
                foreach (KeyValuePair<string, int> item in person.ShopList)//that is something that I need to practice!!!
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                    personalBill += stockList[item.Key] * item.Value;
                }
                Console.WriteLine($"Bill: {personalBill:f2}");
                totBill += personalBill;
            }
            Console.WriteLine($"Total bill: {totBill:f2}");
        }
    }    
}
