namespace _04.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var emailBook = new Dictionary<string, string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                if (!emailBook.ContainsKey(name)&&!email.Contains(".uk")&&!email.Contains(".us"))
                {
                    emailBook[name] = email;
                }
            }
            foreach (var item in emailBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
