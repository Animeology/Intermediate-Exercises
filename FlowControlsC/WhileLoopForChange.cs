namespace IntermediateExercises.FlowControlsC
{
    using Base;

    public class WhileLoopForChange
    {
        public static void MoneyChange()
        {
            Printing.PrintLine("Request the total money in the cash register and the purchase value");

            int total = InputChecker.InputInt();
            int value = InputChecker.InputInt();

            int change = total - value;

            while (change >= 50)
            {
                Printing.PrintLine("50 ");
                change -= 50;
            }

            while (change >= 20)
            {
                Printing.PrintLine("20 ");
                change -= 20;
            }

            while (change >= 10)
            {
                Printing.PrintLine("10 ");
                change -= 10;
            }

            while (change >= 5)
            {
                Printing.PrintLine("5 ");
                change -= 5;
            }

            while (change >= 2)
            {
                Printing.PrintLine("2 ");
                change -= 2;
            }

            while (change >= 1)
            {
                Printing.PrintLine("1 ");
                change -= 1;
            }
        }
    }
}
