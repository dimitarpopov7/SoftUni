namespace _7.Car_Salesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string color;
        private string weight;
        public Car(string model,Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.color = "n/a";
            this.weight = "n/a";
        }
        public Car(string model, Engine engine,string color)
            :this(model,engine)
        {
            this.color = color;
        }
        public Car(string model, string weight, Engine engine)
            : this(model, engine)
        {
            this.weight = weight;
        }
        public Car(string model,Engine engine, string color,string weight)
            :this(model, engine)
        {
            this.color = color;
            this.weight = weight;
        }
        public string Model
        {
            get { return this.model; }
        }
        public Engine Engine
        {
            get { return this.engine; }
        }
        public string Weight
        {
            get { return this.weight; }
        }
        public string Color
        {
            get { return this.color; }
        }
    }
}