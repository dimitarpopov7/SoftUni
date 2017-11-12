namespace _5.Calculate_Sequence_with_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            var elementsInSequence = new Queue<long>();
            var listElements = new List<long>();
            elementsInSequence.Enqueue(n);
            listElements.Add(n);

            while (listElements.Count<50)
            {
                long currentElement = elementsInSequence.Dequeue();
                long firstElement = currentElement + 1;
                long secondElement = currentElement * 2 + 1;
                long thirdElement = currentElement + 2;

                elementsInSequence.Enqueue(firstElement);
                elementsInSequence.Enqueue(secondElement);
                elementsInSequence.Enqueue(thirdElement);

                listElements.Add(firstElement);
                listElements.Add(secondElement);
                listElements.Add(thirdElement);
            }
            Console.WriteLine(string.Join(" ", listElements.Take(50)));
        }
    }
}
