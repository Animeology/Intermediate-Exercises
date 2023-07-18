namespace IntermediateExercises.OOP
{
    using Structures;

    public class Animal
    {
        public static void AnimalEating()
        {
            Dog dog = new Dog();
            string name = Console.ReadLine()!;

            dog.SetName(name);

            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }
}
