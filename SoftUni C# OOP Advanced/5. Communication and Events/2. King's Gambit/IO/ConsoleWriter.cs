namespace _2.King_s_Gambit.IO
{
    using System;
    using Interfaces;
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
