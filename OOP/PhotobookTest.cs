namespace IntermediateExercises.OOP
{
    using Structures;

    public class PhotobookTest
    {
        public static void PhotoBookTest()
        {
            PhotoBook album1 = new PhotoBook();
            Console.WriteLine(album1.GetNumberPages());

            PhotoBook album2 = new PhotoBook(24);
            Console.WriteLine(album2.GetNumberPages());

            BigPhotoBook album3 = new BigPhotoBook();
            Console.WriteLine(album3.GetNumberPages());
        }
    }
}
