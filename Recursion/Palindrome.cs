namespace IntermediateExercises.Recursion
{
    using Base;

    public class Palindrome
    {
        public void PalindromeRecursion()
        {
            Printing.PrintLine("Input a string and it will check if it is a palindrome by recursion");
            string text = InputChecker.InputStringOnlyLetters();

            Printing.PrintBool(Palindrome(text));

            bool Palindrome(string text)
            {
                if (text.Length <= 1)
                {
                    return true;
                }
                else
                {
                    if (text[0] != text[text.Length - 1])
                    {
                        return false;
                    }
                    else
                    {
                        return Palindrome(text.Substring(1, text.Length - 2));
                    }
                }
            }
        }
    }
}
