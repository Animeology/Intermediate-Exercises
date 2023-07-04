namespace Intermediate_Exercises
{
    public class TextFilesA
    {
        public void SearchLinesInFile()
        {
            Console.WriteLine("Search for the word in the file and it will print out the line that the word is in");
            string file = "input.txt";
            string[] lines = File.ReadAllLines(file);

            bool exit = false;
            do
            {
                string text = Console.ReadLine()!;

                if (text != string.Empty)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains(text))
                        {
                            Console.WriteLine(lines[i]);
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
