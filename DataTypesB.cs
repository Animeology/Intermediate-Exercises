namespace Intermediate_Exercises
{
    public class DataTypesB
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

        public void BinaryHexadecimal()
        {
            Console.WriteLine("Input a number and it will convert it to binary and hexadecimal");

            int num;

            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                string binary = Convert.ToString(num, 2);
                string hexadecimal = Convert.ToString(num, 16);

                if (num != 0)
                {
                    Console.WriteLine("Binary: " + binary);
                    Console.WriteLine("Hexadecimal: " + hexadecimal);
                }
            } while (num != 0);
        }

        public void PrimeFactors()
        {
            Console.WriteLine("Input a integer and it will display the product of its prime factor");

            int num = Convert.ToInt32(Console.ReadLine());
            int divisor = 2;

            while (num > 1)
            {
                while (num % divisor == 0)
                {
                    Console.Write(divisor + "x");
                    num = num / divisor;
                }
                divisor++;
            }
            Console.WriteLine(1);
        }
    }
}
