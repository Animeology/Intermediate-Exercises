namespace IntermediateExercises.Structures
{
    public struct Car
    {
        public string model;
        public int year;

        public void SetCar()
        {
            model = Console.ReadLine()!;
            year = Convert.ToInt32(Console.ReadLine());
        }
    }
}
