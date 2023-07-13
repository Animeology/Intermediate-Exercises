namespace IntermediateExercises.FlowControlsB
{
    public class InfiniteDivide
    {
        public static void KeepOnDividing()
        {
            Console.WriteLine("Input two numbers and it would keep dividing until the first input is 0");

            int num1;
            int num2;

            do
            {
                num1 = Convert.ToInt32(Console.ReadLine());

                if (num1 != 0)
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("You cannot divide by 0");
                    }
                    else
                    {
                        int result = num1 / num2;
                        Console.WriteLine("The division is {0}", result);
                        Console.WriteLine("The rest is {0}", num1 % num2);
                    }
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }

            } while (num1 != 0);
        }
    }
}
