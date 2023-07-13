namespace IntermediateExercises.GeometryB
{
    public class ParallelogramShape
    {
        public static void Parallelogram()
        {
            Console.WriteLine("Input the width, height, and symbol to display a parallelogram");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            char symbol = Convert.ToChar(Console.ReadLine()!);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();

                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
