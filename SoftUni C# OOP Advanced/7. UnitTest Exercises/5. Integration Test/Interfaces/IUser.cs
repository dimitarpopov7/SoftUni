namespace _5.Integration_Test.Interfaces
{
    using System.Collections.Generic;

    public interface IUser
    {
        string Name { get; set; }

        List<ICategory> Categories { get; set; }

        void AddCategory(ICategory category);

        void RemoveCategory(ICategory category);
    }
}
