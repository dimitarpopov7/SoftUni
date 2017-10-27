namespace _07.Multiply_big_number
{
    using System;
    using System.Text;
    public class Program
    {
        public static void Main()
        {
            var num1 = Console.ReadLine().TrimStart('0');
            var num2 = Console.ReadLine();
            if (num2 == "0"||num1=="0")
            {
                Console.WriteLine("0");
                return;
            }
            StringBuilder sb = new StringBuilder();
            var str1 = num1.ToCharArray();
            var str2 = num2.ToCharArray();
            sbyte addition = 0;
            sbyte reminder = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                sbyte n1 = sbyte.Parse(str1[i].ToString());
                sbyte n2 = sbyte.Parse(str2[0].ToString());
                if (i == 0)
                {
                    var lastMultiplication = (n1 * n2 + addition).ToString().ToCharArray();
                    if (lastMultiplication.Length > 1)
                    {
                        sb.Append(lastMultiplication[1]);
                        sb.Append(lastMultiplication[0]);
                        break;
                    }
                    else
                    {
                        sb.Append(lastMultiplication[0]);
                        break;
                    }
                }
                if (n1 * n2 +addition< 10)
                {
                    sb.Append(n1 * n2+addition);
                    addition = 0;
                }
                else
                {
                    reminder = (sbyte)((n1 * n2+addition) % 10);
                    sb.Append(reminder);
                    addition = (sbyte)((n1 * n2+addition) / 10);
                }
            }
            var endresult = sb.ToString().ToCharArray();
            Array.Reverse(endresult);
            foreach (var num in endresult)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }
    }
}
