namespace IntermediateExercises.FlowControlsC
{
    public class NestedConditional
    {
        public static void NestedConditionalOp()
        {
            Console.WriteLine("Input two numbers and it will check how many of them are positive");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            var pos = (a > 0 && b > 0) ? 2 : ((a > 0 || b > 0) ? 1 : 0);

            Console.WriteLine(pos);
        }
    }
}
