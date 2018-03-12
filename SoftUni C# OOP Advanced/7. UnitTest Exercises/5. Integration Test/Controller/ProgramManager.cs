namespace _5.Integration_Test.Controller
{
    using _5.Integration_Test.Interfaces;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class ProgramManager
    {
        private List<ICategory> listOfCategories;

        public ProgramManager()
        {
            this.listOfCategories = new List<ICategory>();
        }

        public ProgramManager(string[] names):this()
        {
            foreach (var name in names)
            {
                this.AddCategory(name);
            }
        }

        public void AddCategory(string name)
        {
            this.listOfCategories.Add(new Category(name));
        }

        public void AddCategory(string[] names)
        {
            foreach (var name in names)
            {
                this.AddCategory(name);
            }
        }

        public void RemoveCategory(string name)
        {
            var categoryToRemove = this.listOfCategories.FirstOrDefault(c => c.Name == name);
            if (categoryToRemove == null)
            {
                foreach (var category in this.listOfCategories)
                {
                    if ((categoryToRemove = category.ChildCategories
                        .FirstOrDefault(c => c.Name == name)) != null)
                    {
                        break;
                    }
                }
            }

            if (categoryToRemove == null)
            {
                return;
            }

            categoryToRemove.MoveUsersToParent();
            this.RemoveCategoryFromUsersLists(categoryToRemove);
            this.MooveChildrentCategoriesToParent(categoryToRemove);

            if (categoryToRemove.Parent == null)
            {
                this.listOfCategories.Remove(categoryToRemove);
            }
            else
            {
                categoryToRemove.Parent.RemoveChild(categoryToRemove.Name);
            }
        }

        public void RemoveCategory(IEnumerable<string> names)
        {
            foreach (var categoryName in names)
            {
                this.RemoveCategory(categoryName);
            }
        }

        public void AddChild(ICategory parent, string childName) => parent.AddChild(new Category(childName));

        public void AddUser(ICategory category, IUser user) => category.AddUser(user);

        private void MooveChildrentCategoriesToParent(ICategory categoryToRemove)
        {
            if (categoryToRemove.Parent == null)
            {
                foreach (var category in categoryToRemove.ChildCategories)
                {
                    this.listOfCategories.Add(category);
                }

                return;
            }

            foreach (var child in categoryToRemove.ChildCategories)
            {
                categoryToRemove.Parent.AddChild(child);
            }
        }

        private void RemoveCategoryFromUsersLists(ICategory categoryToRemove)
        {
            foreach (var user in categoryToRemove.Users)
            {
                user.RemoveCategory(categoryToRemove);
            }
        }
    }
}