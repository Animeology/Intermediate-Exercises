namespace IntermediateExercises.FunctionsC
{
    using Base;

    public class MainFunctionCalculator
    {
        public static void MainParameterCalculator(string[] args)
        {
            Printing.PrintLine("Input an equation and it will calculate");
            Printing.PrintLine("Accepts only \"+\", \"-\", \"*\" \"x\" \"X\", \"/\" ");

            int x = Convert.ToInt32(args[0]);
            char op = Convert.ToChar(args[1]);
            int y = Convert.ToInt32(args[2]);

            switch (op)
            {
                case '+':
                    int sum = x + y;
                    Printing.PrintInt(sum);
                    break;
                case '-':
                    int diff = x - y;
                    Printing.PrintInt(diff);
                    break;
                case '*':
                case 'x':
                case 'X':
                    int product = x * y;
                    Printing.PrintInt(product);
                    break;
                case '/':
                    int divide = x / y;
                    Printing.PrintInt(divide);
                    break;
                default:
                    Printing.PrintLine("Invalid operation");
                    break;
            }
        }
    }
}
