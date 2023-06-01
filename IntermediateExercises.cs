class IntermediateExercises
{
    static void Main(string[] args)
    {
        CalculateFunction();
    }

    static void CalculateFunction()
    {
        Console.WriteLine("Input two numbers for a range to calculate the following: y = x^2 - 2x + 1");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = x; i <= y; i++)
        {
            double function = Math.Pow(i, 2) - (2 * i) + 1;

            Console.Write("{0} ", function);
        }
    }
}