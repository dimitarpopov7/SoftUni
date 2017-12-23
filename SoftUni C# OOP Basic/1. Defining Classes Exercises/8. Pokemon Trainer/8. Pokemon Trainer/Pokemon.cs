namespace _8.Pokemon_Trainer
{
    public class Pokemon
    {
        private string name;
        private int health;
        private string element;
        public Pokemon(string name,int health,string element)
        {
            this.name = name;
            this.health = health;
            this.element = element;
        }
        public string Element
        {
            get { return this.element; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
    }
}
