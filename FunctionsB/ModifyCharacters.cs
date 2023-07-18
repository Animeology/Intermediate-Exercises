namespace IntermediateExercises.FunctionsB
{
    using Base;

    public class ModifyCharacters
    {
        public static void ModifyCharacter()
        {
            Printing.PrintLine("Input a text, position of the lettter you want to change and input a new character");

            string text = InputChecker.InputStringOnlyLetters();
            int position = InputChecker.InputInt();
            char letter = InputChecker.InputChar();

            Printing.PrintLine(ChangeLetter(text, position, letter));

            string ChangeLetter(string text, int position, char letter)
            {
                text = text.Remove(position, 1);
                text = text.Insert(position, letter.ToString());

                return text;
            }
        }
    }
}
