namespace IntermediateExercises.GeometryB
{
    using Base;

    public class HollowRectShape
    {
        public static void HollowRectangle()
        {
            Printing.PrintLine("Input a symbol and the width/height to display a hollow rectangle");

            char symbol = InputChecker.InputChar();
            int width = InputChecker.InputInt();
            int height = InputChecker.InputInt();

            for (int i = 0; i < width; i++)
            {
                Printing.PrintChar(symbol);
            }

            Printing.NewLine();

            for (int i = 0; i < height; i++)
            {
                Printing.PrintChar(symbol);

                for (int j = 0; j < width - 2; j++)
                {
                    Printing.Print(" ");
                }

                Printing.PrintCharLine(symbol);
            }

            for (int i = 0; i < width; i++)
            {
                Printing.PrintChar(symbol);
            }

            Printing.NewLine();
        }
    }
}
