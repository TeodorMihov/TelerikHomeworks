namespace OverrideStandardMethods.Task4
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name)
            : this(name, null)
        {

        }

        public override string ToString()
        {
            StringBuilder printPerson = new StringBuilder();

            printPerson.Append("First name:");
            printPerson.AppendLine(this.name);

            if (this.age == null)
            {
                printPerson.AppendLine("Age is not specified");
            }
            else
            {
                printPerson.Append("Age:");
                printPerson.AppendLine(this.age.ToString());
            }

            return printPerson.ToString();
        }
    }
}
