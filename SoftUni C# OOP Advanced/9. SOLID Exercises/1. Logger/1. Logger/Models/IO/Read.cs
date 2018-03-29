namespace _1.Logger.Models.IO
{
    using System;
    using _1.Logger.Interfaces;

    public class Read : IReader
    {
        public string ReadLine()
        {
            return $"{Console.ReadLine()}";
        }
    }
}
