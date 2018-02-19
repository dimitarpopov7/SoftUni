namespace _10.Create_Custom_Class_Attribute.Attributes
{
    using System;
    [AttributeUsage(AttributeTargets.Class)]
    public class CustomAttribute:Attribute
    {
        private string author;
        private int revision;
        private string description;
        private string reviewers;

        public CustomAttribute()
        {
            this.Author = "Pesho";
            this.Revision = 3;
            this.Description = "Used for C# OOP Advanced Course - Enumerations and Attributes.";
            this.Reviewers = "Pesho, Svetlio";
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            private set
            {
                this.author= value;
            }
        }
        public int Revision
        {
            get
            {
                return this.revision;
            }
            private set
            {
                this.revision=value;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            private set
            {
                this.description=value;
            }
        }
        public string Reviewers
        {
            get
            {
                return this.reviewers;
            }
            private set
            {
                this.reviewers=value;
            }
        }
    }
}
