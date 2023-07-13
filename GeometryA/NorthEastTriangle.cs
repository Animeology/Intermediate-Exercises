namespace IntermediateExercises.GeometryA
{
    public class NorthEastTriangle
    {
        public static void NETriangle()
        {
            Console.WriteLine("Input the width to print a '*' NorthEast triangle");

            int height = Convert.ToInt32(Console.ReadLine()!);
            int width = 0;
            int max = height;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(' ');
                }

                for (int k = 0; k < max; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                width++;
                max--;
            }
        }
    }
}
