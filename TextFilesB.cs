namespace Intermediate_Exercises
{
    public class TextFilesB
    {
        public void ReverseFile()
        {
            Console.WriteLine("Creates a new file that reverse every word in the input.txt file");
            string file = "input.txt";
            string newFile = "input.inv";

            using (StreamReader sr = new StreamReader(file))
            {
                using (StreamWriter sw = new StreamWriter(newFile))
                {
                    string[] lines = File.ReadAllLines(file);

                    for (int i = lines.Length - 1; i >= 0; i--)
                    {
                        sw.WriteLine(lines[i]);
                    }
                }
            }
        }

        public void ChangeLowerToUpperFile()
        {
            Console.WriteLine("Creates a new file that uppercase every word in the input.txt file");
            string file = "input.txt";
            string newFile = "output.txt";

            using (StreamReader sr = new StreamReader(file))
            {
                using (StreamWriter sw = new StreamWriter(newFile))
                {
                    string line;
                    while ((line = sr.ReadLine()!) != null)
                    {
                        string upperLines = line.ToUpper();

                        sw.WriteLine(upperLines);
                    }
                }
            }
        }

        public void CountWordsInFile()
        {
            Console.WriteLine("Tt will count the number of words in the input.txt file");
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
