namespace IntermediateExercises.Arrays
{
    using Base;

    public class Circumference
    {
        public static void CalculateCircumference()
        {
            Printing.PrintLine("Draw the circumference of a oval");

            double x = 0;
            double y = 0;
            double degree = 180.0;

            for (int i = 0; i < 360; i++)
            {
                double radians = i * Math.PI / degree;

                x = 35 + 8 * Math.Cos(radians);
                y = 10 + 8 * Math.Sin(radians);

                Console.SetCursorPosition((int)x, (int)y);
                Printing.Print("X");
            }

            Console.SetCursorPosition(1, 20);
        }
    }
}
