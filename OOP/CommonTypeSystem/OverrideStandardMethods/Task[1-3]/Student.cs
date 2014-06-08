namespace OverrideStandardMethods.Task1_3
{
    using System;
    using System.Text;

    public enum Speciality { ComputerSystem, ComputerTechnology, Law, Medicine }

    public enum University { SofiaUniversity, TechnicalUniversity, BurgasFreeUniversity, UniversityOfEconomics }

    public enum Faculty { FMI, EE, E, CS, EMC }

    public class Student : ICloneable, IComparable<Student>
    {
        private Speciality speciality;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, string ssn, string mobilePhone, string eMail,
            string course, Speciality speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get;  private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public string SSN { get; private set; }

        public string MobilePhone { get; private set; }

        public string EMail { get; private set; }

        public string Course { get; private set; }

        public Speciality Speciality
        {
            get { return this.speciality; }
            set { this.speciality = value; }
        }

        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public override string ToString()
        {
            StringBuilder printStudent = new StringBuilder();

            printStudent.Append(string.Format("Student full name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            printStudent.Append(Environment.NewLine);
            printStudent.Append(string.Format("SSN: {0}", this.SSN));
            printStudent.Append(Environment.NewLine);
            printStudent.Append(string.Format("Mobile phone: {0}", this.MobilePhone));
            printStudent.Append(Environment.NewLine);
            printStudent.Append(string.Format("E-mail: {0}", this.EMail));
            printStudent.Append(Environment.NewLine);
            printStudent.Append(string.Format("Course: {0}", this.Course));
            printStudent.Append(Environment.NewLine);
            printStudent.Append(string.Format("Speciality: {0}", this.Speciality));
            printStudent.Append(Environment.NewLine);
            printStudent.Append(string.Format("University: {0}", this.University));
            printStudent.Append(Environment.NewLine);
            printStudent.Append(string.Format("Faculty: {0}", this.Faculty));

            return printStudent.ToString();
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;

            if (student == null)
            {
                throw new ArgumentException("Input object should be a student type");
            }

            if (this.LastName == student.LastName && this.SSN == student.SSN)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int uniqueNumber = 0;

            foreach (var ch in this.FirstName)
            {
                uniqueNumber += ch;
            }

            foreach (var ch in this.SSN)
            {
                uniqueNumber += ch;
            }

            return uniqueNumber;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            if (Equals(firstStudent, secondStudent))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (!Equals(firstStudent, secondStudent))
            {
                return true;
            }
            return false;
        }

        // second task: Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
        public object Clone()
        {
            Student studentCopy = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.MobilePhone,
                this.EMail, this.Course, this.Speciality, this.University, this.Faculty);

            return studentCopy;
        }

        // third task: Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

        public int CompareTo(Student other)
        {
            if (string.Compare(this.FirstName, other.FirstName) == 0 && (this.SSN == other.SSN))
            {
                return 0;
            }

            else if (string.Compare(this.FirstName, other.FirstName) == -1)
            {
                return -1;
            }

            return 1;
        }
    }
}
