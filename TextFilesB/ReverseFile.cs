namespace IntermediateExercises.TextFilesB
{
    using Base;

    public class ReverseFile
    {
        public static void ReverseInFile()
        {
            Printing.PrintLine("Creates a new file that reverse every word in the input.txt file");
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
    }
}
