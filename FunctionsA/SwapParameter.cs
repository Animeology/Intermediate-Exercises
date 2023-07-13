namespace IntermediateExercises.FunctionsA
{
    public class SwapParameter
    {
        public static void SwapParameters()
        {
            Console.WriteLine("Input two numbers and it will swap places.");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Swap(ref x, ref y);

            void Swap(ref int x, ref int y)
            {
                int temp;
                temp = x;
                x = y;
                y = temp;
                Console.WriteLine("{0} {1}", x, y);
            }
        }
    }
}
