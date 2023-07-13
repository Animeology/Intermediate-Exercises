namespace IntermediateExercises.GeometryB
{
    public class HollowSquareShape
    {
        public static void HollowSquare()
        {
            Console.WriteLine("Input a symbol and the width/height to display a hollow square");

            char symbol = Convert.ToChar(Console.ReadLine()!);
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();

            for (int i = 0; i < size - 2; i++)
            {
                Console.Write(symbol);

                for (int j = 0; j < size - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(symbol);
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
        }
    }
}
