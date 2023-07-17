namespace IntermediateExercises.Arrays
{
    using Base;

    public class BubbleSortArray
    {
        public static void BubbleSort()
        {
            Printing.PrintLine("Input 10 numbers and it will order them using Bubble Sort");

            int count = 10;
            int[] nums = new int[count];

            for (int i = 0; i < count; i++)
            {
                nums[i] = InputChecker.InputInt();
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
                Printing.PrintInt(nums[i]);
            }
        }
    }
}
