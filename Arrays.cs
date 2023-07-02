namespace Intermediate_Exercises
{
    public class Arrays
    {
        public static void Circumference()
        {
            Console.WriteLine("Draw the circumference of a oval");

            double x = 0;
            double y = 0;

            for (int i = 0; i < 360; i++)
            {
                double radians = i * Math.PI / 180.0;

                x = 35 + 8 * Math.Cos(radians);
                y = 10 + 8 * Math.Sin(radians);

                Console.SetCursorPosition((int)x, (int)y);
                Console.Write("X");
            }

            Console.SetCursorPosition(1, 20);
        }

        public static void MathematicalStatistics()
        {
            int choice = 0;
            int total = 1000;
            int count = 0;

            float sum = 0;
            float mean = 0;
            float max = int.MinValue;
            float min = int.MaxValue;

            float num;

            float[] arr = new float[total];

            void Menu()
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Statistics");
                Console.WriteLine("5. Exit");
                Console.Write("Enter a option (1-5): ");

                choice = Convert.ToInt32(Console.ReadLine());
            }


            while (choice != 5 && count < 1000)
            {
                Menu();

                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Show();
                        break;
                    case 3:
                        Search();
                        break;
                    case 4:
                        Statistics();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Not an option!");
                        Menu();
                        break;
                }
            }

            void Add()
            {
                if (count < total)
                {
                    num = Convert.ToSingle(Console.ReadLine());
                    arr[count] = num;

                    sum += arr[count];


                    if (arr[count] > max)
                    {
                        max = arr[count];
                    }

                    if (arr[count] < min)
                    {
                        min = arr[count];
                    }
                    count++;
                    mean = sum / count;
                }
                else
                {
                    Console.WriteLine("Database is full");
                }
            }

            void Show()
            {
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("{0} ", arr[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No data available");
                }
            }

            void Search()
            {
                float searchedNum = Convert.ToInt32(Console.ReadLine());

                bool foundNum = false;

                for (int i = 0; i < count; i++)
                {
                    if (arr[i] == searchedNum)
                    {
                        foundNum = true;
                    }
                }
                if (foundNum)
                {
                    Console.WriteLine("{0} exists in the array", searchedNum);
                }
                else
                {
                    Console.WriteLine("{0} doesn't exist in the array", searchedNum);
                }
            }

            void Statistics()
            {
                Console.WriteLine("Total data: {0}", count);
                Console.WriteLine("Sum: {0}", sum);
                Console.WriteLine("Average: {0}", mean);
                Console.WriteLine("Min value: {0}", min);
                Console.WriteLine("Max value: {0}", max);
            }
        }

        public struct Car
        {
            public string model;
            public int year;

            public void SetCar()
            {
                model = Console.ReadLine()!;
                year = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void ArrayStruct()
        {
            Console.WriteLine("Input 3 car models and the year of production for each and it will display them in order of production");

            int totalCars = 3;
            Car[] cars = new Car[totalCars];

            for (int i = 0; i < totalCars; i++)
            {
                cars[i].SetCar();
            }

            for (int i = 0; i < totalCars - 2; i++)
            {
                Car temp;
                if (cars[i].year > cars[i + 1].year)
                {
                    temp = cars[i];
                    cars[i] = cars[i + 1];
                    cars[i + 1] = temp;
                }
            }

            for (int i = 0; i < totalCars; i++)
            {
                Console.WriteLine("Model: {0}, Year of production: {1}", cars[i].model, cars[i].year);
            }
        }

        public static void TwoDeeCharArray()
        {
            Console.WriteLine("Draws a 20(row) by 70(col) of 'X'");

            int rows = 20;
            int cols = 70;
            char x = 'X';

            char[,] arr = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = x;
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void TwoDeeArrays()
        {
            Console.WriteLine("Input 10 grades and it will split it into 2 groups of 5 and calculate the average of each group");

            int groupBy = 5;
            int[,] allGrades = new int[groupBy, groupBy];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < groupBy; j++)
                {
                    allGrades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int group1Total = 0;
            for (int i = 0; i < groupBy; i++)
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

        public static void BubbleSort()
        {
            Console.WriteLine("Input 10 numbers and it will order them using Bubble Sort");

            int count = 10;
            int[] nums = new int[count];

            for (int i = 0; i < count; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int temp;
            for (int i = 0; i <= nums.Length - 2; i++)
            {
                for (int j = 0; j <= nums.Length - 2; j++)
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

        public static void SearchPosAndNeg()
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

        public static void SearchEvenNums()
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

        public static void SearchArray()
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

        public static void ReverseArray()
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
    }
}
