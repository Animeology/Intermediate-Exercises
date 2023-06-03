class IntermediateExercises
{
    static void Main(string[] args)
    {
        InfiniteDivide();
        // AccessControl();
        // MultipleThreesAndFives();
        // GraphicFunction();
        // RightAlignTriangle();
        // NETriangle();
        // Triangle();
        // CalculateFunction();
    }

    static void InfiniteDivide()
    {
        Console.WriteLine("Input two numbers and it would keep dividing until the first input is 0");

        int num1;
        int num2;


        do
        {
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 != 0)
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("You cannot divide by 0");
                }
                else
                {
                    int result = num1 / num2;
                    Console.WriteLine("The division is {0}", result);
                    Console.WriteLine("The rest is {0}", num1 % num2);
                }
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }

        } while (num1 != 0);
    }

    static void AccessControl()
    {
        Console.WriteLine("Try to login with the username and password");

        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine()!;

            Console.Write("Password: ");
            string password = Console.ReadLine()!;

            if (username == "12" && password == "1234")
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("Login Failed!");
            }
            attempts++;

            if(attempts == 3)
            {
                Console.WriteLine("You used all your attempts!");
            }
        }
    }

    static void MultipleThreesAndFives()
    {
        Console.WriteLine("Prints out numbers ranged from 1 to 500 that are multiples of 3 and 5");

        int x = 1;
        int y = 500;

        for (int i = x; i <= y; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("{0} ", i);
            }
        }
    }

    static void GraphicFunction()
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

    static void RightAlignTriangle()
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

    static void NETriangle()
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
    static void Triangle()
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

    static void CalculateFunction()
    {
        Console.WriteLine("Input two numbers for a range to calculate the following: y = x^2 - 2x + 1");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = x; i <= y; i++)
        {
            double function = Math.Pow(i, 2) - (2 * i) + 1;

            Console.Write("{0} ", function);
        }
    }
}