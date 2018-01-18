namespace _8.Military_Elite
{
    using Interfaces;
    public abstract class Soldier : ISoldier
    {
        private string id;
        private string firstName;
        private string lastName;

        public Soldier(string firstName,string lastName, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.ID}";
        }
        public string ID
        {
            get { return this.id; }
            private set
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                this.lastName = value;
            }
        }        
    }
}