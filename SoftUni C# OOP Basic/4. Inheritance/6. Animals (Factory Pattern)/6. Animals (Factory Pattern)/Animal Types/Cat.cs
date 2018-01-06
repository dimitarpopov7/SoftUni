namespace _6.Animals__Factory_Pattern_
{
    public class Cat : Animal
    {
        private string name => this.name;
        private string gender => this.gender;
        private int age => this.age;
        public override string ProduceSound()
        {
            return "MiauMiau";
        }
        public Cat(string name, string gender, int age) : base(name, gender, age)
        {
        }
    }
}