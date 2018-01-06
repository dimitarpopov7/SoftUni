namespace _6.Animals__Factory_Pattern_
{
    public class Tomcat : Cat
    {
        private string name => this.name;
        private const string gender ="Male";
        private int age => this.age;
        public override string ProduceSound()
        {
            return "Give me one million b***h!";
        }
        public Tomcat(string name, int age) : base(name, gender, age)
        {
        }
    }
}