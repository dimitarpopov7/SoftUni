namespace _03.Detail_Printer
{
    using System;
    using Interfaces;
    public class Employee:IWorker
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string Print()
        {
            return this.Name;
        }
    }
}