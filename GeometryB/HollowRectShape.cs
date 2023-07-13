namespace IntermediateExercises.GeometryB
{
    public class HollowRectShape
    {
        public static void HollowRectangle()
        {
            Console.WriteLine("Input a symbol and the width/height to display a hollow rectangle");

            char symbol = Convert.ToChar(Console.ReadLine()!);
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < width; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                Console.Write(symbol);

                for (int j = 0; j < width - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(symbol);
            }

            for (int i = 0; i < width; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
        }
    }
}
