namespace IntermediateExercises.GeometryA
{
    using Base;

    public class RightTriangle
    {
        public static void RightAlignTriangle()
        {
            Printing.PrintLine("Input a string and it will make a right-aligned triangle");

            string input = InputChecker.InputStringOnlyLetters();
            int height = input.Length - 1;
            int width = 1;

            Console.WriteLine();
            for (int i = height; i >= 0; i--)
            {
                Printing.PrintLine(input.Substring(i, width));
                width++;
            }
        }
    }
}
