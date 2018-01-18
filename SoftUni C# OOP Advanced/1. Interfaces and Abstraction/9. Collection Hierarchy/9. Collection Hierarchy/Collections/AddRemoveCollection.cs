namespace _9.Collection_Hierarchy.Collections
{
    using _9.Collection_Hierarchy.Interfaces;
    public class AddRemoveCollection : Collection, IAddable, IRemovable
    {
        public int Add(string element)
        {
            base.Elements.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string returnString = base.Elements[base.Elements.Count - 1];
            base.Elements.RemoveAt(Elements.Count - 1);
            return returnString;
        }
    }
}
