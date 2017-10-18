namespace _05.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Library BookList = new Library();
            BookList.Books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split(' ').ToList();                
                BookList.Books.Add(new Book
                {
                    Title = entry[0],
                    Author = entry[1],
                    Publisher = entry[2],
                    DateReleased = DateTime.ParseExact(entry[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = entry[4],
                    Price = double.Parse(entry[5])
                });                
            }
            var authorTotPrice = new Dictionary<string, double>();
            foreach (var item in BookList.Books)
            {
                if (!authorTotPrice.ContainsKey(item.Author))
                {
                    authorTotPrice[item.Author] = item.Price;
                }
                else
                {
                    authorTotPrice[item.Author] += item.Price;
                }
            }
            foreach (var author in authorTotPrice.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }
}
