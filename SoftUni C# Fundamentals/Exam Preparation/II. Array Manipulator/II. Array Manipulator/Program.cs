namespace II.Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToList();
            var command = Console.ReadLine().Split().ToList();
            int maxOdd=-1;
            int maxEven=-1;
            int minOdd=-1;
            int minEven=-1;
            try
            {
                maxOdd = array.Where(x => x % 2 != 0).Max();
            }
            catch (Exception)
            {                
            }
            try
            {
                maxEven = array.Where(x => x % 2 == 0).Max();
            }
            catch (Exception)
            {                
            }
            try
            {
                minOdd = array.Where(x => x % 2 != 0).Min();
            }
            catch (Exception)
            {                
            }
            try
            {
                minEven = array.Where(x => x % 2 == 0).Min();
            }
            catch (Exception)
            {                
            }            
            while (command[0] != "end")
            {                
                if (command[0]=="max")
                {

                    if (command[1] == "odd")
                    {
                        if (maxOdd == -1)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine().Split().ToList();
                            continue;
                        }
                        Console.WriteLine(array.IndexOf(maxOdd));                        
                    }
                    else if (command[1] == "even")
                    {
                        if (maxEven == -1)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine().Split().ToList();
                            continue;
                        }
                        Console.WriteLine(array.IndexOf(maxEven));
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "odd")
                    {
                        if (minOdd == -1)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine().Split().ToList();
                            continue;
                        }
                        Console.WriteLine(array.IndexOf(minOdd));
                    }
                    else if (command[1] == "even")
                    {
                        if (minEven == -1)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine().Split().ToList();
                            continue;
                        }
                        Console.WriteLine(array.IndexOf(minEven));
                    }
                }
                else if (command[0] == "exchange")
                {
                    int movement = int.Parse(command[1]);
                    if (movement>array.Count-1||movement<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        var exchangedListF = new List<int>();
                        var exchangedListT = new List<int>();
                        for (int i = 0; i <= movement; i++)
                        {
                            exchangedListT.Add(array[i]);
                        }
                        for (int i = 0; i < array.Count-movement-1; i++)
                        {
                            exchangedListF.Add(array[movement+i+1]);
                        }
                        array = exchangedListF.ToList();
                        array.AddRange(exchangedListT);                        
                    }
                }
                else if (command[0] == "first")
                {                    
                    int count = int.Parse(command[1]);
                    var fOddL = new List<int>();
                    var fEvenL = new List<int>();
                    if (count > array.Count || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (command[2] == "odd")
                    {
                        for (int i = 0; i < array.Count; i++)
                        {
                            if (array[i] % 2 != 0)
                            {
                                fOddL.Add(array[i]);
                            }
                            if (fOddL.Count == count)
                            {
                                break;
                            }
                        }
                        Console.WriteLine($"[{string.Join(", ",fOddL)}]");
                    }                    
                    else if (command[2] == "even")
                    {
                        for (int i = 0; i < array.Count; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                fEvenL.Add(array[i]);
                            }
                            if (fEvenL.Count == count)
                            {
                                break;
                            }
                        }
                        Console.WriteLine($"[{string.Join(", ", fEvenL)}]");
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);
                    var fOddL = new List<int>();
                    var fEvenL = new List<int>();
                    if (count > array.Count || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (command[2] == "odd")
                    {
                        for (int i = array.Count-1; i >= 0; i--)
                        {
                            if (array[i] % 2 != 0)
                            {
                                fOddL.Add(array[i]);
                            }
                            if (fOddL.Count == count)
                            {
                                break;
                            }
                        }
                        fOddL.Reverse();
                        Console.WriteLine($"[{string.Join(", ", fOddL)}]");
                    }
                    else if (command[2] == "even")
                    {
                        for (int i = array.Count - 1; i >= 0; i--)
                        {
                            if (array[i] % 2 == 0)
                            {
                                fEvenL.Add(array[i]);
                            }
                            if (fEvenL.Count == count)
                            {
                                break;
                            }
                        }
                        fEvenL.Reverse();
                        Console.WriteLine($"[{string.Join(", ", fEvenL)}]");
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine($"[{string.Join(", ",array)}]");
        }
    }
}
