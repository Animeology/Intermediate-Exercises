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
    using FunctionsB;
    using FunctionsC;
    using GeometryA;
    using GeometryB;
    using SQLite;
    using OOP;
    using Recursion;
    using TextFilesA;
    using TextFilesB;
    using GenericCollections;
    using Base;

    class IntermediateExercises
    {
        public static void Main(string[] args)
        {
            //// Arithmetic
            //FunctionCalculator.CalculateFunction();

            //// Arrays
            //ReverseArray.ReversingTheArray();
            //SearchArray.SearchCertainArray();
            //SearchEvenArray.SearchEvenNums();
            //SearchPostiveNegativeArray.SearchPosAndNeg();
            //BubbleSortArray.BubbleSort();
            //TwoDeeArray.TwoDeeArrays();
            //TwoDeeCharArray.DrawTwoDeeCharArray();
            //StructureArray.ArrayStruct();
            //MathStatisticsArray.MathematicalStatistics();
            //Circumference.CalculateCircumference();

            //// Binary Files
            //ReadIDEFile.ReadID3();
            //ReadBMPFile.ReadBMP();
            //BMPImageFile.BMPImage();
            //InvertedBinaryFile.InvertedFile();

            //// Data Types B
            //HexaTable.HexadecimalTable();
            //BinaryHexa.BinaryHexadecimal();
            //PrimeFactor.PrimeFactors();

            //// Flow Controls A
            //MathematicalStatistics.MathStatistics();

            //// Flow Controls B
            //RepeatingStructures.RepetitiveStructures();
            //InfiniteDivide.KeepOnDividing();
            //AccessControl.Login();
            //Multiples.MultipleThreesAndFives();

            //// Flow Controls C
            //WhileLoopForChange.MoneyChange();
            //Alphabet.DisplayAlphabet();
            //ConditionalOperation.ConditionalOp();
            //NestedConditional.NestedConditionalOp();

            //// Functions A
            //CountSpaces.SpaceFunction();
            //FormatText.Formatting();
            //CalculateDouble.CalculateDoubles();
            //CalculateUsingReference.CalculateRefDouble();
            //SwapParameter.SwapParameters();
            //AddingIndexInArray.AddArray();

            //// Functions B
            //ModifyCharacters.ModifyCharacter();
            //AddFunction.Add();
            //ReverseString.StringReverse();
            //SearchMaxValue.GreatestValue();
            //PowerOperation.PowerOp();
            //TitleFormat.Title();

            //// Functions C
            //AlphabetChecker.CheckAlphabet();
            //NumberChecker.CheckNumber();
            //MainFunctionCalculator.MainParameterCalculator(args);
            //MainFunctionCalculatorWithReturn.MainParameterCalculatorReturn(args);
            //MaxToMinArray.MaxMinArray();
            //PalindromeFunction.Palindrome();

            //// Geometry A
            //TriangleShape.Triangle();
            //NorthEastTriangle.NETriangle();
            //RightTriangle.RightAlignTriangle();
            //Graphics.GraphicFunction();

            //// Geometry B
            //HollowSquareShape.HollowSquare();
            //HollowRectShape.HollowRectangle();
            //ParallelogramShape.Parallelogram();
            //PyramidShape.Pyramid();

            //// OOP
            //Animal.AnimalEating();
            //DrivingCar.CarDriving();
            //Inheritance.InheritanceObjects();
            //PersonDisplay.PersonNameConAndDes();
            //PersonName.PersonNameInArray();
            //PhotobookTest.PhotoBookTest();
            //StudentAndTeacher.StudentTeacherTest();

            //// Recursion
            //Factorial.FactorialRecursion();
            //Fibonacci.FibonacciRecursion();
            //Multiply.MultiplyRecursion();
            //Palindrome.PalindromeRecursion();
            //Power.PowerRecursion();
            //Reverse.ReverseRecursion();

            //// SQLite
            //ReadingTheDatabase.ReadingListFromDB();
            //CreateDatabase.CreationDB();
            //CreateMemoryDatabase.CreateMemoryDB();
            //CRUD.CRUDMenu();

            //// Text Files A
            //SearchLines.SearchLinesInFile();

            //// Text Files B
            //ReverseFile.ReverseInFile();
            //LowerToUpperFile.ChangeLowerToUpperFile();
            //WordCounter.CountWordsInFile();

            // Generic Collections
            //ArrayPersonList list = new ArrayPersonList();
            //list.PrintPerson();

            //QueuePosition queue = new QueuePosition(10);
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.DeQueue();
            //Printing.PrintIntLine(queue.DeQueue());

            //ObjectQueue queue = new ObjectQueue();
            //queue.PrintPersonInQueue();

            StackArrays stack = new StackArrays(10);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int val1 = stack.Pop();
            int val2 = stack.Pop();
            Printing.PrintIntLine(val1);
            Printing.PrintIntLine(val2);
        }
    }
}
