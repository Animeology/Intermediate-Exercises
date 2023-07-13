namespace IntermediateExercises.GeometryA
{
    public class Graphics
    {
        public static void GraphicFunction()
        {
            Console.WriteLine("Input two numbers for a range to calculate the following: y = (x - 4)^2");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                double function = (i - 4);
                double graphicFunc = Math.Pow(function, 2);

                for (int j = 0; j < graphicFunc; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
