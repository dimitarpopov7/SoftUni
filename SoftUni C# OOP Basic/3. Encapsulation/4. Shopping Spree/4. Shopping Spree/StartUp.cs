namespace _4.Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            List<Person> shoppers=new List<Person>();
            List<Product> products=new List<Product>();
            try
            {
                var people = Console.ReadLine().Split(';').Select(x => (x.Replace(" ","").Split('='))).ToList();
                shoppers = new List<Person>();
                foreach (var person in people)
                {                    
                    var currentPerson = new Person(person[0], int.Parse(person[1]));
                    shoppers.Add(currentPerson);
                }
                var productsInfo = Console.ReadLine().TrimEnd(';').Split(';').Select(x => (x.Split('='))).ToList();
                products = new List<Product>();
                foreach (var product in productsInfo)
                {
                    var currentProduct = new Product(product[0], int.Parse(product[1]));
                    products.Add(currentProduct);
                }
                var shoping = Console.ReadLine().Split().ToList();
                while (shoping[0] != "END")
                {
                    var personName = shoppers.Where(x => x.Name == shoping[0]).FirstOrDefault();
                    var productName = products.Where(x => x.Name == shoping[1]).FirstOrDefault();
                    try
                    {
                        personName.BuyProduct(productName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    shoping = Console.ReadLine().Split().ToList();
                }
                foreach (var person in shoppers)
                {
                    if (person.bagOfProducts.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.bagOfProducts.Select(x => x.Name))}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}