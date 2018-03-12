namespace _5.Integration_Test.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class User:IUser
    {
        private string name;
        private List<ICategory> categories;

        public User(string name)
        {
            this.Name = name;
            this.Categories = new List<ICategory>();
        }

        public string Name { get => this.name; set => this.name = value; }
        public List<ICategory> Categories { get => this.categories; set => this.categories = value; }

        public void AddCategory(ICategory category)
        {
            this.Categories.Add(category);
        }

        public void RemoveCategory(ICategory category)
        {
            this.Categories.Remove(category);
            if (category.Parent != null)
            {
                this.categories.Add(category.Parent);
            }
        }
    }
}
