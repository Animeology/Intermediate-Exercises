namespace IntermediateExercises.Recursion
{
    using Base;

    public class Multiply
    {
        public void MultiplyRecursion()
        {
            Printing.PrintLine("Input 2 numbers and it will multiply it by recursion");

            int x = InputChecker.InputInt();
            int y = InputChecker.InputInt();

            Printing.PrintIntLine(Multiply(x, y));

            int Multiply(int x, int y)
            {
                if (y == 0)
                {
                    return 0;
                }
                else
                {
                    return x + Multiply(x, y - 1);
                }
            }
        }
    }
}
