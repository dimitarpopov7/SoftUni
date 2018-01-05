namespace _3.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private double weeklySalary;
        private double workingHours;
        private double salaryPerHour;
        public Worker(string firstName, string lastName, double weeklySalary, double dailyWorkingHours)
        : base(firstName, lastName)
        {
            this.WeeklySalary = weeklySalary;
            this.WorkingHours = dailyWorkingHours;
            this.SalaryPerHour = salaryPerHour;
        }
        public double SalaryPerHour
        {
            get { return this.salaryPerHour; }
            private set
            {
                value = WeeklySalary / (WorkingHours * 5);
                this.salaryPerHour = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(this.FirstName);
            sb.Append("Last Name: ").AppendLine(this.LastName);
            sb.Append("Week Salary: ").AppendLine($"{this.WeeklySalary:f2}");
            sb.Append("Hours per day: ").AppendLine($"{this.WorkingHours:f2}");
            sb.Append("Salary per hour: ").AppendLine($"{this.SalaryPerHour:f2}");
            return sb.ToString();
        }
        public double WorkingHours
        {
            get { return this.workingHours; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workingHours = value;
            }
        }

        public double WeeklySalary
        {
            get { return this.weeklySalary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weeklySalary = value;
            }
        }        
    }
} 