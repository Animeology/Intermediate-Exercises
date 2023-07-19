namespace IntermediateExercises.Recursion
{
    using Base;

    public class Fibonacci
    {
        public static void FibonacciRecursion()
        {
            Printing.PrintLine("A Fibonacci that starts with the user input");
            int num = InputChecker.InputInt();

            Printing.PrintIntLine(Fibonacci(num));

            int Fibonacci(int num)
            {
                if (num == 1 || num == 2)
                {
                    return 1;
                }
                else
                {
                    return Fibonacci(num - 1) + Fibonacci(num - 2);
                }
            }
        }
    }
}
