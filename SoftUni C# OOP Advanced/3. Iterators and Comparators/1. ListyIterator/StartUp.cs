namespace _1.ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var createList = Console.ReadLine().Split().ToList();
            var list = new List<string>();
            for (int i = 1; i < createList.Count; i++)
            {
                list.Add(createList[i]);
            }
            var listyIterator = new ListyIterator<string>(list);
            var commmand = Console.ReadLine();
            while (commmand!="END")
            {
                switch (commmand)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move()); 
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        return;
                    case "PrintAll":
                        var sb = new StringBuilder();
                        foreach (var item in listyIterator)
                        {
                            sb.Append($"{item} ");
                        }
                        Console.WriteLine(sb);
                        break;
                }
                commmand = Console.ReadLine();
            }
        }
    }
}