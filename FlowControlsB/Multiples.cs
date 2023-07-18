namespace IntermediateExercises.FlowControlsB
{
    using Base;

    public class Multiples
    {
        public static void MultipleThreesAndFives()
        {
            Printing.PrintLine("Prints out numbers ranged from 1 to 500 that are multiples of 3 and 5");

            int x = 1;
            int y = 500;

            for (int i = x; i <= y; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Printing.Print($"{i} ");
                }
            }
        }
    }
}
