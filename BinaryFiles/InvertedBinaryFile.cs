namespace IntermediateExercises.BinaryFiles
{
    public class InvertedBinaryFile
    {
        public static void InvertedFile()
        {
            string inputFileName = "app.exe";
            string outputFileName = "app.inv";

            using (FileStream file = File.OpenRead(inputFileName))
            {
                long size = file.Length;
                byte[] data = new byte[size];

                file.Read(data, 0, (int)size);

                using (FileStream outFile = File.OpenWrite(outputFileName))
                {
                    for (long i = 0; i < size; i++)
                    {
                        outFile.WriteByte(data[i]);
                    }
                }
            }
        }
    }
}
