namespace _1.ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class ListyIterator<T>:IEnumerable<T>
    {
        private readonly List<T> list;
        private int internalIndex = 0;
        public ListyIterator(List<T> listToCreate)
        {
            this.list = listToCreate;
        }
        public bool Move()
        {
            if (this.internalIndex < this.list.Count-1)
            {
                internalIndex++;
                return true;
            }
            else return false;
        }
        public bool HasNext()
        {
            if (this.internalIndex < this.list.Count-1)
            {
                return true;
            }
            else return false;
        }
        public void Print()
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[this.internalIndex]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
