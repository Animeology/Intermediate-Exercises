namespace IntermediateExercises.Arrays
{
    public class Circumference
    {
        public static void CalculateCircumference()
        {
            Console.WriteLine("Draw the circumference of a oval");

            double x = 0;
            double y = 0;

            for (int i = 0; i < 360; i++)
            {
                double radians = i * Math.PI / 180.0;

                x = 35 + 8 * Math.Cos(radians);
                y = 10 + 8 * Math.Sin(radians);

                Console.SetCursorPosition((int)x, (int)y);
                Console.Write("X");
            }

            Console.SetCursorPosition(1, 20);
        }

    }
}
