namespace IntermediateExercises.GeometryA
{
    public class RightTriangle
    {
        public static void RightAlignTriangle()
        {
            Console.WriteLine("Input a string and it will make a right-aligned triangle");

            string input = Console.ReadLine()!;
            int height = input.Length - 1;
            int width = 1;

            Console.WriteLine();
            for (int i = height; i >= 0; i--)
            {
                Console.WriteLine(input.Substring(i, width));
                width++;
            }
        }
    }
}
