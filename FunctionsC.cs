namespace Intermediate_Exercises
{
    public class FunctionsC
    {
        public void Palindrome()
        {
            Console.WriteLine("Input a string and it will check if it is a palindrome");

            string text = Console.ReadLine()!;
            string reverse = string.Empty;

            Console.WriteLine(IsPalindrome(text));

            bool IsPalindrome(string text)
            {
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reverse += text[i];
                }
                if (text == reverse)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void MaxMinArray()
        {
            Console.WriteLine("Input 5 numbers into the array and it will find the max and min number in the array");

            int count = 5;
            int[] arr = new int[count];

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < count; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            FindMinMax(arr, max, min);

            void FindMinMax(int[] arr, int max, int min)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                Console.WriteLine("Min: {0}", min);
                Console.WriteLine("Max: {0}", max);
            }
        }

        public int MainParameterCalculatorReturn(string[] args)
        {
            Console.WriteLine("Input an equation and it will calculate");
            Console.WriteLine("Accepts only \"+\", \"-\", \"*\" \"x\" \"X\", \"/\" ");

            int x = Convert.ToInt32(args[0]);
            char op = Convert.ToChar(args[1]);
            int y = Convert.ToInt32(args[2]);

            if (args.Length != 0)
            {
                return 1;
            }

            if (args[1] != "+" || args[1] != "-" || args[1] != "*" || args[1] != "/")
            {
                return 2;
            }

            try
            {
                Convert.ToInt32(x);
                Convert.ToInt32(y);
            }
            catch
            {
                return 3;
            }

            switch (op)
            {
                case '+':
                    Console.Write(x + y);
                    break;
                case '-':
                    Console.Write(x - y);
                    break;
                case '*':
                case 'x':
                case 'X':
                    Console.Write(x * y);
                    break;
                case '/':
                    Console.Write(x / y);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            return 0;
        }

        public void MainParameterCalculator(string[] args)
        {
            Console.WriteLine("Input an equation and it will calculate");
            Console.WriteLine("Accepts only \"+\", \"-\", \"*\" \"x\" \"X\", \"/\" ");

            int x = Convert.ToInt32(args[0]);
            char op = Convert.ToChar(args[1]);
            int y = Convert.ToInt32(args[2]);

            switch (op)
            {
                case '+':
                    Console.Write(x + y);
                    break;
                case '-':
                    Console.Write(x - y);
                    break;
                case '*':
                case 'x':
                case 'X':
                    Console.Write(x * y);
                    break;
                case '/':
                    Console.Write(x / y);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }

        public void CheckNumber()
        {
            Console.WriteLine("Input a string to check if the whole string is only alphabetic");

            string text = Console.ReadLine()!;

            Console.WriteLine(IsNumber(text));

            bool IsNumber(string text)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] < '1' || text[i] > '9')
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public void CheckAlphabet()
        {
            Console.WriteLine("Input a string to check if the whole string is only alphabetic");

            string text = Console.ReadLine()!;

            Console.WriteLine(IsAlphabetic(text));

            bool IsAlphabetic(string text)
            {
                text = text.ToUpper();

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] < 'A' || text[i] > 'Z')
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
