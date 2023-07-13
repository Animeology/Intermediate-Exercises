namespace IntermediateExercises.FunctionsC
{
    public class AlphabetChecker
    {
        public static void CheckAlphabet()
        {
            Console.WriteLine("Input a string to check if the whole string is only alphabetic");

            string text = Console.ReadLine()!;

            Console.WriteLine(IsAlphabetic(text));

            bool IsAlphabetic(string text)
            {
                text = text.ToUpper();

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] < 'A' || text[i] > 'Z')
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
