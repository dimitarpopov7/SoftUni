namespace _03.Unicode_Characters
{
    using System;
    using System.Text;public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var sb = new StringBuilder();
            foreach (var character in text)
            {
                sb.AppendFormat("\\u{0:x4}", (uint)character);
            }            
            Console.WriteLine(sb.ToString());
        }        
    }
}
