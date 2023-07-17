using System.Text;

namespace IntermediateExercises.BinaryFiles
{
    using Base;

    public class ReadIDEFile
    {
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
                Printing.PrintLine(ToString());
            }
        }
    }
}
