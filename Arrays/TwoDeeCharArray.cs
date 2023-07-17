namespace IntermediateExercises.Arrays
{
    using Base;

    public class TwoDeeCharArray
    {
        public static void DrawTwoDeeCharArray()
        {
            Printing.PrintLine("Draws a 20(row) by 70(col) of 'X'");

            int rows = 20;
            int cols = 70;
            char x = 'X';

            char[,] arr = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = x;
                    Printing.PrintInt(arr[i, j]);
                }
                Printing.NewLine();
            }
        }
    }
}
