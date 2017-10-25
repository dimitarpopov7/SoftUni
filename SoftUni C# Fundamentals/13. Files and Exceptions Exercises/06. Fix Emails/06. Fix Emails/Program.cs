namespace _06.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            var text = File.ReadLines("./TextFile1.txt").ToList();
            string output = "./Output.txt";
            var register = new Dictionary<string, string>();
            for (int i = 0; i < text.Count-1; i=i+2)
            {
                string name = text[i];
                string email = text[i + 1];
                if (!register.ContainsKey(name)&&(!email.Contains(".uk"))&&(!email.Contains(".us")))
                {
                    register[name] = email;
                }
            }
            foreach (var name in register)
            {
                File.AppendAllText(output, ($"{name.Key} -> {name.Value}"));
                File.AppendAllText(output, Environment.NewLine);
            }
        }
    }
}
