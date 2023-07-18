namespace IntermediateExercises.GeometryA
{
    using Base;

    public class NorthEastTriangle
    {
        public static void NETriangle()
        {
            Printing.PrintLine("Input the width to print a '*' NorthEast triangle");

            int height = InputChecker.InputInt();
            int width = 0;
            int max = height;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Printing.PrintChar(' ');
                }

                for (int k = 0; k < max; k++)
                {
                    Printing.PrintChar('*');
                }
                Printing.NewLine();
                width++;
                max--;
            }
        }
    }
}
