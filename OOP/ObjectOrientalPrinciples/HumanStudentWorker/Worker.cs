namespace HumanStudentWorker
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, uint weekSalary, uint workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public uint WeekSalary { get; set; }

        public uint WorkHoursPerDay { get; set; }

        public uint MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 7 );
        }

        public override string ToString()
        {
            return string.Format("{0} {1}: {2} lv per hour", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
