﻿namespace IntermediateExercises
{
    using Arithmetic;
    using Arrays;
    using BinaryFiles;

    class IntermediateExercises
    {
        public static void Main(string[] args)
        {
            // Arithmetic
            FunctionCalculator.CalculateFunction();

            // Arrays
            ReverseArray.ReversingTheArray();
            SearchArray.SearchCertainArray();
            SearchEvenArray.SearchEvenNums();
            SearchPostiveNegativeArray.SearchPosAndNeg();
            BubbleSortArray.BubbleSort();
            TwoDeeArray.TwoDeeArrays();
            TwoDeeCharArray.DrawTwoDeeCharArray();
            StructureArray.ArrayStruct();
            MathStatisticsArray.MathematicalStatistics();
            Circumference.CalculateCircumference();

            // Binary Files
            ReadIDEFile.ReadID3();
            ReadBMPFile.ReadBMP();
            BMPImageFile.BMPImage();
            InvertedBinaryFile.InvertedFile();
        }
    }
}
