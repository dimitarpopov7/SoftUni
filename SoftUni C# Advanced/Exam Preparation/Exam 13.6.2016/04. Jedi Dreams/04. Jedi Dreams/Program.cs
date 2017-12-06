namespace _04.Jedi_Dreams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            var code = string.Empty;
            for (int i = 0; i < n; i++)
            {
                sb.Append(Console.ReadLine());
            }
            code = sb.ToString();
            var methodPattern = @"static\s+.+?\s+([A-Za-z]*[A-Z]{1}[A-Za-z]*)";
            var staticMethods = new Regex(methodPattern);
            var methodsMatches = staticMethods.Matches(code);
            var result = new List<Method>();
            foreach (Match meth in methodsMatches)
            {
                var currentMethod = new Method() { Name = meth.Groups[1].ToString() };
                result.Add(currentMethod);
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (i != result.Count - 1)
                {
                    var extractInvokedPattern = @"([a-zA-Z]*[A-Z][a-zA-Z]*)\s*\(";
                    var regex = new Regex(extractInvokedPattern);
                    //get the text between the Methods
                    var currentInBetweenPart = string.Empty;
                    var inBetweenPattern = $@"{result[i].Name}(.*){result[i+1].Name}";
                    var regexExtractor = new Regex(inBetweenPattern);
                    var inBetweenMatch = regexExtractor.Matches(code);
                    foreach (Match subCode in inBetweenMatch)
                    {
                        currentInBetweenPart = subCode.Groups[1].Value;
                    }
                    // record the invoked methods
                    var invokedList = new List<string>();
                    var invokedMethodsMatches = regex.Matches(currentInBetweenPart);
                    foreach (Match invokedMethod in invokedMethodsMatches)
                    {                        
                        invokedList.Add(invokedMethod.Groups[1].Value);                       
                    }
                    // add it to the top method
                    result[i].InvokedMethods = invokedList;
                }
                else
                {
                    var lastPortionCod = code.Substring(code.IndexOf(result[i].Name));
                    var extractInvokedPattern = @"([a-zA-Z]*[A-Z][a-zA-Z]*)\s*\(";
                    var regex = new Regex(extractInvokedPattern);
                    var invokedList = new List<string>();
                    var invokedMethodsMatches = regex.Matches(lastPortionCod);
                    foreach (Match invokedMethod in invokedMethodsMatches)
                    {                                                 
                       invokedList.Add(invokedMethod.Groups[1].Value);                        
                    }
                    invokedList.RemoveAt(0);
                    result[i].InvokedMethods = invokedList;
                }
            }
            foreach (var item in result.OrderByDescending(x=>x.InvokedMethods.Count).ThenBy(x=>x.Name))
            {
                if (item.InvokedMethods.Count > 0)
                {
                    Console.WriteLine($"{item.Name} -> {item.InvokedMethods.Count} -> {string.Join(", ", item.InvokedMethods.OrderBy(x => x))}");
                }
                else
                { 
                    Console.WriteLine($"{item.Name} -> \"None\"");
                }
            }                
        }
    }
}