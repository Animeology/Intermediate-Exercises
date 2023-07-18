namespace IntermediateExercises.FlowControlsB
{
    using Base;

    public class RepeatingStructures
    {
        public static void RepetitiveStructures()
        {
            Printing.PrintLine("Input two numbers and it will show the range between these two numbers included the two inputs");

            int x = InputChecker.InputInt();
            int y = InputChecker.InputInt();

            // For Loop
            for (int i = x; i <= y; i++)
            {
                Printing.Print($"{i} ");
            }

            Printing.NewLine();

            // While loop
            int loop = x;
            while (loop <= y)
            {
                Printing.Print($"{loop} ");
                loop++;
            }

            Printing.NewLine();

            // Do While loop
            int j = x;
            do
            {
                Printing.Print($"{j} ");
                j++;
            } while (j <= y);
        }
    }
}
