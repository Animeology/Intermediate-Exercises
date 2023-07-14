namespace IntermediateExercises.FunctionsB
{
    public class TitleFormat
    {
        public static void Title()
        {
            Console.WriteLine("Input a string and it will print it like a title");

            string text = Console.ReadLine()!;

            WriteTitle(text);

            void WriteTitle(string text)
            {
                text = text.ToUpper();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Console.Write('-');
                }
                PrintNewLine();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Console.Write(' ');
                }
                PrintNewLine();

                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text[i] + " ");
                }
                PrintNewLine();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Console.Write(' ');
                }
                PrintNewLine();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Console.Write('-');
                }
                PrintNewLine();
            }
        }

        static void PrintNewLine()
        {
            Console.WriteLine();
        }
    }
}
