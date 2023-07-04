namespace Intermediate_Exercises
{
    public class GeometryB
    {
        public void Pyramid()
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

        public void Parallelogram()
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

        public void HollowRectangle()
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

        public void HollowSquare()
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
