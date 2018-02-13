namespace _3.Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var stack = new CustomStack<int>();
            var initialPush = Console.ReadLine().Split(new[] { ',', ' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            while (initialPush[0] != "END")
            {
                try
                {
                    switch (initialPush[0])
                    {
                        case "Push":
                            var elementsToPush = initialPush.Skip(1).Select(int.Parse);
                            stack.Push(elementsToPush);
                            break;
                        case "Pop":
                            stack.Pop();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                initialPush= Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Print(stack);
            Print(stack);
        }
        public static void Print(CustomStack<int> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}