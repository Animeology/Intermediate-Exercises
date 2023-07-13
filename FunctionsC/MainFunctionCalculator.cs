namespace IntermediateExercises.FunctionsC
{
    public class MainFunctionCalculator
    {
        public static void MainParameterCalculator(string[] args)
        {
            Console.WriteLine("Input an equation and it will calculate");
            Console.WriteLine("Accepts only \"+\", \"-\", \"*\" \"x\" \"X\", \"/\" ");

            int x = Convert.ToInt32(args[0]);
            char op = Convert.ToChar(args[1]);
            int y = Convert.ToInt32(args[2]);

            switch (op)
            {
                case '+':
                    Console.Write(x + y);
                    break;
                case '-':
                    Console.Write(x - y);
                    break;
                case '*':
                case 'x':
                case 'X':
                    Console.Write(x * y);
                    break;
                case '/':
                    Console.Write(x / y);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}
