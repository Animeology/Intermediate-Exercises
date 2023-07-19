namespace IntermediateExercises.Recursion
{
    using Base;

    public class Factorial
    {
        public static void FactorialRecursion()
        {
            Printing.PrintLine("A Factorial that starts with the user input");
            int num = InputChecker.InputInt();

            Printing.PrintIntLine(Factorial(num));

            int Factorial(int num)
            {
                if (num == 0)
                {
                    return 1;
                }
                else
                {
                    return num * Factorial(num - 1);
                }
            }
        }
    }
}
