namespace Intermediate_Exercises
{
    public class OOP
    {
        public void AnimalEating()
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


        public void CarDriving()
        {
            Car car = new Car(0);

            Console.WriteLine("Put how much gasoline you want to put into the car");
            int gasoline = Convert.ToInt32(Console.ReadLine());
            // int gasoline = int.Parse(Console.ReadLine()) also works

            if (car.Refuel(gasoline))
            {
                car.Drive();
            }
        }

        public class Car : IVehicle
        {
            public int Gasoline { get; set; }

            public Car(int gasoline)
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
            protected Location? location;

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

        public void InheritanceObjects()
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

        public void PhotoBookTest()
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

        public void StudentTeacherTest()
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

        public void PersonNameConAndDes()
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

        public void PersonName()
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
    }
}
