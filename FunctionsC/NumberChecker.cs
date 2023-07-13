namespace IntermediateExercises.FunctionsC
{
    public class NumberChecker
    {
        public static void CheckNumber()
        {
            Console.WriteLine("Input a string to check if the whole string is only alphabetic");

            string text = Console.ReadLine()!;

            Console.WriteLine(IsNumber(text));

            bool IsNumber(string text)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] < '1' || text[i] > '9')
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
