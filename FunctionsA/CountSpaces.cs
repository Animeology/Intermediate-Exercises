namespace IntermediateExercises.FunctionsA
{
    public class CountSpaces
    {
        public static void SpaceFunction()
        {
            Console.WriteLine("Input a sentence and it will count the total spaces in the sentence");

            string text = Console.ReadLine()!;

            Console.WriteLine(CountSpaces(text));

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
