namespace _2.Number_in_Reversed_Order
{
    using System;
    public class Number
    {
        private string num;
        public string Num => this.num;
        public Number(string num)
        {
            this.num = num;
        }
        public void ReverseNum()
        {
            var number = this.num.ToCharArray();
            Array.Reverse(number);
            var reversedNum = new string(number);
            Console.WriteLine(reversedNum);
        }
    }
}
