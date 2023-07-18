namespace IntermediateExercises.FlowControlsC
{
    using Base;

    public class NestedConditional
    {
        public static void NestedConditionalOp()
        {
            Printing.PrintLine("Input two numbers and it will check how many of them are positive");

            int a = InputChecker.InputInt();
            int b = InputChecker.InputInt();

            var pos = (a > 0 && b > 0) ? 2 : ((a > 0 || b > 0) ? 1 : 0);

            Printing.PrintIntLine(pos);
        }
    }
}
