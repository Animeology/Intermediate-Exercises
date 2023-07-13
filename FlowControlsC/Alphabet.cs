namespace IntermediateExercises.FlowControlsC
{
    public class Alphabet
    {
        public static void DisplayAlphabet()
        {
            Console.WriteLine("Displays the Alphabet");

            for (char c = 'A'; c < 'Z'; c++)
            {
                Console.Write("{0} ", c);
            }
        }
    }
}
