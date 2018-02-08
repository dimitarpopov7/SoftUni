namespace _12.Threeuple
{
    public class Threeuple<T1, T2, T3>
    {
        T1 FirstItem { get; set; }
        T2 SecondItem { get; set; }
        T3 ThirdItem { get; set; }

        public Threeuple(T1 firstItem, T2 secondItem,T3 thirdItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.ThirdItem = thirdItem;
        }
        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem} ->{this.ThirdItem}";
        }
    }
}
