namespace IntermediateExercises.FlowControlsC
{
    public class ConditionalOperation
    {
        public static void ConditionalOp()
        {
            Console.WriteLine("Input two numbers and it will output whether they are positive");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            var num1Pos = a > 0 ? "A is positive" : "A is negative";
            var num2Pos = b > 0 ? "B is positive" : "B is negative";
            var bothPos = a > 0 && b > 0 ? "Both are positive" : "One of them is negative or Both are negative";

            Console.WriteLine(num1Pos);
            Console.WriteLine(num2Pos);
            Console.WriteLine(bothPos);
        }
    }
}
