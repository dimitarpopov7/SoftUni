namespace _2.Randomize_words
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < text.Length; pos1++)
            {
                int pos2 = rnd.Next(text.Length);
                string temp = text[pos1];
                text[pos1] = text[pos2];
                text[pos2] = temp;                
            }
            Console.WriteLine(string.Join("\r\n", text));
        }
    }
}
