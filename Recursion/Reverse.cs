namespace IntermediateExercises.Recursion
{
    using Base;

    public class Reverse
    {
        public static void ReverseRecursion()
        {
            Printing.PrintLine("Input a string and it will be reverse by recursion");
            string text = InputChecker.InputStringOnlyLetters();

            Printing.PrintLine(Reverse(text));

            string Reverse(string text)
            {
                if (text.Length <= 1)
                {
                    return text;
                }
                else
                {
                    char firstLetter = text[0];
                    string restOfWord = text.Substring(1);
                    return Reverse(restOfWord) + firstLetter;
                }
            }
        }
    }
}
