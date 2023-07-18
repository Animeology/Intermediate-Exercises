namespace IntermediateExercises.FunctionsB
{
    using Base;

    public class PowerOperation
    {
        public static void PowerOp()
        {
            Printing.PrintLine("Input 2 numbers and the it will calculate the first number of the power of the second number");

            double num = InputChecker.InputDouble();
            double power = InputChecker.InputDouble();

            Printing.PrintDoubleLine(Power(num, power));

            double Power(double num, double power)
            {
                double result = Math.Pow(num, power);

                return result;
            }
        }
    }
}
