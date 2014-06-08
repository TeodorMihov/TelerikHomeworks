namespace SoftwareAcademy
{
    using System;
    using System.Text;
    class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            :base(name,teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Lab cannot be null or empty");
                }
                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());

            output.AppendFormat("; Lab={0}", this.Lab);

            return output.ToString();
        }
    }
}
