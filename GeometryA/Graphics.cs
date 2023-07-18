namespace IntermediateExercises.GeometryA
{
    using Base;

    public class Graphics
    {
        public static void GraphicFunction()
        {
            Printing.PrintLine("Input two numbers for a range to calculate the following: y = (x - 4)^2");

            int x = InputChecker.InputInt();
            int y = InputChecker.InputInt();

            for (int i = x; i <= y; i++)
            {
                double function = (i - 4);
                double graphicFunc = Math.Pow(function, 2);

                for (int j = 0; j < graphicFunc; j++)
                {
                    Printing.PrintChar('*');
                }
                Printing.NewLine();
            }
        }
    }
}
