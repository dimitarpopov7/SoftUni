namespace _1.Last_Digit_Name
{
    public class Number
    {
        private int num;
        public int Num => this.num;
        public Number(int num)
        {
            this.num = num;
        }
        public void PrintLastDigit()
        {
            var lastDigit = this.num % 10;
            var lastDigitAsAWord = string.Empty;
            switch (lastDigit)
            {
                case 1:
                    lastDigitAsAWord = "one";
                    break;
                case 2:
                    lastDigitAsAWord = "two";
                    break;
                case 3:
                    lastDigitAsAWord = "three";
                    break;
                case 4:
                    lastDigitAsAWord = "four";
                    break;
                case 5:
                    lastDigitAsAWord = "five";
                    break;
                case 6:
                    lastDigitAsAWord = "six";
                    break;
                case 7:
                    lastDigitAsAWord = "seven";
                    break;
                case 8:
                    lastDigitAsAWord = "eight";
                    break;
                case 9:
                    lastDigitAsAWord = "nine";
                    break;
            }
            System.Console.WriteLine(lastDigitAsAWord);
        }
    }
}