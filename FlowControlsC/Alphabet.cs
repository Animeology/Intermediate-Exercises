namespace IntermediateExercises.FlowControlsC
{
    using Base;

    public class Alphabet
    {
        public static void DisplayAlphabet()
        {
            Printing.PrintLine("Displays the Alphabet");

            for (char alpha = 'A'; alpha < 'Z'; alpha++)
            {
                Printing.Print($"{alpha} ");
            }
        }
    }
}
