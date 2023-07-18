namespace IntermediateExercises.FlowControlsB
{
    using Base;

    public class InfiniteDivide
    {
        public static void KeepOnDividing()
        {
            Printing.PrintLine("Input two numbers and it would keep dividing until the first input is 0");

            int num1;
            int num2;

            do
            {
                num1 = InputChecker.InputInt();

                if (num1 != 0)
                {
                    num2 = InputChecker.InputInt();
                    if (num2 == 0)
                    {
                        Printing.PrintLine("You cannot divide by 0");
                    }
                    else
                    {
                        int result = num1 / num2;
                        int reminding = num1 % num2;
                        Printing.PrintLine($"The division is {result}");
                        Printing.PrintLine($"The rest is {reminding}");
                    }
                }
                else
                {
                    Printing.PrintLine("Goodbye!");
                }

            } while (num1 != 0);
        }
    }
}
