namespace IntermediateExercises.FunctionsA
{
    public class FormatText
    {
        public static void Formatting()
        {
            Console.WriteLine("Input a word and it will in the center and underlined");

            string text = Console.ReadLine()!;

            WriteCenteredUnderline(text);

            void WriteCenteredUnderline(string text)
            {
                double x = 35;
                double y = 5;

                Console.SetCursorPosition((int)x, (int)y);
                Console.Write(text);

                Console.WriteLine();

                for (int i = 0; i < text.Length; i++)
                {
                    Console.SetCursorPosition((int)x + i, (int)y + 1);
                    Console.Write('-');
                }
                Console.WriteLine();
            }
        }
    }
}
