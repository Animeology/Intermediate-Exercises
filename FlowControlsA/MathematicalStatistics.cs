namespace IntermediateExercises.FlowControlsA
{
    public class MathematicalStatistics
    {
        public static void MathStatistics()
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
    }
}
