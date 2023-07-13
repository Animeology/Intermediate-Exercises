namespace IntermediateExercises.FunctionsA
{
    public class CalculateDouble
    {
        public static void CalculateDoubles()
        {
            Console.WriteLine("Input a number and it will print the number doubled");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Double(num));

            int Double(int num)
            {
                int result = num * 2;

                return result;
            }
        }
    }
}
