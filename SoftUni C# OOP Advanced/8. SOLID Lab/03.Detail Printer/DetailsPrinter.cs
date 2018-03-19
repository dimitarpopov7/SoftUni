namespace _03.Detail_Printer
{
    using System;
    using Interfaces;
    using System.Collections.Generic;

    public class DetailsPrinter
    {
        private IList<IWorker> employees;

        public DetailsPrinter(IList<IWorker> employees)
        {
            this.Employees = employees;
        }

        public IList<IWorker> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                this.employees = value;
            }
        }

        public void printDetails()
        {
            foreach (var employee in this.employees)
            {
                Console.WriteLine(employee.Print());
            }
        }
    }
}