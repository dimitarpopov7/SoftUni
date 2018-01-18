namespace _9.Collection_Hierarchy.Collections
{
    using _9.Collection_Hierarchy.Interfaces;
    public class AddCollection : Collection, IAddable
    {
        public int Add(string element)
        {
            base.Elements.Add(element);
            return Elements.Count - 1;
        }
    }
}