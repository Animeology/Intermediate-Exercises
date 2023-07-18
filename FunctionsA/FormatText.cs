namespace IntermediateExercises.FunctionsA
{
    using Base;

    public class FormatText
    {
        public static void Formatting()
        {
            Printing.PrintLine("Input a word and it will in the center and underlined");

            string text = InputChecker.InputString();

            WriteCenteredUnderline(text);

            void WriteCenteredUnderline(string text)
            {
                double x = 35;
                double y = 5;

                Console.SetCursorPosition((int)x, (int)y);
                Printing.Print(text);

                Printing.NewLine();

                for (int i = 0; i < text.Length; i++)
                {
                    Console.SetCursorPosition((int)x + i, (int)y + 1);
                    Printing.PrintChar('-');
                }
                Printing.NewLine();
            }
        }
    }
}
