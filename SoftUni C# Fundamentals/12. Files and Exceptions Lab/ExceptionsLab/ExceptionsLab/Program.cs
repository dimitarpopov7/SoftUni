namespace ExceptionsLab
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            string name = "pesho";
            int age = 7;
            
            try
            {                 
                int sum = age + int.Parse(name);
            }
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("index out of range");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception type)
            //{
            //    Console.WriteLine("Sorry soemthing went wrong:");
            //    Console.WriteLine(type.Message);
            //    Console.WriteLine(type.StackTrace);
            //}
            

            //Save exceptions in a log so that the user does not see them
            catch (Exception ex)
            {
                string exceptionLog = "./ErrorLog.txt";
                File.AppendAllText(exceptionLog, ex.Message);
                File.AppendAllText(exceptionLog, Environment.NewLine);
                File.AppendAllText(exceptionLog, ex.StackTrace);
                File.AppendAllText(exceptionLog, Environment.NewLine);
                File.AppendAllText(exceptionLog, Convert.ToString(DateTime.Now));
                File.AppendAllText(exceptionLog, Environment.NewLine);
                File.AppendAllText(exceptionLog, new string('-', 20));
            }
            finally
            {
                Console.WriteLine("Final");
            }            
        }
    }
}
