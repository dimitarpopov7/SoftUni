namespace _3.Card_Power.Attributes
{
    using System;
    [AttributeUsage(AttributeTargets.Enum)]
    public class TypeAttributes:Attribute
    {
        private string type;
        private string category;
        private string description;

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public override string ToString()
        {
            return $"Type = {this.Type}, Description = {this.Description}";
        }
    }
}
