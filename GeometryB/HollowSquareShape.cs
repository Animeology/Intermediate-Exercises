namespace IntermediateExercises.GeometryB
{
    using Base;

    public class HollowSquareShape
    {
        public static void HollowSquare()
        {
            Printing.PrintLine("Input a symbol and the width/height to display a hollow square");

            char symbol = InputChecker.InputChar();
            int size = InputChecker.InputInt();

            for (int i = 0; i < size; i++)
            {
                Printing.PrintChar(symbol);
            }

            Printing.NewLine();

            for (int i = 0; i < size - 2; i++)
            {
                Printing.PrintChar(symbol);

                for (int j = 0; j < size - 2; j++)
                {
                    Printing.Print(" ");
                }

                Printing.PrintCharLine(symbol);
            }

            for (int i = 0; i < size; i++)
            {
                Printing.PrintChar(symbol);
            }

            Printing.NewLine();
        }
    }
}
