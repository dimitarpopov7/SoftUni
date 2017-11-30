namespace _12.Inferno_III
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commands = RecordCommands();
            if (commands.Count == 0)
            {
                Console.WriteLine(string.Join(" ",numbers));
                return;
            }
            numbers = ApplyFilters(commands, numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> ApplyFilters(HashSet<Filter> commands, List<int> numbers)
        {
            var newNumbers = new List<int>();
            foreach (var command in commands)
            {
                //safe indexes to remove for each command
                var indexesToRemove = new List<int>();
                if (command.Command.EndsWith("Left"))
                {
                    int neededSum = command.Sum;
                    if (numbers[0] == command.Sum)
                    {
                        indexesToRemove.Add(0);
                    }
                    for (int i = 1; i < numbers.Count - 1; i++)
                    {
                        int sum = 0;
                        sum = numbers[i] + numbers[i - 1];
                        if (sum == command.Sum)
                        {
                            indexesToRemove.Add(i);
                        }
                    }
                    numbers = RemoveIndex(indexesToRemove, numbers);
                    newNumbers = new List<int>(numbers);
                }
                else if (command.Command.EndsWith("m Right"))
                {
                    int neededSum = command.Sum;
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        int sum = 0;
                        sum = numbers[i] + numbers[i + 1];
                        if (sum == command.Sum)
                        {
                            indexesToRemove.Add(i);
                        }
                    }
                    if (numbers[numbers.Count - 1] == command.Sum)
                    {
                        indexesToRemove.Add(numbers.Count - 1);
                    }
                    numbers = RemoveIndex(indexesToRemove, numbers);
                    newNumbers = new List<int>(numbers);
                }
                else if (command.Command.EndsWith("Left Right"))
                {
                    int neededSum = command.Sum;
                    for (int i = 0; i < numbers.Count-3; i++)
                    {
                        int sum = 0;
                        sum = numbers[i] + numbers[i + 1] + numbers[i + 2];
                        if (sum == neededSum)
                        {
                            indexesToRemove.Add(i + 1);
                        }
                    }
                    if (numbers[numbers.Count - 1] + numbers[numbers.Count - 2] == neededSum)
                    {
                        indexesToRemove.Add(numbers.Count - 2);
                    }
                    numbers = RemoveIndex(indexesToRemove, numbers);
                    newNumbers = new List<int>(numbers);
                }
            }
            return newNumbers;
        }
        private static List<int> RemoveIndex(List<int> indexesToRemove, List<int> numbers)
        {
            foreach (var index in indexesToRemove)
            {
                numbers.RemoveAt(index);
            }
            return numbers;
        }
        private static HashSet<Filter> RecordCommands()
        {
            var commands = new HashSet<Filter>();
            var input = Console.ReadLine()
                        .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
            while (input[0] != "Forge")
            {
                var currentCommand = new Filter() { Command = input[1], Sum = int.Parse(input[2]) };
                if (input[0].StartsWith("Exclude"))
                {
                    commands.Add(currentCommand);
                }
                else if (input[0].StartsWith("Reverse"))
                {
                    commands.RemoveWhere(x =>
                    x.Command == currentCommand.Command &&
                    x.Sum == currentCommand.Sum);
                }
                input = Console.ReadLine()
                        .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
            }
            return commands;
        }
    }
}
