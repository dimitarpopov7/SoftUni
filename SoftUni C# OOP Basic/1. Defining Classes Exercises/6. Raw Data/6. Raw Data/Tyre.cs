namespace _6.Raw_Data
{
    public class Tyre
    {
        private int age;
        private double pressure;
        public Tyre(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }
        public double Pressure
        {
            get { return this.pressure; }
        }
        public int Age
        {
            get { return this.age; }            
        }        
    }
}
