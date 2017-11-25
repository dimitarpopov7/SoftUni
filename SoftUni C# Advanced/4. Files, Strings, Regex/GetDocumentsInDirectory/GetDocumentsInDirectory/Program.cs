namespace GetDocumentsInDirectory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            TraverseDirectories("DimitarPopov");
        }

        private static void TraverseDirectories(string directory)
        {
            Console.WriteLine($"--{directory}--");
            var allFiles = Directory.GetFiles($"{directory}");
            foreach (var file in allFiles)
            {
                Console.WriteLine(file);
            }
            var allDir = Directory.GetDirectories(directory);
            foreach (var dir in allDir)
            {
                TraverseDirectories(dir);
            }
        }
    }
    
}
