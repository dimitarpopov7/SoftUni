namespace _3.Wind_Farm
{
    public abstract class Food
    {
        public int Quantity { get; set; }
        public Food(int quantity)
        {
            this.Quantity = quantity;
;        }
    }
}