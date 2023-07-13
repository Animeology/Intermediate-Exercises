namespace IntermediateExercises.BinaryFiles
{
    public class BMPImageFile
    {
        public static void BMPImage()
        {
            string fileName = "logo.bmp";
            int size = 54;
            int width, height;
            byte[] data = new byte[size];

            using (FileStream file = File.OpenRead(fileName))
            {
                file.Read(data, 0, size);
            }

            width = data[18]
                    + data[19] * 256
                    + data[20] * 256 * 256
                    + data[21] * 256 * 256 * 256;

            height = data[22]
                    + data[23] * 256
                    + data[24] * 256 * 256
                    + data[25] * 256 * 256 * 256;


            Console.WriteLine("{0}x{1}", width, height);
        }
    }
}
