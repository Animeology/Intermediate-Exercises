namespace IntermediateExercises.Arrays
{
    public class TwoDeeArray
    {
        public static void TwoDeeArrays()
        {
            Console.WriteLine("Input 10 grades and it will split it into 2 groups of 5 and calculate the average of each group");

            int groupBy = 5;
            int[,] allGrades = new int[groupBy, groupBy];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < groupBy; j++)
                {
                    allGrades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int group1Total = 0;
            for (int i = 0; i < groupBy; i++)
            {
                group1Total += allGrades[0, i];
            }
            Console.WriteLine("Average for group 1 is {0}", group1Total / groupBy);

            int group2Total = 0;
            for (int i = 0; i < groupBy; i++)
            {
                group2Total += allGrades[1, i];
            }
            Console.WriteLine("Average for group 2 is {0}", group2Total / groupBy);
        }
    }
}
