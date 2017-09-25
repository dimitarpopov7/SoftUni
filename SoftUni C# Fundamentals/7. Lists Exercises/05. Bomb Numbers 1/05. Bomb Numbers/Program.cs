using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bomb_Numbers
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> commands = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == commands[0])
                {
                    for (int j = 0; j < commands[1]; j++)
                    {
                        if (i + commands[1] <= numbers.Count-1)
                        {
                            numbers.RemoveAt(i + 1);
                        }
                        else if (i + commands[1] > numbers.Count-1 && i != numbers.Count - 1&&i+1+j>1)
                        {
                            numbers.RemoveAt(i + 1);
                        }
                        if (i + 1 >= commands[1]&&i>0)
                        {
                            numbers.RemoveAt(i - 1);
                        }
                        else if (i + 1 < commands[1] && i != 0&&i>=0)
                        {
                            numbers.RemoveAt(i - 1);
                        }                        
                        i--;// moves Bomb number's index to the left
                        if (numbers.Count == 1)
                        {
                            break;
                        }
                    }
                    i = numbers.IndexOf(commands[0]);//finds the Bomb number and removes it.
                    numbers.RemoveAt(i);                    
                }
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}   

