namespace IntermediateExercises.FunctionsB
{
    using Base;

    public class TitleFormat
    {
        public static void Title()
        {
            Printing.PrintLine("Input a string and it will print it like a title");

            string text = InputChecker.InputStringOnlyLetters();

            WriteTitle(text);

            void WriteTitle(string text)
            {
                text = text.ToUpper();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Printing.PrintChar('-');
                }
                Printing.NewLine();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Printing.PrintChar(' ');
                }
                Printing.NewLine();

                for (int i = 0; i < text.Length; i++)
                {
                    Printing.Print($"{text[i]} ");
                }
                Printing.NewLine();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Printing.PrintChar(' ');
                }
                Printing.NewLine();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Printing.PrintChar('-');
                }
                Printing.NewLine();
            }
        }
    }
}
