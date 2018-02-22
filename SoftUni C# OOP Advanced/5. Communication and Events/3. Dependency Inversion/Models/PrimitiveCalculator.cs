namespace _3.Dependency_Inversion.Models
{
    using Skeleton;

    public class PrimitiveCalculator
    {
        private bool isAddition;
        private bool isSubtraction;
        private bool isDivision;
        private bool isMultiplication;
        private AdditionStrategy additionStrategy;
        private SubtractionStrategy subtractionStrategy;
        private MultiplicationStrategy multiplicationStrategy;
        private DivisionStrategy divisionStrategy;

        public PrimitiveCalculator()
        {
            this.additionStrategy = new AdditionStrategy();
            this.subtractionStrategy = new SubtractionStrategy();
            this.divisionStrategy = new DivisionStrategy();
            this.multiplicationStrategy = new MultiplicationStrategy();
            this.isAddition = true;
        }

        public void changeStrategy(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    this.isAddition = true;
                    this.isSubtraction = false;
                    this.isDivision = false;
                    this.isMultiplication = false;
                    break;
                case '-':
                    this.isAddition = false;
                    this.isSubtraction = true;
                    this.isDivision = false;
                    this.isMultiplication = false;
                    break;
                case '*':
                    this.isAddition = false;
                    this.isSubtraction = false;
                    this.isDivision = false;
                    this.isMultiplication = true;
                    break;
                case '/':
                    this.isAddition = false;
                    this.isSubtraction = false;
                    this.isDivision = true;
                    this.isMultiplication = false;
                    break;
            }
        }

        public int performCalculation(int firstOperand, int secondOperand)
        {
            if (this.isAddition)
            {
                return additionStrategy.Calculate(firstOperand, secondOperand);
            }
            else if(this.isSubtraction)
            {
                return subtractionStrategy.Calculate(firstOperand, secondOperand);
            }
            else if (this.isMultiplication)
            {
                return multiplicationStrategy.Calculate(firstOperand, secondOperand);
            }
            else
            {
                return divisionStrategy.Calculate(firstOperand, secondOperand);
            }
        }
    }
}