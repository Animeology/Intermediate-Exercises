namespace IntermediateExercises.FunctionsA
{
    using Base;

    public class CountSpaces
    {
        public static void SpaceFunction()
        {
            Printing.PrintLine("Input a sentence and it will count the total spaces in the sentence");

            string text = InputChecker.InputStringOnlyWords();

            Printing.PrintIntLine(CountSpaces(text));

            int CountSpaces(string text)
            {
                int count = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ' ')
                    {
                        count++;
                    }
                }

                return count;
            }
        }
    }
}
