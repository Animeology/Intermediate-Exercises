namespace IntermediateExercises.Arithmetic
{
    using Base;

    public class FunctionCalculator
    {
        public static void CalculateFunction()
        {
            Printing.PrintLine("Input two numbers for a range to calculate the following: y = x^2 - 2x + 1");

            int x = InputChecker.InputInt();
            int y = InputChecker.InputInt();

            for (int i = x; i <= y; i++)
            {
                double function = Math.Pow(i, 2) - 2 * i + 1;

                Printing.Print($"{function} ");
            }
        }
    }
}
