namespace _4.Work_Force.Interfaces
{
    using Models;

    public interface IJob
    {
        event JobDoneEventHandler JobDone;

        string Name { get; set; }

        int HoursOfWorkRequired { get; set; }

        IWorker Employee { get; set; }

        void Update();

    }
}