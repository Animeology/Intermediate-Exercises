namespace IntermediateExercises.Recursion
{
    using Base;

    public class Power
    {
        public static void PowerRecursion()
        {
            Printing.PrintLine("Input two numbers and it will do the power of the number using recursion");

            int num = InputChecker.InputInt();
            int power = InputChecker.InputInt();

            Printing.PrintIntLine(Power(num, power));

            int Power(int num, int power)
            {
                if (power == 0)
                {
                    return 1;
                }
                else
                {
                    return num * Power(num, power - 1);
                }
            }
        }
    }
}
