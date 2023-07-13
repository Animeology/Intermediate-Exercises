namespace IntermediateExercises.FunctionsC
{
    public class MaxToMinArray
    {
        public static void MaxMinArray()
        {
            Console.WriteLine("Input 5 numbers into the array and it will find the max and min number in the array");

            int count = 5;
            int[] arr = new int[count];

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < count; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            FindMinMax(arr, max, min);

            void FindMinMax(int[] arr, int max, int min)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                Console.WriteLine("Min: {0}", min);
                Console.WriteLine("Max: {0}", max);
            }
        }
    }
}
