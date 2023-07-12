using IntermediateExercises.Structures;

namespace IntermediateExercises.Arrays
{
    public class StructureArray
    {
        public static void ArrayStruct()
        {
            Console.WriteLine("Input 3 car models and the year of production for each and it will display them in order of production");

            int totalCars = 3;
            Car[] cars = new Car[totalCars];

            for (int i = 0; i < totalCars; i++)
            {
                cars[i].SetCar();
            }

            for (int i = 0; i < totalCars - 2; i++)
            {
                Car temp;
                if (cars[i].year > cars[i + 1].year)
                {
                    temp = cars[i];
                    cars[i] = cars[i + 1];
                    cars[i + 1] = temp;
                }
            }

            for (int i = 0; i < totalCars; i++)
            {
                Console.WriteLine("Model: {0}, Year of production: {1}", cars[i].model, cars[i].year);
            }
        }
    }
}
