namespace _7.Food_Shortage
{
    public class Rebal :Buyer
    {
        public string Group { get; private set; }
        public Rebal(string name, int age,string group) : base(name, age)
        {
            this.Group = group;
        }

        public override void BuyFood()
        {
            this.Food += 5;
        }
    }
}
