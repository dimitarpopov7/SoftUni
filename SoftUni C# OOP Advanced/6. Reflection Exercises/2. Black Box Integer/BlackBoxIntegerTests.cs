namespace _02BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var command = Console.ReadLine().Split('_').ToList();
            var box = (BlackBoxInt)Activator.CreateInstance(typeof(BlackBoxInt), true);
            var methods = typeof(BlackBoxInt).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            while (command[0]!="END")
            {
                var action = command[0];
                var number = int.Parse(command[1]);

                foreach (var method in methods)
                {
                    if (method.Name == action)
                    {
                        method.Invoke(box, new object[] { number });
                        var innerValue = typeof(BlackBoxInt).GetField("innerValue",BindingFlags.Instance | BindingFlags.NonPublic);
                        Console.WriteLine(innerValue.GetValue(box));
                    }
                }
                command = Console.ReadLine().Split('_').ToList();
            }
        }
    }
}