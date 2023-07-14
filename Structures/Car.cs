namespace IntermediateExercises.Structures
{
    public struct Car : IVehicle
    {
        public string model;
        public int year;
        public int Gasoline { get; set; }

        public void SetCar()
        {
            model = Console.ReadLine()!;
            year = Convert.ToInt32(Console.ReadLine());
        }

        public Car(int gasoline)
        {
            Gasoline = gasoline;
        }

        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Ran out of gasoline");
            }
        }

        public bool Refuel(int gasoline)
        {
            Gasoline += gasoline;
            return true;
        }
    }
}
