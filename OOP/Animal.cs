namespace IntermediateExercises.OOP
{
    using Base;
    using Structures;

    public class Animal
    {
        public static void AnimalEating()
        {
            Dog dog = new Dog();
            string name = InputChecker.InputStringOnlyLetters();

            dog.SetName(name);

            Printing.PrintLine(dog.GetName());
            dog.Eat();
        }
    }
}
