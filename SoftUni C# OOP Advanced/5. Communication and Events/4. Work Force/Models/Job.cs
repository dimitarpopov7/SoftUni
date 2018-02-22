namespace _4.Work_Force.Models
{
    using Interfaces;

    public delegate void JobDoneEventHandler(object sender, JobEventArgs args);
    public class Job:IJob
    {
        private string name;
        private int hoursOfWorkRequired;
        private IWorker employee;

        public event JobDoneEventHandler JobDone;

        public Job(string name, int hoursOfWorkRequired, IWorker employee)
        {
            this.Name = name;
            this.HoursOfWorkRequired = hoursOfWorkRequired;
            this.Employee = employee;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int HoursOfWorkRequired
        {
            get { return this.hoursOfWorkRequired; }
            set
            {
                this.hoursOfWorkRequired = value;
                if (this.hoursOfWorkRequired <= 0)
                {
                    this.hoursOfWorkRequired = 0;
                    this.JobDone?.Invoke(this, new JobEventArgs(this));
                }
            }
        }

        public IWorker Employee
        {
            get { return this.employee; }
            set { this.employee = value; }
        }

        public void Update()
        {
            this.HoursOfWorkRequired -= this.Employee.WorkingHours;
        }
        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.HoursOfWorkRequired}";
        }
    }
}