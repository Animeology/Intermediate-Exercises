namespace IntermediateExercises.FunctionsA
{
    using Base;

    public class SwapParameter
    {
        public static void SwapParameters()
        {
            Printing.PrintLine("Input two numbers and it will swap places.");

            int x = InputChecker.InputInt();
            int y = InputChecker.InputInt();

            Swap(ref x, ref y);

            void Swap(ref int x, ref int y)
            {
                int temp;

                temp = x;
                x = y;
                y = temp;

                Printing.PrintLine($"{x} {y}");
            }
        }
    }
}
