namespace IntermediateExercises.FunctionsA
{
    public class CalculateUsingReference
    {
        public static void CalculateRefDouble()
        {
            Console.WriteLine("Input a number and it will print the number doubled");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Double(ref num));

            int Double(ref int num)
            {
                int result = num * 2;

                return result;
            }

        }
    }
}
