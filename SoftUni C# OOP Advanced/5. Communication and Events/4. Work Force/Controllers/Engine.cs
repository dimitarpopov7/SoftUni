namespace _4.Work_Force.Controllers
{
    using Models;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private List<IJob> jobList;
        private List<IWorker> workersList;
        private List<int> jobToBeRemoved=new List<int>();
        public Engine()
        {
            this.jobList = new List<IJob>();
            this.workersList = new List<IWorker>();
        }
        public void Run()
        {
            var jobList = new List<Job>();
            var command = Console.ReadLine();
            while (command!="End")
            {
                if (command.Contains("Employee"))
                {
                    AddEmployee(command);
                }
                else if (command.Contains("Job"))
                {
                    AddJob(command);
                }
                else if (command.Contains("Pass"))
                {   
                    //NOT THE BEST SOLUTION CHANGE IN FUTURE...
                    foreach (var job in this.jobList)
                    {
                        job.Update();

                        if (job.HoursOfWorkRequired == 0)
                        {
                            int indexOfJobThatHasBeenDone = this.jobList.FindIndex(j=>j.Name==job.Name);
                            jobToBeRemoved.Add(indexOfJobThatHasBeenDone);
                        }
                    }
                    //NOT THE BEST APPROACH..
                    if (jobToBeRemoved.Count>0)
                    {
                        int adjustIndexer = 0;
                        foreach (var index in jobToBeRemoved)
                        {
                            this.jobList.RemoveAt(index-adjustIndexer);
                            adjustIndexer++;
                        }
                        jobToBeRemoved.Clear();
                    }
                }
                else if (command.Contains("Status"))
                {
                    foreach (var job in this.jobList)
                    {
                        Console.WriteLine(job.ToString());
                    }
                }
                command = Console.ReadLine();
            }
        }

        private void AddJob(string command)
        {
            var jobInfo = command.Split();
            var jobName = jobInfo[1];
            var jobHours = int.Parse(jobInfo[2]);
            var workerName = jobInfo[3];
            var hiredWorker = this.workersList.FirstOrDefault(w => w.Name == workerName);
            var job = new Job(jobName, jobHours, hiredWorker);
            job.JobDone += this.OnJobDone;
            this.jobList.Add(job);
        }

        private void OnJobDone(object sender, JobEventArgs args) => Console.WriteLine($"Job {args.Job.Name} done!");

        private void AddEmployee(string command)
        {
            var employeerInfo = command.Split();
            var employeeType = employeerInfo[0];
            var employeeName = employeerInfo[1];
            switch (employeeType)
            {
                case "StandartEmployee":
                    FullTimeWorker fullWorker = new FullTimeWorker(employeeName);
                    this.workersList.Add(fullWorker);
                    break;
                case "PartTimeEmployee":
                    PartTimeWorker partWorker = new PartTimeWorker(employeeName);
                    this.workersList.Add(partWorker);
                    break;
            }
        }
    }
}
