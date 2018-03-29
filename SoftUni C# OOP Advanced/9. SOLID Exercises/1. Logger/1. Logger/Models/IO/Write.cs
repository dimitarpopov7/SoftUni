namespace _1.Logger.Models.IO
{
    using System;
    using _1.Logger.Interfaces;
    public class Writer : IWriter
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}
