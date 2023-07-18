namespace IntermediateExercises.FunctionsB
{
    using Base;

    public class AddFunction
    {
        public static void Add()
        {
            Printing.PrintLine("Input a number and it will add to the current sum");

            string text = InputChecker.InputStringOnlyNumbers();

            Printing.PrintIntLine(AddDigits(text));

            int AddDigits(string text)
            {
                int sum = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    sum += Convert.ToInt32(text.Substring(i, 1));
                }

                return sum;
            }
        }
    }
}
