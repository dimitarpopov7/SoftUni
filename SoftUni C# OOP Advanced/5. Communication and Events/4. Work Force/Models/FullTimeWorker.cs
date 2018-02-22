namespace _4.Work_Force.Models
{
    public class FullTimeWorker : Worker
    {
        public FullTimeWorker(string name) : base(name)
        {
            this.WorkingHours = 40;
        }
    }
}
