namespace _3.Dependency_Inversion.Controllers
{
    using System;
    using Models;
    public class Engine
    {
        public void Run()
        {
            var calc = new PrimitiveCalculator();
            var command = Console.ReadLine().Split();
            while (command[0]!="End")
            {
                if (command[0] == "mode")
                {
                    var strategy = char.Parse(command[1]);
                    calc.changeStrategy(strategy);
                }
                else
                {
                    PerformCalc(calc,command);
                }
                command = Console.ReadLine().Split();
            }
        }
        private static void PerformCalc(PrimitiveCalculator calc,string[] command)
        {
            int firstOperand = int.Parse(command[0]);
            int secondOperand = int.Parse(command[1]);
            Console.WriteLine(calc.performCalculation(firstOperand, secondOperand));
        }
    }
}