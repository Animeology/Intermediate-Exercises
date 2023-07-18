namespace IntermediateExercises.FunctionsB
{
    using Base;

    public class SearchMaxValue
    {
        public static void GreatestValue()
        {
            Printing.PrintLine("Request 5 numbers and it will display the highest number");

            int count = 5;
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = InputChecker.InputInt();
            }

            Printing.PrintInt(SearchGreatestValue(arr));

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
