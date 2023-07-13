namespace IntermediateExercises.GeometryB
{
    public class PyramidShape
    {
        public static void Pyramid()
        {
            Console.WriteLine("Input a string and it will make a triangle");

            string word = Console.ReadLine()!;
            int position = word.Length / 2;
            int height = word.Length / 2 + 1;
            int amount = 1;

            Console.WriteLine();

            if (word.Length % 2 == 0)
            {
                word += " ";
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < position; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(word.Substring(position, amount));
                position--;
                amount += 2;
            }
        }
    }
}
