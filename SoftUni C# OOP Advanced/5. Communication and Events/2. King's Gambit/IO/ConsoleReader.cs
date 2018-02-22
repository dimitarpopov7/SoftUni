namespace _2.King_s_Gambit.IO
{
    using System;
    using Interfaces;
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}

