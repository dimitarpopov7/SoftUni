namespace _9.Collection_Hierarchy.Collections 
{
    using System.Collections.Generic;
    public abstract class Collection
    {
        const int MaxCapacity = 50;

        private List<string> elements;

        protected Collection()
        {
            this.Elements = new List<string>(MaxCapacity);
        }

        public List<string> Elements
        {
            get { return this.elements; }
            protected set { this.elements = value; }
        }
        
    }
}