namespace IntermediateExercises.TextFilesB
{
    using Base;

    public class LowerToUpperFile
    {
        public static void ChangeLowerToUpperFile()
        {
            Printing.PrintLine("Creates a new file that uppercase every word in the input.txt file");
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
    }
}
