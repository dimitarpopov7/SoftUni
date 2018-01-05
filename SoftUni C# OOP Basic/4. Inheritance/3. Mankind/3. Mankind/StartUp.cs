namespace _3.Mankind
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var studentInfo = Console.ReadLine().Split().ToList();
                var workerInfo = Console.ReadLine().Split().ToList();
                var st = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                var wr = new Worker(workerInfo[0], workerInfo[1], double.Parse(workerInfo[2]), double.Parse(workerInfo[3]));
                Console.WriteLine(st);
                Console.WriteLine(wr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
} 