namespace _9.Collection_Hierarchy.Collections
{    
    using _9.Collection_Hierarchy.Interfaces;
    public class MyList : Collection, ICountable
    {
        public int Used
        {
            get { return base.Elements.Count; }
        }

        public int Add(string element)
        {
            base.Elements.Insert(0,element);
            return 0;
        }

        public string Remove()
        {
            string returnElement=base.Elements[0];
            base.Elements.RemoveAt(0);
            return returnElement;
        }
    }
}
