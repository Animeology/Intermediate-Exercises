namespace IntermediateExercises.DataTypesB
{
    using Base;

    public class PrimeFactor
    {
        public static void PrimeFactors()
        {
            Printing.PrintLine("Input a integer and it will display the product of its prime factor");

            int num = InputChecker.InputInt();
            int divisor = 2;

            while (num > 1)
            {
                while (num % divisor == 0)
                {
                    Printing.Print(divisor + "x");
                    num = num / divisor;
                }
                divisor++;
            }
            Printing.PrintIntLine(1);
        }
    }
}
