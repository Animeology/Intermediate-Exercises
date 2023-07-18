namespace IntermediateExercises.DataTypesB
{
    using Base;

    public class HexaTable
    {
        public static void HexadecimalTable()
        {
            Printing.PrintLine("Prints a hexadecimal table");

            int max = 255;

            for (int i = 0; i <= max; i++)
            {
                if (i < 16)
                {
                    Printing.Print("0");
                }

                Printing.PrintLine($"{Convert.ToString(i, 16)} ");

                if (i % 16 == 15)
                {
                    Printing.NewLine();
                }
            }
        }
    }
}
