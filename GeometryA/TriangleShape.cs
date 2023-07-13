namespace IntermediateExercises.GeometryA
{
    public class TriangleShape
    {
        public static void Triangle()
        {
            Console.WriteLine("Input the symbol and a width to print a triangle");

            char symbol = Convert.ToChar(Console.ReadLine()!);
            int width = Convert.ToInt32(Console.ReadLine()!);
            int height = width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
                width--;
            }
        }
    }
}
