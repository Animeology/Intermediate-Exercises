namespace IntermediateExercises.FlowControlsA
{
    using Base;

    public class MathematicalStatistics
    {
        public static void MathStatistics()
        {
            Printing.PrintLine("Input 5 numbers and it will calculate the sum, mean, the max, and the minimum number");

            int totalNums = 5;
            int[] nums = new int[totalNums];

            for (int i = 0; i < totalNums; i++)
            {
                nums[i] = InputChecker.InputInt();
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

            Printing.PrintLine($"Sum: {sum}");
            Printing.PrintLine($"Mean: {mean}");
            Printing.PrintLine($"Max: {max}");
            Printing.PrintLine($"Min: {min}");
        }
    }
}
