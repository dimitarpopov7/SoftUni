namespace _10.Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string start = string.Empty;
            var stack = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                int option = int.Parse(command[0]);
                //option 1 
                if (option == 1)
                {
                    stack.Push(start);
                    if (start.Length == 0)
                    {
                        start = command[1];
                    }
                    else
                    {
                        start=start+command[1];
                    }
                }
                //option 2
                else if (option == 2)
                {
                    stack.Push(start);
                    if (start.Length == 0||start.Length<int.Parse(command[1]))
                    {
                        continue;
                    }
                    else
                    {
                        var newString = start.Substring(0, start.Length - int.Parse(command[1]));
                        start = newString;
                    }
                }
                // option 3 prints
                else if (option==3)
                {
                    try
                    {
                        Console.WriteLine(start[int.Parse(command[1]) - 1]);
                    }
                    catch (Exception)
                    {

                        continue;
                    }
                }
                // option 4 reverses previous option 1 or 2
                else if (option==4)
                {                    
                    start = stack.Pop();
                }
            }
        }
    }
}
