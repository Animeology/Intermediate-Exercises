using IntermediateExercises.Structures;

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
