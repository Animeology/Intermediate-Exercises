namespace IntermediateExercises.OOP
{
    using Structures;

    public class DrivingCar
    {
        public void CarDriving()
        {
            Car car = new Car(0);

            Console.WriteLine("Put how much gasoline you want to put into the car");
            int gasoline = Convert.ToInt32(Console.ReadLine());
            // int gasoline = int.Parse(Console.ReadLine()) also works

            if (car.Refuel(gasoline))
            {
                car.Drive();
            }
        }
    }
}
