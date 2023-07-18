namespace IntermediateExercises.OOP
{
    using Structures;

    public class StudentAndTeacher
    {
        public static void StudentTeacherTest()
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
    }
}
