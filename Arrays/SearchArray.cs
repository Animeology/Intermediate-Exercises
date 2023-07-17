namespace IntermediateExercises.Arrays
{
    using Base;

    public class SearchArray
    {
        public static void SearchCertainArray()
        {
            Printing.PrintLine("Input the total number for the array and input the numbers into the array and input the number to search through the array");

            int count = InputChecker.InputInt();
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = InputChecker.InputInt();
            }

            Printing.PrintLine("What number do you want to search?");
            int searchedNum = InputChecker.InputInt();

            for (int j = 0; j < count; j++)
            {
                if (arr[j] == searchedNum)
                {
                    Printing.PrintLine($"The number {searchedNum} exists");
                    break;
                }
                else
                {
                    Printing.PrintLine($"The number {searchedNum} doesn't exist");
                    break;
                }
            }
        }
    }
}
