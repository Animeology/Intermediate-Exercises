namespace IntermediateExercises
{
    using Arithmetic;
    using Arrays;
    using BinaryFiles;
    using DataTypesB;
    using FlowControlsA;
    using FlowControlsB;
    using FlowControlsC;
    using FunctionsA;

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

            // Data Types B
            HexaTable.HexadecimalTable();
            BinaryHexa.BinaryHexadecimal();
            PrimeFactor.PrimeFactors();

            // Flow Controls A
            MathematicalStatistics.MathStatistics();

            // Flow Controls B
            RepeatingStructures.RepetitiveStructures();
            InfiniteDivide.KeepOnDividing();
            AccessControl.Login();
            Multiples.MultipleThreesAndFives();

            // Flow Controls C
            WhileLoopForChange.MoneyChange();
            Alphabet.DisplayAlphabet();
            ConditionalOperation.ConditionalOp();
            NestedConditional.NestedConditionalOp();

            // Functions A
            CountSpaces.SpaceFunction();
            FormatText.Formatting();
            CalculateDouble.CalculateDoubles();
            CalculateUsingReference.CalculateRefDouble();
            SwapParameter.SwapParameters();
            AddingIndexInArray.AddArray();
        }
    }
}
