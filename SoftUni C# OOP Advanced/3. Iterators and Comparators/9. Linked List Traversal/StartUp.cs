namespace _9.Linked_List_Traversal
{
    using System;
    using _9.Linked_List_Traversal.Models;
    public class StartUp
    {
       
            public static void Main()
            {
                var linkedList = new GenericLinkedList<int>();
                ExecuteCommands(linkedList);
                PrinntResult(linkedList);
            }

            private static void PrinntResult(GenericLinkedList<int> linkedList)
            {
                Console.WriteLine(linkedList.Count);
                Console.WriteLine(string.Join(" ", linkedList));
            }

            private static void ExecuteCommands(GenericLinkedList<int> linkedList)
            {
                var numberOfCommands = int.Parse(Console.ReadLine());

                while (numberOfCommands > 0)
                {
                    var command = Console.ReadLine().Split();
                    var number = int.Parse(command[1]);

                    switch (command[0])
                    {
                        case "Add":
                            linkedList.Add(number);
                            break;
                        case "Remove":
                            linkedList.Remove(number);
                            break;
                        default:
                            break;
                    }
                    numberOfCommands--;
                }
            }
        }
    }

