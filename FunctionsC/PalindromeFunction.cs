namespace IntermediateExercises.FunctionsC
{
    public class PalindromeFunction
    {
        public static void Palindrome()
        {
            Console.WriteLine("Input a string and it will check if it is a palindrome");

            string text = Console.ReadLine()!;
            string reverse = string.Empty;

            Console.WriteLine(IsPalindrome(text));

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
