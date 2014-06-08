namespace School
{
    using System.Collections.Generic;
    public class Teacher : Human, ICommentable
    {
        public Teacher(string name)
            : base(name)
        {
        }

        public List<string> comments { get; private set; }

        public void AddComment(string comment)
        {
            comments.Add(comment);
        }

        public override string ToString()
        {
            return string.Format("Teacher name: {0}",this.Name);
        }
    }
}
