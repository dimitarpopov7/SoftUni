﻿namespace _5.Integration_Test.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using System.Linq;

    public class Category : ICategory
    {
        private string name;
        private List<IUser> users;
        private List<ICategory> childCategories;
        private ICategory parent;

        public Category(string name)
        {
            this.Name = name;
            this.users = new List<IUser>();
            this.childCategories = new List<ICategory>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Cannot create category without a name");
                }

                this.name = value;
            }
        }

        public List<ICategory> ChildCategories
        {
            get { return this.childCategories; }
        }

        public ICategory Parent
        {
            get
            {
                return this.parent;
            }

            private set
            {
                this.parent = value;
            }
        }

        public List<IUser> Users
        {
            get
            {
                return this.users;
            }

            private set
            {
                this.users = value;
            }
        }

        public void MoveUsersToParent()
        {
            if (this.Parent == null)
            {
                return;
            }

            foreach (var user in this.Users)
            {
                this.parent.AddUser(user);
            }
        }

        public void AddChild(ICategory child)
        {
            this.childCategories.Add(child);
            child.SetParent(this);
        }

        public void AddUser(IUser user)
        {
            this.users.Add(user);
            user.AddCategory(this);
        }

        public void RemoveChild(string name)
        {
            var categoryToRemove = this.childCategories.FirstOrDefault(c => c.Name == name);
            this.childCategories?.Remove(categoryToRemove);
        }

        public void SetParent(ICategory category)
        {
            this.Parent = category;
        }
    }
}