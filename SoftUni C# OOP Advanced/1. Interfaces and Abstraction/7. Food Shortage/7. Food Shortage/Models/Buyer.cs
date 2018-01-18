namespace _7.Food_Shortage
{
    public abstract class Buyer : IBuyer
    {
        public int Food { get; protected set; }

        public string Name { get; set; }
        public int Age { get; private set; }
        public Buyer(string name, int age)
        {
            this.Name = name;
        }
        public abstract void BuyFood();        
    }
}
