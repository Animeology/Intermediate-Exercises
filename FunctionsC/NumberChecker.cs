namespace IntermediateExercises.FunctionsC
{
    using Base;

    public class NumberChecker
    {
        public static void CheckNumber()
        {
            Printing.PrintLine("Input a string to check if the whole string is only alphabetic");

            string text = InputChecker.InputStringOnlyLetters();

            Printing.PrintBool(IsNumber(text));

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
