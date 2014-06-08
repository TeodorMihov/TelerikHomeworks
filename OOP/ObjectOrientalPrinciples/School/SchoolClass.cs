namespace School
{
    using System.Collections.Generic;
    using System.Text;
    public class SchoolClass : ICommentable
    {
        public SchoolClass(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
            this.comments = new List<string>();
        }

        public string Name { get; private set; }

        public List<Student> students { get; private set; }

        public List<Teacher> teachers { get; private set; }

        public List<string> comments { get; private set; }

        public void AddStudent(Student student)
        {

            students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddComment(string comment)
        {
            comments.Add(comment);
        }

        public override string ToString()
        {
            StringBuilder classInfo = new StringBuilder();
            
            foreach (var student in students)
            {
                classInfo.Append(student);
            }
            
            foreach (var teacher in teachers)
            {
                classInfo.Append(teacher);
            }

            return classInfo.ToString();
        }
    }
}
