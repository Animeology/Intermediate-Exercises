namespace IntermediateExercises.FlowControlsB
{
    public class RepeatingStructures
    {
        public static void RepetitiveStructures()
        {
            Console.WriteLine("Input two numbers and it will show the range between these two numbers included the two inputs");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            // For Loop
            for (int i = x; i <= y; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            // While loop
            int loop = x;
            while (loop <= y)
            {
                Console.Write("{0} ", loop);
                loop++;
            }

            Console.WriteLine();

            // Do While loop
            int j = x;
            do
            {
                Console.Write("{0} ", j);
                j++;
            } while (j <= y);
        }
    }
}
