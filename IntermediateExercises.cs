using Intermediate_Exercises;

class IntermediateExercises
{
    public static void Main(string[] args)
    {
        Arithmetic arithmetic = new Arithmetic();
        arithmetic.CalculateFunction();

        Arrays arrays = new Arrays();
        arrays.Circumference();
        arrays.MathematicalStatistics();
        arrays.ArrayStruct();
        arrays.TwoDeeArrays();
        arrays.TwoDeeCharArray();
        arrays.BubbleSort();
        arrays.SearchPosAndNeg();
        arrays.SearchEvenNums();
        arrays.SearchArray();
        arrays.ReverseArray();

        BinaryFiles binaryFiles = new BinaryFiles();
        binaryFiles.InvertedFile();
        binaryFiles.ReadBMP();
        binaryFiles.BMPImage();
        binaryFiles.ReadID3();

        DataTypesB dataType = new DataTypesB();
        dataType.HexadecimalTable();
        dataType.BinaryHexadecimal();
        dataType.PrimeFactors();

        FlowControlsA flowControlsA = new FlowControlsA();
        flowControlsA.MathStatistics();

        FlowControlsB flowControlsB = new FlowControlsB();
        flowControlsB.RepetitiveStructures();
        flowControlsB.InfiniteDivide();
        flowControlsB.AccessControl();
        flowControlsB.MultipleThreesAndFives();

        FlowControlsC flowControlsC = new FlowControlsC();
        flowControlsC.NestedConditionalOp();
        flowControlsC.ConditionalOp();
        flowControlsC.MoneyChange();
        flowControlsC.Alphabet();

        FunctionsA functionsA = new FunctionsA();
        functionsA.SwapParameters();
        functionsA.CalculateRefDouble();
        functionsA.CalculateDouble();
        functionsA.AddArray();
        functionsA.FormatText();
        functionsA.SpaceFunction();

        FunctionsB functionsB = new FunctionsB();
        functionsB.Title();
        functionsB.PowerOperation();
        functionsB.GreatestValue();
        functionsB.ReverseString();
        functionsB.Add();
        functionsB.ModifyCharacter();

        FunctionsC functionsC = new FunctionsC();
        functionsC.Palindrome();
        functionsC.MaxMinArray();
        functionsC.MainParameterCalculatorReturn(args);
        functionsC.MainParameterCalculator(args);
        functionsC.CheckNumber();
        functionsC.CheckAlphabet();

        GeometryA geomA = new GeometryA();
        geomA.GraphicFunction();
        geomA.RightAlignTriangle();
        geomA.NETriangle();
        geomA.Triangle();

        GeometryB geomB = new GeometryB();
        geomB.Pyramid();
        geomB.Parallelogram();
        geomB.HollowRectangle();
        geomB.HollowSquare();

        OOP objectP = new OOP();
        objectP.AnimalEating();
        objectP.CarDriving();
        objectP.InheritanceObjects();
        objectP.PhotoBookTest();
        objectP.StudentTeacherTest();
        objectP.PersonNameConAndDes();
        objectP.PersonName();
    }
}
