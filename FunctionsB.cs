namespace Intermediate_Exercises
{
    public class FunctionsB
    {
        public void Title()
        {
            Console.WriteLine("Input a string and it will print it like a title");

            string text = Console.ReadLine()!;

            WriteTitle(text);

            void WriteTitle(string text)
            {
                text = text.ToUpper();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine();

                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text[i] + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine();

                for (int i = 0; i < text.Length * 2 - 1; i++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
            }
        }

        public void PowerOperation()
        {
            Console.WriteLine("Input 2 numbers and the it will calculate the first number of the power of the second number");

            double num = Convert.ToInt32(Console.ReadLine());
            double power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Power(num, power));

            double Power(double num, double power)
            {
                double result = Math.Pow(num, power);

                return result;
            }
        }

        public void GreatestValue()
        {
            Console.WriteLine("Request 5 numbers and it will display the highest number");

            int count = 5;
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(SearchGreatestValue(arr));

            int SearchGreatestValue(int[] arr)
            {
                int max = int.MinValue;
                for (int i = 0; i < count; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                return max;
            }
        }

        public void ReverseString()
        {
            Console.WriteLine("Input a text and it will be reverse");

            string text = Console.ReadLine()!;

            InvertString(text);

            void InvertString(string text)
            {
                char[] arr = text.ToCharArray();
                Array.Reverse(arr);
                Console.WriteLine(arr);
            }
        }

        public void Add()
        {
            Console.WriteLine("Input a number and it will add of them");

            string text = Console.ReadLine()!;

            Console.WriteLine(AddDigits(text));

            int AddDigits(string text)
            {
                int sum = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    sum += Convert.ToInt32(text.Substring(i, 1));
                }

                return sum;
            }
        }

        public void ModifyCharacter()
        {
            Console.WriteLine("Input a text, position of the lettter you want to change and input a new character");

            string text = Console.ReadLine()!;
            int position = Convert.ToInt32(Console.ReadLine());
            char letter = Convert.ToChar(Console.Read());

            Console.WriteLine(ChangeLetter(text, position, letter));

            string ChangeLetter(string text, int position, char letter)
            {
                text = text.Remove(position, 1);
                text = text.Insert(position, letter.ToString());

                return text;
            }
        }
    }
}
