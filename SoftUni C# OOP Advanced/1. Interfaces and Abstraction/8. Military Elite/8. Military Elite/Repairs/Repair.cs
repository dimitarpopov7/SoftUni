namespace _8.Military_Elite.Repairs
{
    using Interfaces;
    public class Repair : IRepairs
    {
        private string partName;
        private int hoursWorker;

        public Repair(string partName, int hoursWorked)
        {
            this.HoursWorker = hoursWorked;
            this.PartName = partName;
        }
        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorker}";
        }
        public string PartName
        {
            get { return this.partName; }
            private set
            {
                this.partName = value;
            }
        }

        public int HoursWorker
        {
            get { return this.hoursWorker; }
            private set
            {
                this.hoursWorker = value;
            }
        }
    }
}