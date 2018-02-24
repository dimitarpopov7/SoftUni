namespace _1.Harvesting_Fields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Engine
    {
        public void Run()
        {
            var command = Console.ReadLine();
            var typeOfRichSoil = (typeof(RichSoilLand));
            var fieldTypes = typeOfRichSoil.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            while (true)
            {
                switch (command)
                {
                    case "public":
                        Output(fieldTypes.Where(f => f.IsPublic));
                        break;
                    case "private":
                        Output(fieldTypes.Where(f => f.IsPrivate));
                        break;
                    case "protected":
                        Output(fieldTypes.Where(f => f.IsFamily));
                        break;
                    case "all":
                        Output(fieldTypes);
                        break;
                    case "HARVEST":
                        return;
                }
                command = Console.ReadLine();
            }
        }

        private static void Output(System.Collections.Generic.IEnumerable<FieldInfo> fieldType)
        {
            foreach (var field in fieldType)
            {
                if (field.Attributes.ToString() == "Family")
                {
                    Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                }
                else
                {
                    Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}