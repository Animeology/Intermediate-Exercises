namespace IntermediateExercises.DataTypesB
{
    public class PrimeFactor
    {
        public static void PrimeFactors()
        {
            Console.WriteLine("Input a integer and it will display the product of its prime factor");

            int num = Convert.ToInt32(Console.ReadLine());
            int divisor = 2;

            while (num > 1)
            {
                while (num % divisor == 0)
                {
                    Console.Write(divisor + "x");
                    num = num / divisor;
                }
                divisor++;
            }
            Console.WriteLine(1);
        }
    }
}
