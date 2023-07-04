namespace Intermediate_Exercises
{
    public class Recursion
    {
        public void PalindromeRecursion()
        {
            Console.WriteLine("Input a string and it will check if it is a palindrome by recursion");
            string text = Console.ReadLine()!;

            Console.WriteLine(Palindrome(text));

            bool Palindrome(string text)
            {
                if (text.Length <= 1)
                {
                    return true;
                }
                else
                {
                    if (text[0] != text[text.Length - 1])
                    {
                        return false;
                    }
                    else
                    {
                        return Palindrome(text.Substring(1, text.Length - 2));
                    }
                }
            }
        }

        public void ReverseRecursion()
        {
            Console.WriteLine("Input a string and it will be reverse by recursion");
            string text = Console.ReadLine()!;

            Console.WriteLine(Reverse(text));

            string Reverse(string text)
            {
                if (text.Length <= 1)
                {
                    return text;
                }
                else
                {
                    char firstLetter = text[0];
                    string restOfWord = text.Substring(1);
                    return Reverse(restOfWord) + firstLetter;
                }
            }
        }

        public void FactorialRecursion()
        {
            Console.WriteLine("A Factorial that starts with the user input");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(num));

            int Factorial(int num)
            {
                if (num == 0)
                {
                    return 1;
                }
                else
                {
                    return num * Factorial(num - 1);
                }
            }
        }

        public void FibonacciRecursion()
        {
            Console.WriteLine("A Fibonacci that starts with the user input");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fibonacci(num));

            int Fibonacci(int num)
            {
                if (num == 1 || num == 2)
                {
                    return 1;
                }
                else
                {
                    return Fibonacci(num - 1) + Fibonacci(num - 2);
                }
            }
        }

        public void PowerRecursion()
        {
            Console.WriteLine("Input two numbers and it will do the power of the number using recursion");

            int num = Convert.ToInt32(Console.ReadLine());
            int power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Power(num, power));

            int Power(int num, int power)
            {
                if (power == 0)
                {
                    return 1;
                }
                else
                {
                    return num * Power(num, power - 1);
                }
            }
        }

        public void MultiplyRecursion()
        {
            Console.WriteLine("Input 2 numbers and it will multiply it by recursion");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Multiply(x, y));

            int Multiply(int x, int y)
            {
                if (y == 0)
                {
                    return 0;
                }
                else
                {
                    return x + Multiply(x, y - 1);
                }
            }
        }
    }
}
