namespace School
{
    using System.Collections.Generic;
    public class Student : Human, ICommentable
    {
        public Student(string name, string uniqueClassNumber)
            :base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public string UniqueClassNumber { get; private set; }

        public List<string> comments { get; private set; }

        public void AddComment(string comment)
        {
            comments.Add(comment);
        }

        public override string ToString()
        {
            return string.Format("Student name: {0}\nStudent class number: {1}", this.Name, this.UniqueClassNumber);
        }
    }
}
