namespace IntermediateExercises.GeometryB
{
    using Base;

    public class PyramidShape
    {
        public static void Pyramid()
        {
            Printing.PrintLine("Input a string and it will make a triangle");

            string word = InputChecker.InputStringOnlyLetters();
            int position = word.Length / 2;
            int height = word.Length / 2 + 1;
            int amount = 1;

            Console.WriteLine();

            if (word.Length % 2 == 0)
            {
                word += " ";
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < position; j++)
                {
                    Printing.Print(" ");
                }

                Printing.PrintLine(word.Substring(position, amount));
                position--;
                amount += 2;
            }
        }
    }
}
