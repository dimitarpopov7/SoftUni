namespace _6.Animals__Factory_Pattern_
{
    using System;
    using System.Text;
    public abstract class Animal
    {
        private string name;
        private string gender;
        private int age;
        public abstract string ProduceSound();
        //constructor
        public Animal(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
        //desired output
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.age.ToString()} {this.Gender}");
            sb.Append(ProduceSound());
            return sb.ToString();
        }                
        //Properties
        public string Name
        {
            get { return this.name; }
            private set
            {
                if(value == null)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid input!");                    
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.gender = value;
            }
        }
    }
}