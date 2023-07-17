namespace IntermediateExercises.Arrays
{
    using Base;

    public class SearchPostiveNegativeArray
    {
        public static void SearchPosAndNeg()
        {
            Printing.PrintLine("Input 10 numbers and it will display the mean for positive numbers and negative numbers");

            int count = 10;
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = InputChecker.InputInt();
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

            Printing.PrintLine($"Average numbers positive is {meanPos}");
            Printing.PrintLine($"Average numbers negative is {meanNeg}");
        }
    }
}
