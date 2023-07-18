namespace IntermediateExercises.GeometryB
{
    using Base;

    public class ParallelogramShape
    {
        public static void Parallelogram()
        {
            Printing.PrintLine("Input the width, height, and symbol to display a parallelogram");

            int width = InputChecker.InputInt();
            int height = InputChecker.InputInt();
            char symbol = InputChecker.InputChar();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Printing.PrintChar(symbol);
                }

                Printing.NewLine();

                for (int k = 0; k <= i; k++)
                {
                    Printing.Print(" ");
                }
            }
        }
    }
}
