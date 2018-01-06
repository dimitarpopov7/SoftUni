namespace _6.Animals__Factory_Pattern_
{
    public class Dog:Animal
    {
        private string name => this.name;
        private string gender => this.gender;
        private int age => this.age;
        public override string ProduceSound()
        {
            return "BauBau";
        }
        public Dog(string name,string gender, int age ) : base(name,gender,age)
        {
        }        
    }
}