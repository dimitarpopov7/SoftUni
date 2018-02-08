namespace _11.Tuple
{
    public partial class StartUp
    {
        public class Tuple<T1, T2>
        {
            public T1 FirstItem { get; set; }
            T2 SecondItem { get; set; }
            
            public Tuple(T1 firstItem, T2 secondItem)
            {
                this.FirstItem = firstItem;
                this.SecondItem = secondItem;
            }
            public override string ToString()
            {
                return $"{this.FirstItem} -> {this.SecondItem}";
            }
        }
    }
}
