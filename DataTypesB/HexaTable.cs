namespace IntermediateExercises.DataTypesB
{
    public class HexaTable
    {
        public static void HexadecimalTable()
        {
            Console.WriteLine("Prints a hexadecimal table");

            int max = 255;

            for (int i = 0; i <= max; i++)
            {
                if (i < 16)
                {
                    Console.Write("0");
                }

                Console.Write("{0} ", Convert.ToString(i, 16));

                if (i % 16 == 15)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
