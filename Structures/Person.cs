namespace IntermediateExercises.Structures
{
    public class Person
    {
        public string m_name { get; set; }
        public int m_age { get; set; }

        public Person(string name)
        {
            m_name = name;
        }

        public Person() { }

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
}
