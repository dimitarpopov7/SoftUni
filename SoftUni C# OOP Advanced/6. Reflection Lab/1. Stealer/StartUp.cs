namespace _1.Stealer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Spy spy = new Spy();

            string result = spy.StealFieldInfo("Hacker", "username", "password");
            Console.WriteLine(result);
            Console.WriteLine();

            string result2 = spy.AnalyzeAccessModifiers("Hacker");
            Console.WriteLine(result2);
            Console.WriteLine();

            string result3 = spy.RevealPrivateMethods("Hacker");
            Console.WriteLine(result3);
            Console.WriteLine();

            string result4 = spy.CollectGettersAndSetter("Hacker");
            Console.WriteLine(result4);
        }
    }
}