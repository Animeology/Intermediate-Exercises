using System.Text;

namespace Intermediate_Exercises
{
    public class BinaryFiles
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
                    + (data[19] * 256)
                    + (data[20] * 256 * 256)
                    + (data[21] * 256 * 256 * 256);

            height = data[22]
                    + (data[23] * 256)
                    + (data[24] * 256 * 256)
                    + (data[25] * 256 * 256 * 256);


            Console.WriteLine("{0}x{1}", width, height);
        }

        public static void ReadID3()
        {
            byte idTagLength = 3;
            byte titleLength = 30;
            byte artistLength = 30;
            byte albumLength = 30;
            byte yearLength = 4;
            byte commentLength = 30;
            byte genreLength = 1;

            byte[] id = new byte[idTagLength];
            byte[] title = new byte[titleLength];
            byte[] artist = new byte[artistLength];
            byte[] album = new byte[albumLength];
            byte[] year = new byte[yearLength];
            byte[] comment = new byte[commentLength];
            byte[] genre = new byte[genreLength];

            string ToString()
            {
                StringBuilder tag = new StringBuilder();

                tag.AppendLine(Encoding.Default.GetString(id));
                tag.AppendLine(Encoding.Default.GetString(title));
                tag.AppendLine(Encoding.Default.GetString(artist));
                tag.AppendLine(Encoding.Default.GetString(album));
                tag.AppendLine(Encoding.Default.GetString(year));
                tag.AppendLine(Encoding.Default.GetString(comment));
                tag.AppendLine(Encoding.Default.GetString(genre));

                return tag.ToString();
            }


            string fileName = "input.mp3";
            using (FileStream file = File.OpenRead(fileName))
            {
                file.Seek(-128, SeekOrigin.End);

                file.Read(id, 0, id.Length);
                file.Read(title, 0, title.Length);
                file.Read(artist, 0, artist.Length);
                file.Read(album, 0, album.Length);
                file.Read(year, 0, year.Length);
                file.Read(comment, 0, comment.Length);
                file.Read(genre, 0, genre.Length);
            }

            if (Encoding.Default.GetString(id).Equals("TAG"))
            {
                Console.WriteLine(ToString());
            }
        }
    }
}
