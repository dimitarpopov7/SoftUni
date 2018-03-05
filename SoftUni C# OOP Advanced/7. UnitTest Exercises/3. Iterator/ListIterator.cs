namespace _3.Iterator
{
    using System;
    using System.Collections.Generic;

    public class ListIterator
    {
        private List<string> collection;
        private int internalIndex;

        public ListIterator(IEnumerable<string> collection)
        {
            if (collection== null)
            {
                throw new ArgumentNullException();
            }
            this.collection = new List<string>(collection);
        }

        public bool Move()
        {
            if (internalIndex + 2 <= collection.Count)
            {
                internalIndex++;
                return true;
            }
            else return false;
        }

        public bool HasNext()
        {
            if (internalIndex + 2 <= collection.Count)
            {
                return true;
            }
            else return false;
        }

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.Write(this.collection[internalIndex]);
        }
    }
}