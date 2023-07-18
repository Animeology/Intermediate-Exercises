namespace IntermediateExercises.DataTypesB
{
    using Base;

    public class BinaryHexa
    {
        public static void BinaryHexadecimal()
        {
            Printing.PrintLine("Input a number and it will convert it to binary and hexadecimal");

            int num;

            do
            {
                num = InputChecker.InputInt();
                string binary = Convert.ToString(num, 2);
                string hexadecimal = Convert.ToString(num, 16);

                if (num != 0)
                {
                    Printing.PrintLine($"Binary: {binary}");
                    Printing.PrintLine($"Hexadecimal: {hexadecimal}");
                }
            } while (num != 0);
        }
    }
}
