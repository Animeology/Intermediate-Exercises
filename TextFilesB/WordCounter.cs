namespace IntermediateExercises.TextFilesB
{
    using Base;

    public class WordCounter
    {
        public static void CountWordsInFile()
        {
            Printing.PrintLine("Tt will count the number of words in the input.txt file");
            string file = "input.txt";
            int count = 0;

            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                do
                {
                    line = sr.ReadLine()!;

                    if (line != null)
                    {
                        count += line.Split(' ').Length;
                    }
                } while (line != null);
            }

            Console.WriteLine(count);
        }
    }
}
