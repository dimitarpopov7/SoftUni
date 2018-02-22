namespace _4.Work_Force.Models
{
    using Interfaces;
    public abstract class Worker : IWorker
    {
        private string name;
        private int workingHours;

        public Worker(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int WorkingHours
        {
            get { return this.workingHours; }
            set { this.workingHours = value; }
        }
    }
}
