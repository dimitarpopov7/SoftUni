namespace _5.Integration_Test.Interfaces
{
    using System.Collections.Generic;

    public interface ICategory
    {
        string Name { get; }

        ICategory Parent { get; }

        List<IUser> Users { get; }

        List<ICategory> ChildCategories { get; }

        void AddChild(ICategory child);

        void MoveUsersToParent();

        void RemoveChild(string name);

        void AddUser(IUser user);

        void SetParent(ICategory category);
    }
}
