using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.List_Manipulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                // Add number to list at a given index
                if (command[0] == "add")
                {
                    numbers.Insert(Convert.ToInt32(command[1]), Convert.ToInt32(command[2]));
                }
                // Check if number exists in list
                else if (command[0] == "contains")
                {
                    if (numbers.Contains(Convert.ToInt32(command[1])))
                    {
                        Console.WriteLine(numbers.IndexOf(Convert.ToInt32(command[1])));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                // Remove given number from list
                else if (command[0] == "remove")
                {
                    numbers.Remove(numbers[Convert.ToInt32(command[1])]);
                }
                // Add numbers from given index
                else if (command[0] == "addMany")
                {
                    int index = Convert.ToInt32(command[1]);
                    for (int i = 0; i < command.Count - 2; i++)
                    {
                        numbers.Insert((i + index), Convert.ToInt32(command[i + 2]));
                    }
                }
                // Shift numbers by given number
                else if (command[0] == "shift")
                {
                    List<int> newNums = Enumerable.Range(1, numbers.Count).ToList();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (i - Convert.ToInt32(command[1]) >= 0)
                        {
                            newNums[(i - Convert.ToInt32(command[1]))] = numbers[i];
                        }
                        else if (i - Convert.ToInt32(command[1]) < 0)
                        {
                            newNums[numbers.Count - (Convert.ToInt32(command[1])) + i] = numbers[i];
                        }
                    }
                    numbers = new List<int>(newNums);
                }
                // Sum pairs 
                else if (command[0] == "sumPairs")
                {
                    List<int> newNums = new List<int>();
                    if (numbers.Count % 2 != 0)
                    {
                        int num = -1;
                        for (int i = 0; i < numbers.Count / 2 + 1; i++)
                        {
                            if (i == 0)
                            {
                                newNums.Add(numbers[i] + numbers[i + 1]);
                            }
                            else if (i != 0 && i != numbers.Count / 2)
                            {
                                newNums.Add(numbers[i + num + 1] + numbers[i + num + 2]);
                            }
                            else if (i == numbers.Count / 2)
                            {
                                newNums.Add(numbers[numbers.Count - 1]);
                            }
                            num++;
                        }
                    }
                    else if (numbers.Count % 2 == 0)
                    {
                        int num = -1;
                        for (int i = 0; i < numbers.Count / 2; i++)
                        {
                            if (i == 0)
                            {
                                newNums.Add(numbers[i] + numbers[i + 1]);
                            }
                            else if (i != 0 && i != numbers.Count / 2)
                            {
                                newNums.Add(numbers[i + 1 + num] + numbers[i + num + 2]);
                            }
                            num++;
                        }
                    }
                    numbers = new List<int>(newNums);

                }
                // Command to Print end Result
                else if (command[0] == "print")
                {
                    break;
                }
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}