namespace IntermediateExercises.Arrays
{
    public class SearchPostiveNegativeArray
    {
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
    }
}
