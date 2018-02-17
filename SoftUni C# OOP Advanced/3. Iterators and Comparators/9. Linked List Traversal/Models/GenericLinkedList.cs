﻿namespace _9.Linked_List_Traversal.Models
{
    using System.Collections;
    using System.Collections.Generic;

    public class GenericLinkedList<T> : IEnumerable<T>
    {
        private LinkedListNode<T> firstElement;
        public int Count { get; private set; }
        public LinkedListNode<T> Head { get; private set; }

        public GenericLinkedList()
        {

        }
        public GenericLinkedList(T item)
        {
            var currentNode = new LinkedListNode<T>(item);
            this.Head = currentNode;
            this.firstElement = currentNode;
            this.Count = 1;
        }
        public void Add(T item)
        {
            var currentNode = new LinkedListNode<T>(item);
            if (Count == 0)
            {
                this.Head = currentNode;
                this.firstElement = currentNode;
            }
            else
            {
                this.Head.Next = currentNode;
                currentNode.Previous = this.Head;
                this.Head = currentNode;
            }
            this.Count++;
        }
        public bool Remove(T item)
        {
            var currentNode = this.firstElement;
            if (this.Count == 1)
            {
                this.Clear();
            }
            while (currentNode.Next != null)
            {
                if (currentNode.Item.Equals(item))
                {
                    if (currentNode.Previous != null)
                    {
                        currentNode.Previous.Next = currentNode.Next;
                    }
                    else
                    {
                        this.firstElement = this.firstElement.Next;
                        this.firstElement.Previous = null;
                    }
                    if (currentNode.Next != null)
                    {
                        currentNode.Next.Previous = currentNode.Previous;
                    }
                    else
                    {
                        currentNode.Previous.Next = null;
                    }


                    this.Count--;
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
        public void Clear()
        {
            this.firstElement = null;
            this.Head = null;
            this.Count = 0;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.firstElement;
            while (currentNode != null)
            {
                yield return currentNode.Item;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}