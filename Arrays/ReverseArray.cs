namespace IntermediateExercises.Arrays
{
    using Base;

    public class ReverseArray
    {
        public static void ReversingTheArray()
        {
            Printing.PrintLine("Input 5 numbers and it will print it in reverse array");

            int max = 5;
            int[] nums = new int[max];

            for (int i = 0; i < max; i++)
            {
                nums[i] = InputChecker.InputInt();
            }

            Array.Reverse(nums);

            for (int i = 0; i < max; i++)
            {
                Printing.Print($"{nums[i]} ");
            }
        }
    }
}
