namespace IntermediateExercises.FunctionsA
{
    using Base;

    public class AddingIndexInArray
    {
        public static void AddArray()
        {
            Printing.PrintLine("Insert 5 numbers to add and it will add them together in the same array");

            int count = 5;
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = InputChecker.InputInt();
            }

            Add(arr);

            void Add(int[] arr)
            {
                int total = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    total += arr[i];
                }

                Printing.PrintIntLine(total);
            }
        }
    }
}
