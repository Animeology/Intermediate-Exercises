namespace IntermediateExercises.FunctionsC
{
    public class MainFunctionCalculatorWithReturn
    {
        public static int MainParameterCalculatorReturn(string[] args)
        {
            Console.WriteLine("Input an equation and it will calculate");
            Console.WriteLine("Accepts only \"+\", \"-\", \"*\" \"x\" \"X\", \"/\" ");

            int x = Convert.ToInt32(args[0]);
            char op = Convert.ToChar(args[1]);
            int y = Convert.ToInt32(args[2]);

            if (args.Length != 0)
            {
                return 1;
            }

            if (args[1] != "+" || args[1] != "-" || args[1] != "*" || args[1] != "/")
            {
                return 2;
            }

            try
            {
                Convert.ToInt32(x);
                Convert.ToInt32(y);
            }
            catch
            {
                return 3;
            }

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

            return 0;
        }
    }
}
