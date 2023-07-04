namespace Intermediate_Exercises
{
    public class FunctionsA
    {
        public void SwapParameters()
        {
            Console.WriteLine("Input two numbers and it will swap places.");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Swap(ref x, ref y);

            void Swap(ref int x, ref int y)
            {
                int temp;
                temp = x;
                x = y;
                y = temp;
                Console.WriteLine("{0} {1}", x, y);
            }
        }

        public void CalculateRefDouble()
        {
            Console.WriteLine("Input a number and it will print the number doubled");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Double(ref num));

            int Double(ref int num)
            {
                int result = num * 2;

                return result;
            }

        }

        public void CalculateDouble()
        {
            Console.WriteLine("Input a number and it will print the number doubled");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Double(num));

            int Double(int num)
            {
                int result = num * 2;

                return result;
            }
        }

        public void AddArray()
        {
            Console.WriteLine("Insert 5 numbers to add and it will add them together in the same array");

            int count = 5;
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Add(arr);

            void Add(int[] arr)
            {
                int total = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    total += arr[i];
                }

                Console.WriteLine(total);
            }
        }

        public void FormatText()
        {
            Console.WriteLine("Input a word and it will in the center and underlined");

            string text = Console.ReadLine()!;

            WriteCenteredUnderline(text);

            void WriteCenteredUnderline(string text)
            {
                double x = 35;
                double y = 5;

                Console.SetCursorPosition((int)x, (int)y);
                Console.Write(text);

                Console.WriteLine();

                for (int i = 0; i < text.Length; i++)
                {
                    Console.SetCursorPosition((int)x + i, (int)y + 1);
                    Console.Write('-');
                }
                Console.WriteLine();
            }
        }

        public void SpaceFunction()
        {
            Console.WriteLine("Input a sentence and it will count the total spaces in the sentence");

            string text = Console.ReadLine()!;

            Console.WriteLine(CountSpaces(text));

            int CountSpaces(string text)
            {
                int count = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ' ')
                    {
                        count++;
                    }
                }

                return count;
            }
        }
    }
}
