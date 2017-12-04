namespace _13.Office_Stuff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine()
                .Trim('|')
                .Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var listOfCompanies = new HashSet<Company>();
            for (int i = 0; i < n; i++)
            {
                var company = input[0];
                var product = input[2];
                var amount = int.Parse(input[1]);
                var currentCompany = listOfCompanies.Where(c => c.Name == company).FirstOrDefault();
                if (currentCompany == null)
                {
                    currentCompany = new Company() { Name = company, Items = new List<Product>()};
                    listOfCompanies.Add(currentCompany);
                }
                var currentProduct = currentCompany.Items.Where(p => p.ProductName == product).FirstOrDefault();
                if (currentProduct == null)
                {
                    currentProduct = new Product() { ProductName = product, Amount = amount };
                    currentCompany.Items.Add(currentProduct);
                }
                else
                {
                    currentProduct.Amount += amount;
                }
                input = Console.ReadLine()
                .Trim('|')
                .Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            foreach (var company in listOfCompanies.OrderBy(x=>x.Name))
            {
                var products = string.Join(", ", company.Items.Select(p => $"{p.ProductName}-{p.Amount}"));
                Console.WriteLine($"{company.Name}: {products}");
            }
        }
    }
}