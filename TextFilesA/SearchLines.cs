namespace IntermediateExercises.TextFilesA
{
    using Base;

    public class SearchLines
    {
        public static void SearchLinesInFile()
        {
            Printing.PrintLine("Search for the word in the file and it will print out the line that the word is in");
            string file = "input.txt";
            string[] lines = File.ReadAllLines(file);

            bool exit = false;
            do
            {
                string text = InputChecker.InputStringOnlyLetters();

                if (text != string.Empty)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains(text))
                        {
                            Printing.PrintLine(lines[i]);
                        }
                    }
                }
                else
                {
                    exit = true;
                }
            } while (!exit);
        }
    }
}
