namespace IntermediateExercises.OOP
{
    using Base;
    using Structures;

    public class DrivingCar
    {
        public static void CarDriving()
        {
            Car car = new Car(0);

            Printing.PrintLine("Put how much gasoline you want to put into the car");
            int gasoline = InputChecker.InputInt();
            // int gasoline = int.Parse(Console.ReadLine()) also works

            if (car.Refuel(gasoline))
            {
                car.Drive();
            }
        }
    }
}
