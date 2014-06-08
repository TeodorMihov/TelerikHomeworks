namespace HumanStudentWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName)
        {
            this.FirstName = firstName;
        }

        public Human(string firstName, string lastName)
            :this(firstName)
        {
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = LastName;
            }
        }
    }
}
