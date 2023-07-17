namespace IntermediateExercises.Arrays
{
    using Base;

    public class TwoDeeArray
    {
        public static void TwoDeeArrays()
        {
            Printing.PrintLine("Input 10 grades and it will split it into 2 groups of 5 and calculate the average of each group");

            int groupBy = 5;
            int[,] allGrades = new int[groupBy, groupBy];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < groupBy; j++)
                {
                    allGrades[i, j] = InputChecker.InputInt();
                }
            }

            int groupOneTotal = 0;
            for (int i = 0; i < groupBy; i++)
            {
                groupOneTotal += allGrades[0, i];
            }
            float groupOneAverage = groupOneTotal / groupBy;
            Printing.PrintLine($"Average for group 1 is {groupOneAverage}");

            int groupTwoTotal = 0;
            for (int i = 0; i < groupBy; i++)
            {
                groupTwoTotal += allGrades[1, i];
            }
            float groupTwoAverage = groupTwoTotal / groupBy;
            Printing.PrintLine($"Average for group 2 is {groupOneAverage}");
        }
    }
}
