namespace IntermediateExercises.GeometryA
{
    using Base;

    public class TriangleShape
    {
        public static void Triangle()
        {
            Printing.PrintLine("Input the symbol and a width to print a triangle");

            char symbol = InputChecker.InputChar();
            int width = InputChecker.InputInt();
            int height = width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Printing.PrintChar(symbol);
                }
                Printing.NewLine();
                width--;
            }
        }
    }
}
