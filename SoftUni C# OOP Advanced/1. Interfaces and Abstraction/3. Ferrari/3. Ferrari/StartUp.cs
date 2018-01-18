namespace _3.Ferrari
{
    using System;
    public interface ICar
    {
        string Brakes();
        string Gas();
    }
    public class Ferrari : ICar
    {
        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }
        private string driverName;

        public string DriverName
        {
            get { return this.driverName; }
            set { this.driverName = value; }
        }
        private string model;

        public string Model
        {
            get { return this.model; }
            set { this.model= "488-Spider"; }
        }       
        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
            this.Model = model;
        }
    }
    public class StartUp
    {
        public static void Main()
        {
            var driver = Console.ReadLine();
            var car = new Ferrari(driver);
            Console.WriteLine($"{car.Model}/{car.Brakes()}/{car.Gas()}/{car.DriverName}");

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}