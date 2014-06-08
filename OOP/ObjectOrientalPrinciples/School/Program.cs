namespace School
{
    using System;
    class Program
    {
        static void Main()
        {
            Student student = new Student("Nerd","12345");

            Teacher teacher = new Teacher("Shibanqk");

            SchoolClass math = new SchoolClass("math");
            math.AddStudent(student);
            math.AddComment("asdf");
            Console.WriteLine(math);
        }
    }
}
