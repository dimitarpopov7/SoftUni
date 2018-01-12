namespace _1.Avatar
{
    public abstract class Monuments
    {
        private string name;
        public virtual int BonusPower { get; set; }

        public Monuments(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public override string ToString()
        {
            return $" Monument: {this.Name}, ";
        }
    }
}