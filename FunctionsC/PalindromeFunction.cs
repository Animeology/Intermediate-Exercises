namespace IntermediateExercises.FunctionsC
{
    using Base;

    public class PalindromeFunction
    {
        public static void Palindrome()
        {
            Printing.PrintLine("Input a string and it will check if it is a palindrome");

            string text = InputChecker.InputStringOnlyLetters();
            string reverse = string.Empty;

            Printing.PrintBool(IsPalindrome(text));

            bool IsPalindrome(string text)
            {
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reverse += text[i];
                }
                if (text == reverse)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
