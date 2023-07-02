using System.Text;
using System.Data.SQLite;
using System.Data;

class IntermediateExercises
{
    public static void Main(string[] args)
    {
        //CreateDatabase();
        //ReadingListFromDB();

        //InvertedFile();
        //ReadBMP();
        //BMPImage();
        //ReadID3();

        //ReverseFile();
        //ChangeLowerToUpperFile();
        //CountWordsInFile();
        //SearchLinesInFile();

        //PalindromeRecursion();
        //ReverseRecursion();
        //FactorialRecursion();
        //FibonacciRecursion();
        //PowerRecursion();
        //MultiplyRecursion();

        //AnimalEating();
        //CarDriving();
        //InheritanceObjects();
        //PhotoBookTest();
        //StudentTeacherTest();
        //PersonNameConAndDes();
        //PersonName();

        //Palindrome();
        //MaxMinArray();
        //MainParameterCalculatorReturn(args);
        //MainParameterCalculator(args);
        //CheckNumber();
        //CheckAlphabet();

        //SwapParameters();
        //CalculateRefDouble();
        //CalculateDouble();
        //AddArray();
        //FormatText();
        //SpaceFunction();

        //Title();
        //PowerOperation();
        //GreatestValue();
        //ReverseString();
        //Add();
        //ModifyCharacter();

        //Circumference();
        //MathematicalStatistics();
        //ArrayStruct();
        //TwoDeeCharArray();
        //TwoDeeArrays();
        //BubbleSort();
        //SearchPosAndNeg();
        //SearchEvenNums();
        //SearchArray();
        //ReverseArray();

        //HexadecimalTable();
        //BinaryHexadecimal();
        //PrimeFactors();

        //Pyramid();
        //Parallelogram();
        //HollowRectangle();
        //HollowSquare();

        //NestedConditionalOp();
        //ConditionalOp();
        //MoneyChange();
        //Alphabet();

        //MathStatistics();

        //RepetitiveStructures();
        //InfiniteDivide();
        //AccessControl();
        //MultipleThreesAndFives();

    }

    static void CreateDatabase()
    {
        string dbFileName = "out.sqlite";

        if (!File.Exists(dbFileName))
        {
            SQLiteConnection.CreateFile(dbFileName);
        }

        using (SQLiteConnection connection = new SQLiteConnection(
            "Data Source=" + dbFileName + ";Version=3;"
        ))
        {
            connection.Open();

            string personTable = "create table if not exists person (name varchar(20), age int)";
            using (SQLiteCommand command = new SQLiteCommand(personTable, connection))
            {
                command.ExecuteNonQuery();
            }

            string teacherTable = "create table if not exists teacher (name varchar(20))";
            using (SQLiteCommand command = new SQLiteCommand(teacherTable, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public class PersonDB
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    static void ReadingListFromDB()
    {
        string dbFileName = "persons.sqlite";
        List<PersonDB> persons = new List<PersonDB>();

        using (SQLiteConnection connection = new SQLiteConnection(
            "Data Source=" + dbFileName + ";Version=3;"
        ))
        {
            connection.Open();

            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = "select name, age from \"person\"";
                command.CommandType = CommandType.Text;

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    persons.Add(new PersonDB()
                    {
                        Name = reader["name"].ToString()!,
                        Age = int.Parse(reader["age"].ToString()!)
                    }
                    );
                }
            }
        }

        foreach (var person in persons)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }

    static void InvertedFile()
    {
        string inputFileName = "app.exe";
        string outputFileName = "app.inv";

        using (FileStream file = File.OpenRead(inputFileName))
        {
            long size = file.Length;
            byte[] data = new byte[size];

            file.Read(data, 0, (int)size);

            using (FileStream outFile = File.OpenWrite(outputFileName))
            {
                for (long i = 0; i < size; i++)
                {
                    outFile.WriteByte(data[i]);
                }
            }
        }
    }

    static void ReadBMP()
    {
        string fileName = "logo.bmp";

        using (FileStream file = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite))
        {
            char b1 = (char)file.ReadByte();
            char b2 = (char)file.ReadByte();

            file.Seek(0, SeekOrigin.Begin);
            file.WriteByte(Convert.ToByte('B'));
            file.WriteByte(Convert.ToByte('M'));
        }
    }

    static void BMPImage()
    {
        string fileName = "logo.bmp";
        int size = 54;
        int width, height;
        byte[] data = new byte[size];

        using (FileStream file = File.OpenRead(fileName))
        {
            file.Read(data, 0, size);
        }

        width = data[18]
                + (data[19] * 256)
                + (data[20] * 256 * 256)
                + (data[21] * 256 * 256 * 256);

        height = data[22]
                + (data[23] * 256)
                + (data[24] * 256 * 256)
                + (data[25] * 256 * 256 * 256);


        Console.WriteLine("{0}x{1}", width, height);
    }

    static void ReadID3()
    {
        byte idTagLength = 3;
        byte titleLength = 30;
        byte artistLength = 30;
        byte albumLength = 30;
        byte yearLength = 4;
        byte commentLength = 30;
        byte genreLength = 1;

        byte[] id = new byte[idTagLength];
        byte[] title = new byte[titleLength];
        byte[] artist = new byte[artistLength];
        byte[] album = new byte[albumLength];
        byte[] year = new byte[yearLength];
        byte[] comment = new byte[commentLength];
        byte[] genre = new byte[genreLength];

        string ToString()
        {
            StringBuilder tag = new StringBuilder();

            tag.AppendLine(Encoding.Default.GetString(id));
            tag.AppendLine(Encoding.Default.GetString(title));
            tag.AppendLine(Encoding.Default.GetString(artist));
            tag.AppendLine(Encoding.Default.GetString(album));
            tag.AppendLine(Encoding.Default.GetString(year));
            tag.AppendLine(Encoding.Default.GetString(comment));
            tag.AppendLine(Encoding.Default.GetString(genre));

            return tag.ToString();
        }


        string fileName = "input.mp3";
        using (FileStream file = File.OpenRead(fileName))
        {
            file.Seek(-128, SeekOrigin.End);

            file.Read(id, 0, id.Length);
            file.Read(title, 0, title.Length);
            file.Read(artist, 0, artist.Length);
            file.Read(album, 0, album.Length);
            file.Read(year, 0, year.Length);
            file.Read(comment, 0, comment.Length);
            file.Read(genre, 0, genre.Length);
        }

        if (Encoding.Default.GetString(id).Equals("TAG"))
        {
            Console.WriteLine(ToString());
        }
    }

    static void ReverseFile()
    {
        Console.WriteLine("Creates a new file that reverse every word in the input.txt file");
        string file = "input.txt";
        string newFile = "input.inv";

        using (StreamReader sr = new StreamReader(file))
        {
            using (StreamWriter sw = new StreamWriter(newFile))
            {
                string[] lines = File.ReadAllLines(file);

                for (int i = lines.Length - 1; i >= 0; i--)
                {
                    sw.WriteLine(lines[i]);
                }
            }
        }
    }

    static void ChangeLowerToUpperFile()
    {
        Console.WriteLine("Creates a new file that uppercase every word in the input.txt file");
        string file = "input.txt";
        string newFile = "output.txt";

        using (StreamReader sr = new StreamReader(file))
        {
            using (StreamWriter sw = new StreamWriter(newFile))
            {
                string line;
                while ((line = sr.ReadLine()!) != null)
                {
                    string upperLines = line.ToUpper();

                    sw.WriteLine(upperLines);
                }
            }
        }
    }

    static void CountWordsInFile()
    {
        Console.WriteLine("Tt will count the number of words in the input.txt file");
        string file = "input.txt";
        int count = 0;

        using (StreamReader sr = new StreamReader(file))
        {
            string line;
            do
            {
                line = sr.ReadLine()!;

                if (line != null)
                {
                    count += line.Split(' ').Length;
                }
            } while (line != null);
        }


        Console.WriteLine(count);
    }

    static void SearchLinesInFile()
    {
        Console.WriteLine("Search for the word in the file and it will print out the line that the word is in");
        string file = "input.txt";
        string[] lines = File.ReadAllLines(file);

        bool exit = false;
        do
        {
            string text = Console.ReadLine()!;

            if (text != string.Empty)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(text))
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
            }
            else
            {
                exit = true;
            }
        } while (!exit);
    }

    static void PalindromeRecursion()
    {
        Console.WriteLine("Input a string and it will check if it is a palindrome by recursion");
        string text = Console.ReadLine()!;

        Console.WriteLine(Palindrome(text));

        bool Palindrome(string text)
        {
            if (text.Length <= 1)
            {
                return true;
            }
            else
            {
                if (text[0] != text[text.Length - 1])
                {
                    return false;
                }
                else
                {
                    return Palindrome(text.Substring(1, text.Length - 2));
                }
            }
        }
    }

    static void ReverseRecursion()
    {
        Console.WriteLine("Input a string and it will be reverse by recursion");
        string text = Console.ReadLine()!;

        Console.WriteLine(Reverse(text));

        string Reverse(string text)
        {
            if (text.Length <= 1)
            {
                return text;
            }
            else
            {
                char firstLetter = text[0];
                string restOfWord = text.Substring(1);
                return Reverse(restOfWord) + firstLetter;
            }
        }
    }

    static void FactorialRecursion()
    {
        Console.WriteLine("A Factorial that starts with the user input");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Factorial(num));

        int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
    }

    static void FibonacciRecursion()
    {
        Console.WriteLine("A Fibonacci that starts with the user input");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Fibonacci(num));

        int Fibonacci(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }
    }

    static void PowerRecursion()
    {
        Console.WriteLine("Input two numbers and it will do the power of the number using recursion");

        int num = Convert.ToInt32(Console.ReadLine());
        int power = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Power(num, power));

        int Power(int num, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                return num * Power(num, power - 1);
            }
        }
    }

    static void MultiplyRecursion()
    {
        Console.WriteLine("Input 2 numbers and it will multiply it by recursion");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Multiply(x, y));

        int Multiply(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return x + Multiply(x, y - 1);
            }
        }
    }

    static void AnimalEating()
    {
        Dog dog = new Dog();
        string name = Console.ReadLine()!;
        dog.SetName(name);
        Console.WriteLine(dog.GetName());
        dog.Eat();
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    public abstract class Animal
    {
        string m_name = string.Empty;

        public void SetName(string name)
        {
            m_name = name;
        }
        public string GetName()
        {
            return m_name;
        }
        public abstract void Eat();
    }

    static void CarDriving()
    {
        Car2 car = new Car2(0);

        Console.WriteLine("Put how much gasoline you want to put into the car");
        int gasoline = Convert.ToInt32(Console.ReadLine());
        // int gasoline = int.Parse(Console.ReadLine()) also works

        if (car.Refuel(gasoline))
        {
            car.Drive();
        }
    }

    public class Car2 : IVehicle
    {
        public int Gasoline { get; set; }

        public Car2(int gasoline)
        {
            Gasoline = gasoline;
        }

        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Ran out of gasoline");
            }
        }

        public bool Refuel(int gasoline)
        {
            Gasoline += gasoline;
            return true;
        }
    }

    public interface IVehicle
    {
        void Drive();
        bool Refuel(int gasoline);
    }

    public class Location
    {
        double x;
        double y;
    }

    public class Shape : Location
    {
        protected Location location;

        public override string ToString()
        {
            return string.Empty;
        }

        public double Area()
        {
            return 0.0;
        }

        public double Perimeter()
        {
            return 0.0;
        }
    }

    public class Rectangle : Shape
    {
        protected double side1;
        protected double side2;
    }

    public class Circle : Shape
    {
        protected double radius;
    }

    static void InheritanceObjects()
    {
        Console.WriteLine("Input 3 names and it will store in the array and displays it");

        int count = 3;

        Person[] persons = new Person[count];

        for (int i = 0; i < count; i++)
        {
            if (i == 0)
            {
                persons[i] = new Teacher(Console.ReadLine()!);
            }
            else
            {
                persons[i] = new Student(Console.ReadLine()!);
            }

        }

        for (int i = 0; i < count; i++)
        {
            if (i == 0)
            {
                ((Teacher)persons[i]).Explain();
            }
            else
            {
                ((Student)persons[i]).Study();
            }
        }
    }

    static void PhotoBookTest()
    {
        PhotoBook album1 = new PhotoBook();
        Console.WriteLine(album1.GetNumberPages());

        PhotoBook album2 = new PhotoBook(24);
        Console.WriteLine(album2.GetNumberPages());

        BigPhotoBook album3 = new BigPhotoBook();
        Console.WriteLine(album3.GetNumberPages());
    }

    public class PhotoBook
    {
        protected int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int pages)
        {
            numPages = pages;
            // this.numPages = pages also works
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }

    static void StudentTeacherTest()
    {
        Person person = new Person("Joseph");
        person.Greet();

        Student student = new Student("Joseph");
        student.SetAge(25);
        student.Greet();
        student.ShowAge();
        student.Study();

        Teacher teacher = new Teacher("Tanner");
        teacher.SetAge(40);
        teacher.Greet();
        teacher.Explain();
    }

    public class Person
    {
        public string m_name { get; set; }
        public int m_age { get; set; }

        public Person(string name)
        {
            m_name = name;
        }

        public override string ToString()
        {
            return "Hello!, My name is " + m_name;
        }

        ~Person()
        {
            m_name = string.Empty;
        }

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            m_age = age;
        }
    }

    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            m_name = name;
        }

        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", m_age);
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            m_name = name;
        }

        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }

    static void PersonNameConAndDes()
    {
        Console.WriteLine("Input 3 names and it will store in the array and displays it");

        int count = 3;

        Person[] persons = new Person[count];

        for (int i = 0; i < count; i++)
        {
            persons[i] = new Person(Console.ReadLine()!);
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }

    }

    static void PersonName()
    {
        Console.WriteLine("Input 3 names and it will store in the array and displays it");

        int count = 3;

        Person[] persons = new Person[count];

        for (int i = 0; i < count; i++)
        {
            persons[i] = new Person(Console.ReadLine()!);
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
    }

    static void Palindrome()
    {
        Console.WriteLine("Input a string and it will check if it is a palindrome");

        string text = Console.ReadLine()!;
        string reverse = string.Empty;

        Console.WriteLine(IsPalindrome(text));

        bool IsPalindrome(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse += text[i];
            }
            if (text == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    static void MaxMinArray()
    {
        Console.WriteLine("Input 5 numbers into the array and it will find the max and min number in the array");

        int count = 5;
        int[] arr = new int[count];

        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < count; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        FindMinMax(arr, max, min);

        void FindMinMax(int[] arr, int max, int min)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
        }
    }

    static int MainParameterCalculatorReturn(string[] args)
    {
        Console.WriteLine("Input an equation and it will calculate");
        Console.WriteLine("Accepts only \"+\", \"-\", \"*\" \"x\" \"X\", \"/\" ");

        int x = Convert.ToInt32(args[0]);
        char op = Convert.ToChar(args[1]);
        int y = Convert.ToInt32(args[2]);

        if (args.Length != 0)
        {
            return 1;
        }

        if (args[1] != "+" || args[1] != "-" || args[1] != "*" || args[1] != "/")
        {
            return 2;
        }

        try
        {
            Convert.ToInt32(x);
            Convert.ToInt32(y);
        }
        catch
        {
            return 3;
        }

        switch (op)
        {
            case '+':
                Console.Write(x + y);
                break;
            case '-':
                Console.Write(x - y);
                break;
            case '*':
            case 'x':
            case 'X':
                Console.Write(x * y);
                break;
            case '/':
                Console.Write(x / y);
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }

        return 0;
    }

    static void MainParameterCalculator(string[] args)
    {
        Console.WriteLine("Input an equation and it will calculate");
        Console.WriteLine("Accepts only \"+\", \"-\", \"*\" \"x\" \"X\", \"/\" ");

        int x = Convert.ToInt32(args[0]);
        char op = Convert.ToChar(args[1]);
        int y = Convert.ToInt32(args[2]);

        switch (op)
        {
            case '+':
                Console.Write(x + y);
                break;
            case '-':
                Console.Write(x - y);
                break;
            case '*':
            case 'x':
            case 'X':
                Console.Write(x * y);
                break;
            case '/':
                Console.Write(x / y);
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }

    static void CheckNumber()
    {
        Console.WriteLine("Input a string to check if the whole string is only alphabetic");

        string text = Console.ReadLine()!;

        Console.WriteLine(IsNumber(text));

        bool IsNumber(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] < '1' || text[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }

    static void CheckAlphabet()
    {
        Console.WriteLine("Input a string to check if the whole string is only alphabetic");

        string text = Console.ReadLine()!;

        Console.WriteLine(IsAlphabetic(text));

        bool IsAlphabetic(string text)
        {
            text = text.ToUpper();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] < 'A' || text[i] > 'Z')
                {
                    return false;
                }
            }

            return true;
        }
    }

    static void SwapParameters()
    {
        Console.WriteLine("Input two numbers and it will swap places.");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Swap(ref x, ref y);

        void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("{0} {1}", x, y);
        }
    }

    static void CalculateRefDouble()
    {
        Console.WriteLine("Input a number and it will print the number doubled");

        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Double(ref num));

        int Double(ref int num)
        {
            int result = num * 2;

            return result;
        }

    }

    static void CalculateDouble()
    {
        Console.WriteLine("Input a number and it will print the number doubled");

        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Double(num));

        int Double(int num)
        {
            int result = num * 2;

            return result;
        }
    }

    static void AddArray()
    {
        Console.WriteLine("Insert 5 numbers to add and it will add them together in the same array");

        int count = 5;
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Add(arr);

        void Add(int[] arr)
        {
            int total = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            Console.WriteLine(total);
        }
    }

    static void FormatText()
    {
        Console.WriteLine("Input a word and it will in the center and underlined");

        string text = Console.ReadLine()!;

        WriteCenteredUnderline(text);

        void WriteCenteredUnderline(string text)
        {
            double x = 35;
            double y = 5;

            Console.SetCursorPosition((int)x, (int)y);
            Console.Write(text);

            Console.WriteLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.SetCursorPosition((int)x + i, (int)y + 1);
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }

    static void SpaceFunction()
    {
        Console.WriteLine("Input a sentence and it will count the total spaces in the sentence");

        string text = Console.ReadLine()!;

        Console.WriteLine(CountSpaces(text));

        int CountSpaces(string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    count++;
                }
            }

            return count;
        }
    }

    static void Title()
    {
        Console.WriteLine("Input a string and it will print it like a title");

        string text = Console.ReadLine()!;

        WriteTitle(text);

        void WriteTitle(string text)
        {
            text = text.ToUpper();

            for (int i = 0; i < text.Length * 2 - 1; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();

            for (int i = 0; i < text.Length * 2 - 1; i++)
            {
                Console.Write(' ');
            }
            Console.WriteLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < text.Length * 2 - 1; i++)
            {
                Console.Write(' ');
            }
            Console.WriteLine();

            for (int i = 0; i < text.Length * 2 - 1; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }

    static void PowerOperation()
    {
        Console.WriteLine("Input 2 numbers and the it will calculate the first number of the power of the second number");

        double num = Convert.ToInt32(Console.ReadLine());
        double power = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Power(num, power));

        double Power(double num, double power)
        {
            double result = Math.Pow(num, power);

            return result;
        }
    }

    static void GreatestValue()
    {
        Console.WriteLine("Request 5 numbers and it will display the highest number");

        int count = 5;
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(SearchGreatestValue(arr));

        int SearchGreatestValue(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }

    static void ReverseString()
    {
        Console.WriteLine("Input a text and it will be reverse");

        string text = Console.ReadLine()!;

        InvertString(text);

        void InvertString(string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }

    static void Add()
    {
        Console.WriteLine("Input a number and it will add of them");

        string text = Console.ReadLine()!;

        Console.WriteLine(AddDigits(text));

        int AddDigits(string text)
        {
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                sum += Convert.ToInt32(text.Substring(i, 1));
            }

            return sum;
        }
    }

    static void ModifyCharacter()
    {
        Console.WriteLine("Input a text, position of the lettter you want to change and input a new character");

        string text = Console.ReadLine()!;
        int position = Convert.ToInt32(Console.ReadLine());
        char letter = Convert.ToChar(Console.Read());

        Console.WriteLine(ChangeLetter(text, position, letter));

        string ChangeLetter(string text, int position, char letter)
        {
            text = text.Remove(position, 1);
            text = text.Insert(position, letter.ToString());

            return text;
        }
    }

    static void Circumference()
    {
        Console.WriteLine("Draw the circumference of a oval");

        double x = 0;
        double y = 0;

        for (int i = 0; i < 360; i++)
        {
            double radians = i * Math.PI / 180.0;

            x = 35 + 8 * Math.Cos(radians);
            y = 10 + 8 * Math.Sin(radians);

            Console.SetCursorPosition((int)x, (int)y);
            Console.Write("X");
        }

        Console.SetCursorPosition(1, 20);

    }

    static void MathematicalStatistics()
    {
        int choice = 0;
        int total = 1000;
        int count = 0;

        float sum = 0;
        float mean = 0;
        float max = int.MinValue;
        float min = int.MaxValue;

        float num;

        float[] arr = new float[total];

        void Menu()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Show");
            Console.WriteLine("3. Search");
            Console.WriteLine("4. Statistics");
            Console.WriteLine("5. Exit");
            Console.Write("Enter a option (1-5): ");

            choice = Convert.ToInt32(Console.ReadLine());
        }


        while (choice != 5 && count < 1000)
        {
            Menu();

            switch (choice)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Show();
                    break;
                case 3:
                    Search();
                    break;
                case 4:
                    Statistics();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Not an option!");
                    Menu();
                    break;
            }
        }

        void Add()
        {
            if (count < total)
            {
                num = Convert.ToSingle(Console.ReadLine());
                arr[count] = num;

                sum += arr[count];


                if (arr[count] > max)
                {
                    max = arr[count];
                }

                if (arr[count] < min)
                {
                    min = arr[count];
                }
                count++;
                mean = sum / count;
            }
            else
            {
                Console.WriteLine("Database is full");
            }
        }

        void Show()
        {
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No data available");
            }
        }

        void Search()
        {
            float searchedNum = Convert.ToInt32(Console.ReadLine());

            bool foundNum = false;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] == searchedNum)
                {
                    foundNum = true;
                }
            }
            if (foundNum)
            {
                Console.WriteLine("{0} exists in the array", searchedNum);
            }
            else
            {
                Console.WriteLine("{0} doesn't exist in the array", searchedNum);
            }
        }

        void Statistics()
        {
            Console.WriteLine("Total data: {0}", count);
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Average: {0}", mean);
            Console.WriteLine("Min value: {0}", min);
            Console.WriteLine("Max value: {0}", max);
        }
    }

    public struct Car
    {
        public string model;
        public int year;

        public void SetCar()
        {
            model = Console.ReadLine()!;
            year = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void ArrayStruct()
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

    static void TwoDeeCharArray()
    {
        Console.WriteLine("Draws a 20(row) by 70(col) of 'X'");

        int rows = 20;
        int cols = 70;
        char x = 'X';

        char[,] arr = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = x;
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void TwoDeeArrays()
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

    static void BubbleSort()
    {
        Console.WriteLine("Input 10 numbers and it will order them using Bubble Sort");

        int count = 10;
        int[] nums = new int[count];

        for (int i = 0; i < count; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int temp;
        for (int i = 0; i <= nums.Length - 2; i++)
        {
            for (int j = 0; j <= nums.Length - 2; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    temp = nums[j + 1];
                    nums[j + 1] = nums[j];
                    nums[j] = temp;
                }
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i]);
        }

    }

    static void SearchPosAndNeg()
    {
        Console.WriteLine("Input 10 numbers and it will display the mean for positive numbers and negative numbers");

        int count = 10;
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int meanPos = 0;
        int meanNeg = 0;
        int posNums = 0;
        int negNums = 0;
        int totalPos = 0;
        int totalNeg = 0;

        for (int i = 0; i < count; i++)
        {
            if (arr[i] > 0)
            {
                totalPos = totalPos + arr[i];

                posNums++;

                meanPos = totalPos / posNums;

            }

            if (arr[i] < 0)
            {
                totalNeg = totalNeg + arr[i];

                negNums++;

                meanNeg = totalNeg / negNums;

            }
        }

        Console.WriteLine("Average numbers negative is {0}", meanNeg);
        Console.WriteLine("Average numbers positive is {0}", meanPos);
    }

    static void SearchEvenNums()
    {
        Console.WriteLine("Input 10 numbers and it will display only the even numbers");

        int count = 10;
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Even Numbers:");

        for (int i = 0; i < count; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    static void SearchArray()
    {
        Console.WriteLine("Input 5 numbers and input the number to search through the array");

        int count = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("What number do you want to search?");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int j = 0; j < count; j++)
        {
            if (arr[j] == y)
            {
                Console.WriteLine("The number {0} exists", y);
                break;
            }
            else
            {
                Console.WriteLine("The number {0} doesn't exist", y);
                break;
            }
        }
    }

    static void ReverseArray()
    {
        Console.WriteLine("Input 5 numbers and it will print it in reverse array");

        int max = 5;
        int[] nums = new int[max];

        for (int i = 0; i < max; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Reverse(nums);

        for (int i = 0; i < max; i++)
        {
            Console.Write("{0} ", nums[i]);
        }
    }

    static void HexadecimalTable()
    {
        Console.WriteLine("Prints a hexadecimal table");

        int max = 255;

        for (int i = 0; i <= max; i++)
        {
            if (i < 16)
            {
                Console.Write("0");
            }

            Console.Write("{0} ", Convert.ToString(i, 16));

            if (i % 16 == 15)
            {
                Console.WriteLine();
            }
        }
    }

    static void BinaryHexadecimal()
    {
        Console.WriteLine("Input a number and it will convert it to binary and hexadecimal");

        int num;

        do
        {
            num = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(num, 2);
            string hexadecimal = Convert.ToString(num, 16);

            if (num != 0)
            {
                Console.WriteLine("Binary: " + binary);
                Console.WriteLine("Hexadecimal: " + hexadecimal);
            }
        } while (num != 0);
    }

    static void PrimeFactors()
    {
        Console.WriteLine("Input a integer and it will display the product of its prime factor");

        int num = Convert.ToInt32(Console.ReadLine());
        int divisor = 2;

        while (num > 1)
        {
            while (num % divisor == 0)
            {
                Console.Write(divisor + "x");
                num = num / divisor;
            }
            divisor++;
        }
        Console.WriteLine(1);
    }

    static void Pyramid()
    {
        Console.WriteLine("Input a string and it will make a triangle");

        string word = Console.ReadLine()!;
        int position = word.Length / 2;
        int height = word.Length / 2 + 1;
        int amount = 1;

        Console.WriteLine();

        if (word.Length % 2 == 0)
        {
            word += " ";
        }

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < position; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(word.Substring(position, amount));
            position--;
            amount += 2;
        }

    }

    static void Parallelogram()
    {
        Console.WriteLine("Input the width, height, and symbol to display a parallelogram");
        int width = Convert.ToInt32(Console.ReadLine());
        int height = Convert.ToInt32(Console.ReadLine());
        char symbol = Convert.ToChar(Console.ReadLine()!);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();

            for (int k = 0; k <= i; k++)
            {
                Console.Write(" ");
            }
        }
    }

    static void HollowRectangle()
    {
        Console.WriteLine("Input a symbol and the width/height to display a hollow rectangle");

        char symbol = Convert.ToChar(Console.ReadLine()!);
        int width = Convert.ToInt32(Console.ReadLine());
        int height = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < width; i++)
        {
            Console.Write(symbol);
        }

        Console.WriteLine();

        for (int i = 0; i < height; i++)
        {
            Console.Write(symbol);

            for (int j = 0; j < width - 2; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(symbol);
        }

        for (int i = 0; i < width; i++)
        {
            Console.Write(symbol);
        }

        Console.WriteLine();

    }

    static void HollowSquare()
    {
        Console.WriteLine("Input a symbol and the width/height to display a hollow square");

        char symbol = Convert.ToChar(Console.ReadLine()!);
        int size = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            Console.Write(symbol);
        }

        Console.WriteLine();

        for (int i = 0; i < size - 2; i++)
        {
            Console.Write(symbol);

            for (int j = 0; j < size - 2; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(symbol);
        }

        for (int i = 0; i < size; i++)
        {
            Console.Write(symbol);
        }

        Console.WriteLine();
    }

    static void NestedConditionalOp()
    {
        Console.WriteLine("Input two numbers and it will check how many of them are positive");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        var pos = (a > 0 && b > 0) ? 2 : ((a > 0 || b > 0) ? 1 : 0);

        Console.WriteLine(pos);
    }

    static void ConditionalOp()
    {
        Console.WriteLine("Input two numbers and it will output whether they are positive");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        var num1Pos = a > 0 ? "A is positive" : "A is negative";
        var num2Pos = b > 0 ? "B is positive" : "B is negative";
        var bothPos = a > 0 && b > 0 ? "Both are positive" : "One of them is negative or Both are negative";

        Console.WriteLine(num1Pos);
        Console.WriteLine(num2Pos);
        Console.WriteLine(bothPos);

    }

    static void MoneyChange()
    {
        Console.WriteLine("Request the total money in the cash register and the purchase value");

        int total = Convert.ToInt32(Console.ReadLine());
        int value = Convert.ToInt32(Console.ReadLine());

        int change = total - value;

        while (change >= 50)
        {
            Console.WriteLine("50 ");
            change -= 50;
        }

        while (change >= 20)
        {
            Console.WriteLine("20 ");
            change -= 20;
        }

        while (change >= 10)
        {
            Console.WriteLine("10 ");
            change -= 10;
        }

        while (change >= 5)
        {
            Console.WriteLine("5 ");
            change -= 5;
        }

        while (change >= 2)
        {
            Console.WriteLine("2 ");
            change -= 2;
        }

        while (change >= 1)
        {
            Console.WriteLine("1 ");
            change -= 1;
        }

    }

    static void Alphabet()
    {
        Console.WriteLine("Displays the Alphabet");

        for (char c = 'A'; c < 'Z'; c++)
        {
            Console.Write("{0} ", c);
        }
    }

    static void MathStatistics()
    {
        Console.WriteLine("Input 5 numbers and it will calculate the sum, mean, the max, and the minimum number");

        int totalNums = 5;
        int[] nums = new int[totalNums];

        for (int i = 0; i < totalNums; i++)
        {
            nums[i] = int.Parse(Console.ReadLine()!);
        }

        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < totalNums; i++)
        {
            sum += nums[i];

            if (nums[i] > max)
            {
                max = nums[i];
            }

            if (nums[i] < min)
            {
                min = nums[i];
            }

        }

        int mean = sum / totalNums;

        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Mean: {0}", mean);
        Console.WriteLine("Max: {0}", max);
        Console.WriteLine("Min: {0}", min);
    }

    static void RepetitiveStructures()
    {
        Console.WriteLine("Input two numbers and it will show the range between these two numbers included the two inputs");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        // For Loop
        for (int i = x; i <= y; i++)
        {
            Console.Write("{0} ", i);
        }

        Console.WriteLine();

        // While loop
        int loop = x;
        while (loop <= y)
        {
            Console.Write("{0} ", loop);
            loop++;
        }

        Console.WriteLine();

        // Do While loop
        int j = x;
        do
        {
            Console.Write("{0} ", j);
            j++;
        } while (j <= y);
    }

    static void InfiniteDivide()
    {
        Console.WriteLine("Input two numbers and it would keep dividing until the first input is 0");

        int num1;
        int num2;

        do
        {
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 != 0)
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("You cannot divide by 0");
                }
                else
                {
                    int result = num1 / num2;
                    Console.WriteLine("The division is {0}", result);
                    Console.WriteLine("The rest is {0}", num1 % num2);
                }
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }

        } while (num1 != 0);
    }

    static void AccessControl()
    {
        Console.WriteLine("Try to login with the username and password");

        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine()!;

            Console.Write("Password: ");
            string password = Console.ReadLine()!;

            if (username == "12" && password == "1234")
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("Login Failed!");
            }
            attempts++;

            if (attempts == 3)
            {
                Console.WriteLine("You used all your attempts!");
            }
        }
    }

    static void MultipleThreesAndFives()
    {
        Console.WriteLine("Prints out numbers ranged from 1 to 500 that are multiples of 3 and 5");

        int x = 1;
        int y = 500;

        for (int i = x; i <= y; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}