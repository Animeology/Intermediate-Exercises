namespace IntermediateExercises.BinaryFiles
{
    public class ReadBMPFile
    {
        public static void ReadBMP()
        {
            string fileName = "logo.bmp";

            using (FileStream file = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite))
            {
                char b1 = (char)file.ReadByte();
                char b2 = (char)file.ReadByte();

                file.Seek(0, SeekOrigin.Begin);
                file.WriteByte(Convert.ToByte('B'));
                file.WriteByte(Convert.ToByte('M'));
            }
        }
    }
}
