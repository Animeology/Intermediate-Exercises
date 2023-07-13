namespace IntermediateExercises.FlowControlsC
{
    public class WhileLoopForChange
    {
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
    }
}
