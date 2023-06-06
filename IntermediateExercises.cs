class IntermediateExercises
{
    static void Main(string[] args)
    {
        TwoDeeArrays();
        //BubbleSort();
        //SearchPosAndNeg();
        //SearchEvenNums();
        //SearchArray();
        //ReverseArray();
        //HexadecimalTable();
        //BinaryHexadecimal();
        //PrimeFactors();
        //Pyramid();
        //Parallelogram();
        //HollowRectangle();
        //HollowSquare();
        //NestedConditionalOp();
        //ConditionalOp();
        //MoneyChange();
        //Alphabet();
        //MathStatistics();
        //RepetitiveStructures();
        //InfiniteDivide();
        //AccessControl();
        //MultipleThreesAndFives();
        //GraphicFunction();
        //RightAlignTriangle();
        //NETriangle();
        //Triangle();
        //CalculateFunction();
    }

    static void TwoDeeArrays()
    {
        Console.WriteLine("Input 10 grades and it will split it into 2 groups of 5 and calculate the average of each group");

        int groupBy = 5;
        int[,] allGrades = new int[groupBy, groupBy];

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < groupBy; j++)
            {
                allGrades[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int group1Total = 0;
        for(int i = 0; i < groupBy; i++)
        {
            group1Total += allGrades[0, i];
        }
        Console.WriteLine("Average for group 1 is {0}", group1Total / groupBy);

        int group2Total = 0;
        for (int i = 0; i < groupBy; i++)
        {
            group2Total += allGrades[1, i];
        }
        Console.WriteLine("Average for group 2 is {0}", group2Total / groupBy);
    }

    static void BubbleSort()
    {
        Console.WriteLine("Input 10 numbers and it will order them using Bubble Sort");

        int count = 10;
        int[] nums = new int[count];

        for(int i = 0; i < count; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int temp;
        for(int i =  0; i <= nums.Length - 2; i++) 
        {
            for(int j = 0; j <= nums.Length - 2; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    temp = nums[j + 1];
                    nums[j + 1] = nums[j];
                    nums[j] = temp;
                }
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i]);
        }

    }

    static void SearchPosAndNeg()
    {
        Console.WriteLine("Input 10 numbers and it will display the mean for positive numbers and negative numbers");

        int count = 10;
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int meanPos = 0;
        int meanNeg = 0;
        int posNums = 0;
        int negNums = 0;
        int totalPos = 0;
        int totalNeg = 0;

        for (int i = 0; i < count; i++)
        {
            if (arr[i] > 0)
            {
                totalPos = totalPos + arr[i];

                posNums++;

                meanPos = totalPos / posNums;

            }

            if (arr[i] < 0)
            {
                totalNeg = totalNeg + arr[i];

                negNums++;

                meanNeg = totalNeg / negNums;

            }
        }

        Console.WriteLine("Average numbers negative is {0}", meanNeg);
        Console.WriteLine("Average numbers positive is {0}", meanPos);
    }

    static void SearchEvenNums()
    {
        Console.WriteLine("Input 10 numbers and it will display only the even numbers");

        int count = 10;
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Even Numbers:");

        for (int i = 0; i < count; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    static void SearchArray()
    {
        Console.WriteLine("Input 5 numbers and input the number to search through the array");

        int count = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("What number do you want to search?");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int j = 0; j < count; j++)
        {
            if (arr[j] == y)
            {
                Console.WriteLine("The number {0} exists", y);
                break;
            }
            else
            {
                Console.WriteLine("The number {0} doesn't exist", y);
                break;
            }
        }
    }

    static void ReverseArray()
    {
        Console.WriteLine("Input 5 numbers and it will print it in reverse array");

        int max = 5;
        int[] nums = new int[max];

        for (int i = 0; i < max; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Reverse(nums);

        for (int i = 0; i < max; i++)
        {
            Console.Write("{0} ", nums[i]);
        }
    }

    static void HexadecimalTable()
    {
        Console.WriteLine("Prints a hexadecimal table");

        int max = 255;

        for (int i = 0; i <= max; i++)
        {
            if (i < 16)
            {
                Console.Write("0");
            }

            Console.Write("{0} ", Convert.ToString(i, 16));

            if (i % 16 == 15)
            {
                Console.WriteLine();
            }
        }
    }

    static void BinaryHexadecimal()
    {
        Console.WriteLine("Input a number and it will convert it to binary and hexadecimal");

        int num;

        do
        {
            num = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(num, 2);
            string hexadecimal = Convert.ToString(num, 16);

            if (num != 0)
            {
                Console.WriteLine("Binary: " + binary);
                Console.WriteLine("Hexadecimal: " + hexadecimal);
            }
        } while (num != 0);
    }

    static void PrimeFactors()
    {
        Console.WriteLine("Input a integer and it will display the product of its prime factor");

        int num = Convert.ToInt32(Console.ReadLine());
        int divisor = 2;

        while (num > 1)
        {
            while (num % divisor == 0)
            {
                Console.Write(divisor + "x");
                num = num / divisor;
            }
            divisor++;
        }
        Console.WriteLine(1);
    }

    static void Pyramid()
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

    static void Parallelogram()
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

    static void HollowRectangle()
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

    static void HollowSquare()
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

    static void NestedConditionalOp()
    {
        Console.WriteLine("Input two numbers and it will check how many of them are positive");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        var pos = (a > 0 && b > 0) ? 2 : ((a > 0 || b > 0) ? 1 : 0);

        Console.WriteLine(pos);
    }

    static void ConditionalOp()
    {
        Console.WriteLine("Input two numbers and it will output whether they are positive");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        var num1Pos = a > 0 ? "A is positive" : "A is negative";
        var num2Pos = b > 0 ? "B is positive" : "B is negative";
        var bothPos = a > 0 && b > 0 ? "Both are positive" : "One of them is negative or Both are negative";

        Console.WriteLine(num1Pos);
        Console.WriteLine(num2Pos);
        Console.WriteLine(bothPos);

    }

    static void MoneyChange()
    {
        Console.WriteLine("Request the total money in the cash register and the purchase value");

        int total = Convert.ToInt32(Console.ReadLine());
        int value = Convert.ToInt32(Console.ReadLine());

        int change = total - value;

        while (change >= 50)
        {
            Console.WriteLine("50 ");
            change -= 50;
        }

        while (change >= 20)
        {
            Console.WriteLine("20 ");
            change -= 20;
        }

        while (change >= 10)
        {
            Console.WriteLine("10 ");
            change -= 10;
        }

        while (change >= 5)
        {
            Console.WriteLine("5 ");
            change -= 5;
        }

        while (change >= 2)
        {
            Console.WriteLine("2 ");
            change -= 2;
        }

        while (change >= 1)
        {
            Console.WriteLine("1 ");
            change -= 1;
        }

    }

    static void Alphabet()
    {
        Console.WriteLine("Displays the Alphabet");

        for (char c = 'A'; c < 'Z'; c++)
        {
            Console.Write("{0} ", c);
        }
    }

    static void MathStatistics()
    {
        Console.WriteLine("Input 5 numbers and it will calculate the sum, mean, the max, and the minimum number");

        int totalNums = 5;
        int[] nums = new int[totalNums];

        for (int i = 0; i < totalNums; i++)
        {
            nums[i] = int.Parse(Console.ReadLine()!);
        }

        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < totalNums; i++)
        {
            sum += nums[i];

            if (nums[i] > max)
            {
                max = nums[i];
            }

            if (nums[i] < min)
            {
                min = nums[i];
            }

        }

        int mean = sum / totalNums;

        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Mean: {0}", mean);
        Console.WriteLine("Max: {0}", max);
        Console.WriteLine("Min: {0}", min);
    }

    static void RepetitiveStructures()
    {
        Console.WriteLine("Input two numbers and it will show the range between these two numbers included the two inputs");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        // For Loop
        for (int i = x; i <= y; i++)
        {
            Console.Write("{0} ", i);
        }

        Console.WriteLine();

        // While loop
        int loop = x;
        while (loop <= y)
        {
            Console.Write("{0} ", loop);
            loop++;
        }

        Console.WriteLine();

        // Do While loop
        int j = x;
        do
        {
            Console.Write("{0} ", j);
            j++;
        } while (j <= y);
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

            if (attempts == 3)
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