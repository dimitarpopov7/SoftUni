namespace _05.Book_Library
{
    using System;
    using System.Collections.Generic;
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime DateReleased { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

}
