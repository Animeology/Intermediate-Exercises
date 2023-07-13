namespace IntermediateExercises.DataTypesB
{
    public class BinaryHexa
    {
        public static void BinaryHexadecimal()
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
    }
}
