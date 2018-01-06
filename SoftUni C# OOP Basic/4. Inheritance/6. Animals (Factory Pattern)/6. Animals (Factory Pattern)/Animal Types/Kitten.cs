namespace _6.Animals__Factory_Pattern_
{
    public class Kitten : Cat
    {
        private string name => this.name;
        private const string gender ="Female";
        private int age => this.age;
        public override string ProduceSound()
        {
            return "Miau";
        }
        public Kitten(string name, int age) : base(name, gender, age)
        {
        }
    }
}