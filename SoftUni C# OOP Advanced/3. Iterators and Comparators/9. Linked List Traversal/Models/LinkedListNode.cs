namespace _9.Linked_List_Traversal.Models
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T item)
        {
            this.Item = item;
        }
        public T Item { get; set; }
        public LinkedListNode<T> Next { get; internal set; }
        public LinkedListNode<T> Previous { get; internal set; }
        public override string ToString()
        {
            return this.Item.ToString();
        }
    }
}

