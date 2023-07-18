namespace IntermediateExercises.FunctionsC
{
    using Base;

    public class AlphabetChecker
    {
        public static void CheckAlphabet()
        {
            Printing.PrintLine("Input a string to check if the whole string is only alphabetic");

            string text = InputChecker.InputStringOnlyLetters();

            Printing.PrintBool(IsAlphabetic(text));

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
