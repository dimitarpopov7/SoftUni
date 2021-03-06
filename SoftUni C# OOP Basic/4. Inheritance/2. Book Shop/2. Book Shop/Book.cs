﻿namespace _2.Book_Shop
{
    using System;
    using System.Text;
    public class Book
    {
        private string title;
        private string author;
        private decimal price;
        
        public Book(string author, string title,  decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }
        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }
        public string Author
        {
            get { return this.author; }
            private set
            {
                var firstLetterOfSurname = 1 + value.IndexOf(' ');
                bool isDigit = int.TryParse(Convert.ToString(value[firstLetterOfSurname]), out var n);
                if (isDigit)
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }
        public string Title
        {
            get { return this.title; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }
    }
}