namespace IntermediateExercises.FunctionsB
{
    public class PowerOperation
    {
        public static void PowerOp()
        {
            Console.WriteLine("Input 2 numbers and the it will calculate the first number of the power of the second number");

            double num = Convert.ToInt32(Console.ReadLine());
            double power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Power(num, power));

            double Power(double num, double power)
            {
                double result = Math.Pow(num, power);

                return result;
            }
        }
    }
}
