namespace _03.Detail_Printer
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using System.Text;

    public class Manager : IWorker
    {
        public Manager(string name, ICollection<string> documents) 
        {
            this.Name = name;
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public string Name { get; set; }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(string.Join(Environment.NewLine, this.Documents));
            return sb.ToString().TrimEnd();
        }
    }
}
