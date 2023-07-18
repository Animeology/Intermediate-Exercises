namespace IntermediateExercises.FunctionsA
{
    using Base;

    public class CalculateDouble
    {
        public static void CalculateDoubles()
        {
            Printing.PrintLine("Input a number and it will print the number doubled");

            int num = InputChecker.InputInt();

            Printing.PrintIntLine(Double(num));

            int Double(int num)
            {
                int result = num * 2;

                return result;
            }
        }
    }
}
