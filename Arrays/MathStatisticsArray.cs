namespace IntermediateExercises
{
    using Base;

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
                Printing.PrintLine("1. Add");
                Printing.PrintLine("2. Show");
                Printing.PrintLine("3. Search");
                Printing.PrintLine("4. Statistics");
                Printing.PrintLine("5. Exit");
                Printing.Print("Enter a option (1-5): ");

                choice = InputChecker.InputInt();
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
                        Printing.PrintLine("Not an option!");
                        Menu();
                        break;
                }
            }

            void Add()
            {
                if (count < total)
                {
                    num = InputChecker.InputFloat();
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
                    Printing.PrintLine("Database is full");
                }
            }

            void Show()
            {
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Printing.Print($"{arr[i]} ");
                    }
                    Printing.NewLine();
                }
                else
                {
                    Printing.PrintLine("No data available");
                }
            }

            void Search()
            {
                float searchedNum = InputChecker.InputFloat();

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
                    Printing.PrintLine($"{searchedNum} exists in the array");
                }
                else
                {
                    Printing.PrintLine($"{searchedNum} doesn't exist in the array");
                }
            }

            void Statistics()
            {
                Printing.PrintLine($"Total data: {count}");
                Printing.PrintLine($"Sum: {sum}");
                Printing.PrintLine($"Average: {mean}");
                Printing.PrintLine($"Min value: {min}");
                Printing.PrintLine($"Max value: {max}");
            }
        }
    }
}
