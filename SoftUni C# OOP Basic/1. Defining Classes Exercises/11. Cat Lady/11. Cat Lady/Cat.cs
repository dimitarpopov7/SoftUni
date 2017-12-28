namespace _11.Cat_Lady
{
    public class Cat
    {
        private string type;
        public string Type
        {
            get { return this.type; }
        }

        private string name;
        public string Name
        {
            get { return this.name; }
        }
        private int dicibels;
        public int Dicibels
        {
            get { return this.dicibels ; }
            set { this.dicibels = value; }
        }

        private double furLenght;
        public double FurLenght
        {
            get { return this.furLenght; }
            set { this.furLenght = value; }
        }

        private int earSize;
        public int EarSize
        {
            get { return this.earSize; }
            set { this.earSize = value; }
        }

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat(string name, string type) : this(name)
        {
            this.type = type;
        }

        public Cat(string type, string name, int dicibels) : this(name, type)
        {
            this.dicibels = dicibels;
        }

        public Cat(string type, int earSize, string name) : this(name, type)
        {
            this.earSize = earSize;
        }
        public Cat(string type, string name, double furLenght) : this(name, type)
        {
            this.furLenght = furLenght;
        }
    }
}
