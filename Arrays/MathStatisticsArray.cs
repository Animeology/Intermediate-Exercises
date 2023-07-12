namespace IntermediateExercises
{
    public class MathStatisticsArray
    {
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
    }
}
