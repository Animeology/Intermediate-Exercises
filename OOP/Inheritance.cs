namespace IntermediateExercises.OOP
{
    using Structures;
    using Base;

    public class Inheritance
    {
        public static void InheritanceObjects()
        {
            Printing.PrintLine("Input 3 names and it will store in the array and displays it");

            int count = 3;

            Person[] persons = new Person[count];

            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                {
                    string name = InputChecker.InputStringOnlyLetters();
                    persons[i] = new Teacher(name);
                }
                else
                {
                    string name = InputChecker.InputStringOnlyLetters();
                    persons[i] = new Student(name);
                }

            }

            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain();
                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
        }
    }
}
