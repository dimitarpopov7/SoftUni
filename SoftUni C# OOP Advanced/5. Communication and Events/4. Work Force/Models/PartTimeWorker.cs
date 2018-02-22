namespace _4.Work_Force.Models
{
    public class PartTimeWorker : Worker
    {
        public PartTimeWorker(string name) : base(name)
        {
            this.WorkingHours = 20;
        }
    }
}
