namespace _10.Create_Custom_Class_Attribute.Controllers
{
    using System;
    using Attributes;
    using System.Reflection;
    using System.Linq;

    [Custom]
    public class Engine
    {
        public void Run()
        {
            var command = Console.ReadLine();
            var myAttributes = (CustomAttribute)typeof(Engine).GetCustomAttributes(false).FirstOrDefault();
            
            while (command!="END")
            {
                switch (command)
                {
                    case "Author":
                        Console.WriteLine($"Author: {myAttributes.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"Revision: {myAttributes.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {myAttributes.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {myAttributes.Reviewers}");
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}