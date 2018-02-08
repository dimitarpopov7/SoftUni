namespace _8.Custom_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CustomList<T>:IEnumerable<T>
        where T:IComparable
    {
        private T[] elements;
        private int count;
        private const int InitialCapacity= 16;

        public CustomList()
        {
            this.elements = new T[InitialCapacity];
            this.Count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public T this[int index]
        {
            get
            {
                this.ValidateIndices(index);
                return this.elements[index];
            }
        }
        
        public void Add(T element)
        {
            if (this.count + 1 >= this.elements.Length)
            {
                Resize();
            }
            
            this.elements[Count] = element;
            Count++;
        }

        public T Remove (int index)
        {
            this.ValidateIndices(index);
            T element = this.elements[index];
            this.DecreaseElementsCount(index);
            return element;

        }
        public bool Containts(T element)
        {
            this.ValidateOperation();
            bool contains = false;
            for (int i = 0; i < this.Count; i++)
            {
                if (elements[i].Equals(element))
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        public void Swap(int indexSource,int indexDestination)
        {
            ValidateIndices(indexSource,indexDestination);
            T temp = this.elements[indexSource];
            this.elements[indexSource] = elements[indexDestination];
            this.elements[indexDestination] = temp;
        }
        
        public int CountGreaterThan(T element)
        {
            int count = 0;
            for (int i = 0; i < Count; i++)
            {
                if (this.elements[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        
        public T Max()
        {
            this.ValidateOperation();
            T maxElement = elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (maxElement.CompareTo(elements[i]) < 0)
                {
                    maxElement = elements[i];
                }
            }
            return maxElement;
        }

        public T Min()
        {
            this.ValidateOperation();
            T minElement = elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (minElement.CompareTo(elements[i]) > 0)
                {
                    minElement = elements[i];
                }
            }
            return minElement;
        }

        public string Print()
        {
            //Without IEnumerable<T>
            //var sb = new StringBuilder();
            //for (int i = 0; i < Count; i++)
            //{
            //    sb.Append(elements[i]);
            //    sb.Append(Environment.NewLine);
            //}
            //return sb.ToString().TrimEnd('\n');
            return string.Join(Environment.NewLine, this.elements.Take(this.Count));
        }

        public T[] Sort()
        {
            this.elements = elements.Take(this.Count).OrderBy(x => x).ToArray();
            return this.elements;
        }
        private void ValidateOperation()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("Collection is empty.");
            }
        }

        private void DecreaseElementsCount(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[this.Count - 1] = default(T);
            this.Count--;
        }

        private void Resize()
        {
            int currentLenght = this.elements.Length;
            T[] newElements= new T[currentLenght*2];
            Array.Copy(this.elements, newElements, currentLenght);
            this.elements = newElements;
        }

        private void ValidateIndices(params int[] indices)
        {
            for (int i = 0; i < indices.Length; i++)
            {
                if (indices[i] >= this.Count || indices[i] < 0)
                {
                    throw new IndexOutOfRangeException("Index is outside the bounds out of the collection");
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this.elements.Take(this.Count).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this.elements.Take(this.Count).GetEnumerator();
        }
    }
}