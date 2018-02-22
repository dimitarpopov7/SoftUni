namespace _2.King_s_Gambit
{
    using IO;
    using Controllers;

    public class StartUp
    {
        public static void Main()
        {
            new Engine(new ConsoleReader(),new ConsoleWriter()).Run();
        }
    }
}
