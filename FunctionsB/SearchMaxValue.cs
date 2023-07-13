namespace IntermediateExercises.FunctionsB
{
    public class SearchMaxValue
    {
        public static void GreatestValue()
        {
            Console.WriteLine("Request 5 numbers and it will display the highest number");

            int count = 5;
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(SearchGreatestValue(arr));

            int SearchGreatestValue(int[] arr)
            {
                int max = int.MinValue;
                for (int i = 0; i < count; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                return max;
            }
        }
    }
}
