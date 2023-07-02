namespace Intermediate_Exercises
{
    public class GeometryA
    {
        public static void GraphicFunction()
        {
            Console.WriteLine("Input two numbers for a range to calculate the following: y = (x - 4)^2");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                double function = (i - 4);
                double graphicFunc = Math.Pow(function, 2);

                for (int j = 0; j < graphicFunc; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

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
