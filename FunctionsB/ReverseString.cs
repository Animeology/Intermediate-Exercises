namespace IntermediateExercises.FunctionsB
{
    using Base;

    public class ReverseString
    {
        public static void StringReverse()
        {
            Printing.PrintLine("Input a text and it will be reverse");

            string text = InputChecker.InputStringOnlyLetters();

            InvertString(text);

            void InvertString(string text)
            {
                char[] arr = text.ToCharArray();
                Array.Reverse(arr);
                Printing.PrintCharArray(arr);
            }
        }
    }
}
