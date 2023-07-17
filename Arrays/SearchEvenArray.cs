namespace IntermediateExercises.Arrays
{
    using Base;

    public class SearchEvenArray
    {
        public static void SearchEvenNums()
        {
            Printing.PrintLine("Input 10 numbers and it will display only the even numbers");

            int count = 10;
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = InputChecker.InputInt();
            }

            Console.WriteLine("Even Numbers:");

            for (int i = 0; i < count; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Printing.PrintInt(arr[i]);
                }
            }
        }
    }
}
