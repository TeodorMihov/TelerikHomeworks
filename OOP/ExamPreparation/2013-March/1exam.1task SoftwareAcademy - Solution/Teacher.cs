namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Teacher : ITeacher
    {
        private string name;

        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Teacher`s name cannot be null or empty");
                }
                
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            var selectCourses = this.courses.Select(cur => cur.Name);

            output.AppendFormat("Teacher: Name={0}", this.name);

            if (this.courses.Count > 0)
            {
                output.AppendFormat("; Courses=[{0}]", string.Join(", ", selectCourses));
            }
            return output.ToString();
        }
    }
}
