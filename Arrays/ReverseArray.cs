namespace IntermediateExercises.Arrays
{
    public class ReverseArray
    {
        public static void ReversingTheArray()
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
