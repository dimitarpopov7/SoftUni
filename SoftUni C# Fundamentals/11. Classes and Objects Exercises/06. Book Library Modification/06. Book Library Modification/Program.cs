namespace _06.Book_Library_Modification
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
            var list = new List<Book>();
            for (int i = 0; i < n; i++)
            {

                var entry = Console.ReadLine().Split(' ').ToList();
                list.Add(new Book
                {
                    Author = entry[1],
                    Title = entry[0],
                    Publisher=entry[2],
                    Date=DateTime.ParseExact(entry[3],"dd.MM.yyyy",CultureInfo.InvariantCulture),
                    ISBN = entry[4],
                    Price=double.Parse(entry[5])
                });
            }
            DateTime dateStart = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var result = new Dictionary<string, DateTime>();
            foreach (var book in list)
            {
                if (!result.ContainsKey(book.Title))
                {
                    if(dateStart < book.Date)
                    {
                        result[book.Title] = book.Date;
                    }
                }
                else
                {
                    if (dateStart < book.Date)
                    {
                        result[book.Title] = book.Date;
                    }
                }
            }
            foreach (var book in result.OrderBy(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{ book.Key} -> {book.Value.ToString("dd.MM.yyyy")}");
            }
        }        
    }
}
