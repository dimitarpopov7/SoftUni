namespace _3.Iterator
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            var collection = Console.ReadLine().Split().Skip(1).ToList();

            var listIterator = (ListIterator)Activator.CreateInstance(typeof(ListIterator), collection);
            var methods = typeof(ListIterator).GetMethods(BindingFlags.Instance | BindingFlags.Public);

            var command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    foreach (var method in methods.Where(m => m.Name == command))
                    {
                        Console.WriteLine(method.Invoke(listIterator, new object[] { }));
                    }
                }
                catch (TargetInvocationException tie)
                {
                    if(tie.InnerException is InvalidOperationException)
                    {
                        Console.WriteLine(tie.InnerException.Message);
                    }
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.Message);
                }
                command = Console.ReadLine();
            }
        }
    }
}