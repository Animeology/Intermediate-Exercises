namespace Intermediate_Exercises
{
    public class FlowControlsC
    {
        public static void NestedConditionalOp()
        {
            Console.WriteLine("Input two numbers and it will check how many of them are positive");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            var pos = (a > 0 && b > 0) ? 2 : ((a > 0 || b > 0) ? 1 : 0);

            Console.WriteLine(pos);
        }

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

        public static void MoneyChange()
        {
            Console.WriteLine("Request the total money in the cash register and the purchase value");

            int total = Convert.ToInt32(Console.ReadLine());
            int value = Convert.ToInt32(Console.ReadLine());

            int change = total - value;

            while (change >= 50)
            {
                Console.WriteLine("50 ");
                change -= 50;
            }

            while (change >= 20)
            {
                Console.WriteLine("20 ");
                change -= 20;
            }

            while (change >= 10)
            {
                Console.WriteLine("10 ");
                change -= 10;
            }

            while (change >= 5)
            {
                Console.WriteLine("5 ");
                change -= 5;
            }

            while (change >= 2)
            {
                Console.WriteLine("2 ");
                change -= 2;
            }

            while (change >= 1)
            {
                Console.WriteLine("1 ");
                change -= 1;
            }

        }

        public static void Alphabet()
        {
            Console.WriteLine("Displays the Alphabet");

            for (char c = 'A'; c < 'Z'; c++)
            {
                Console.Write("{0} ", c);
            }
        }

    }
}
