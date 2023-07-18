namespace IntermediateExercises.FlowControlsC
{
    using Base;

    public class ConditionalOperation
    {
        public static void ConditionalOp()
        {
            Printing.PrintLine("Input two numbers and it will output whether they are positive");

            int a = InputChecker.InputInt();
            int b = InputChecker.InputInt();

            var num1Pos = a > 0 ? "A is positive" : "A is negative";
            var num2Pos = b > 0 ? "B is positive" : "B is negative";
            var bothPos = a > 0 && b > 0 ? "Both are positive" : "One of them is negative or Both are negative";

            Printing.PrintLine(num1Pos);
            Printing.PrintLine(num2Pos);
            Printing.PrintLine(bothPos);
        }
    }
}
