namespace IntermediateExercises.FunctionsA
{
    using Base;

    public class CalculateUsingReference
    {
        public static void CalculateRefDouble()
        {
            Printing.PrintLine("Input a number and it will print the number doubled");

            int num = InputChecker.InputInt();

            Printing.PrintIntLine(Double(ref num));

            int Double(ref int num)
            {
                int result = num * 2;

                return result;
            }

        }
    }
}
