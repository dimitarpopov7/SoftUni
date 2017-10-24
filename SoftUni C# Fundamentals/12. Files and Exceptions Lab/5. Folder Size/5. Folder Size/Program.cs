namespace _5.Folder_Size
{
    using System;
    using System.Linq;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            var files = Directory
                .GetFiles("FindMySize")
                .Select(f => new FileInfo(f))//for each file create FileInfo
                .Sum(f => f.Length);//for each file sum the lenght
            Console.WriteLine(files/1024/1024);
        }
    }
}
