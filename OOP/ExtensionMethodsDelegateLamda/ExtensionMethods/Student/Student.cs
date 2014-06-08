namespace ExtensionMethods.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Student
    {
        private List<int> marks;

        private Group group;

        public Student(string firstName, string lastName)
            : this(firstName, lastName, 0, null, "", "", null, 0, null)
        {

        }

        public Student(string firstName, string lastName, int age)
            : this(firstName, lastName, age, null, "", "", null, 0, null)
        {

        }

        public Student(string firstName, string lastName, int age, string facultetNumber)
            : this(firstName, lastName, age, facultetNumber, "", "", null, 0, null)
        {

        }

        public Student(string firstName, string lastName, int age, string fn, string tel, string email, List<int> marks, int groupNumber, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultetNumber = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.Group = group;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultetNumber { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                if (value == null)
                {
                    marks = new List<int>();
                }
                else
                {
                    this.marks = value;
                }
            }
        }
        public int GroupNumber { get; set; }

        public Group Group 
        { 
            get
            {
                return this.group;
            }
            set
            {
                if (value == null)
                {
                    group = new Group(0, "");
                }
                else
                {
                    this.group = value;
                }
            }
        }

        public bool FirstNameBeforeLast
        {
            get
            {
                for (int letter = 0; letter < Math.Min(FirstName.Length, LastName.Length); letter++)
                {
                    if (FirstName[letter] == LastName[letter])
                    {
                        continue;
                    }
                    else if (FirstName[letter] < LastName[letter])
                    {
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder printStudents = new StringBuilder();
            {
                printStudents.Append("First name:");
                printStudents.Append(FirstName);
                printStudents.Append("\nLast name:");
                printStudents.Append(LastName);
                printStudents.Append(Environment.NewLine);
            }
            return printStudents.ToString();
        }
    }
}
