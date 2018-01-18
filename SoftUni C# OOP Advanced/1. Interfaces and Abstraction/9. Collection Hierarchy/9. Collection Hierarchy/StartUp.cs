namespace _9.Collection_Hierarchy
{
    using System;
    using System.Linq;
    using _9.Collection_Hierarchy.Collections;
    public class StartUp
    {
        public static void Main()
        {
            var elementsToAdd = Console.ReadLine().Split().ToList();
            var countOfRemoveOps = int.Parse(Console.ReadLine());
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveColletion = new AddRemoveCollection();
            MyList myList = new MyList();
            foreach (var elementToAdd in elementsToAdd)
            {
                Console.Write(addCollection.Add(elementToAdd)+" ");
            }
            Console.WriteLine();
            foreach (var elementToAdd in elementsToAdd)
            {
                Console.Write(addRemoveColletion.Add(elementToAdd) + " ");
            }
            Console.WriteLine();
            foreach (var elementToAdd in elementsToAdd)
            {
                Console.Write(myList.Add(elementToAdd) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < countOfRemoveOps; i++)
            {
                Console.Write(addRemoveColletion.Remove()+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < countOfRemoveOps; i++)
            {
                Console.Write(myList.Remove()+" ");
            }
            Console.WriteLine();
        }
    }
}