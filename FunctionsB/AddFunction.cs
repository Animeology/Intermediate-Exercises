namespace IntermediateExercises.FunctionsB
{
    public class AddFunction
    {
        public static void Add()
        {
            Console.WriteLine("Input a number and it will add to the current sum");

            string text = Console.ReadLine()!;

            Console.WriteLine(AddDigits(text));

            int AddDigits(string text)
            {
                int sum = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    sum += Convert.ToInt32(text.Substring(i, 1));
                }

                return sum;
            }
        }
    }
}
