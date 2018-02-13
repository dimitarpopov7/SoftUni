namespace _3.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class CustomStack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 2;
        private T[] collection;
        private int lenght;
        public CustomStack()
        {
            this.collection = new T[InitialCapacity];
        }
        public void Push(T item)
        {
            if (this.lenght >= this.collection.Length)
            {
                Array.Resize(ref this.collection, this.collection.Length * 2);
            }
            this.collection[this.lenght] = item;
            lenght++;
        }
        public void Push(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.Push(item);
            }
        }
        public T Pop()
        {
            if (this.lenght == 0)
            {
                throw new ArgumentException("No elements");
            }
            this.lenght--;
            T item = this.collection[this.lenght];
            this.collection[this.lenght] = default(T);
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.lenght - 1; i >= 0; i--)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}