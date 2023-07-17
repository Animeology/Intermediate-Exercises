namespace IntermediateExercises.Arrays
{
    using Base;
    using Structures;

    public class StructureArray
    {
        public static void ArrayStruct()
        {
            Printing.PrintLine("Input 3 car models and the year of production for each and it will display them in order of production");

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
                Printing.PrintLine($"Model: {cars[i].model}, Year of production: {cars[i].year}");
            }
        }
    }
}
