namespace _06.Sum_big_numbers
{
    using System;
    using System.Text;
    public class Program
    {
        public static void Main()
        {
            var num1 = Console.ReadLine().TrimStart('0');
            var num2 = Console.ReadLine().TrimStart('0');
            StringBuilder sb = new StringBuilder();
            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else if (num1.Length < num2.Length)
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }
            var str1 = num1.ToCharArray();
            var str2 = num2.ToCharArray();
            sbyte remainder = 0;
            sbyte addition = 0;
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                sbyte n1 = sbyte.Parse(str1[i].ToString());
                sbyte n2 = sbyte.Parse(str2[i].ToString());
                n1 += addition;
                addition = 0;
                if (n1 + n2 < 10)
                {
                    sb.Append(n1 + n2);
                }
                else
                {
                    remainder = (sbyte)((n1 + n2) % 10);
                    sb.Append(remainder);
                    addition = (sbyte)((n1 + n2) / 10);
                }
            }
            if (addition != 0)
            {
                sb.Append(addition);
            }            
            var endResult = sb.ToString().ToCharArray();
            Array.Reverse(endResult);
            foreach (var num in endResult)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }
    }
}
