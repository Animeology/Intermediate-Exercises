namespace IntermediateExercises.Arrays
{
    public class SearchArray
    {
        public static void SearchCertainArray()
        {
            Console.WriteLine("Input 5 numbers and input the number to search through the array");

            int count = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("What number do you want to search?");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < count; j++)
            {
                if (arr[j] == y)
                {
                    Console.WriteLine("The number {0} exists", y);
                    break;
                }
                else
                {
                    Console.WriteLine("The number {0} doesn't exist", y);
                    break;
                }
            }
        }
    }
}
