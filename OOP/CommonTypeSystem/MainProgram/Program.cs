namespace MainProgram
{
    using OverrideStandardMethods.Task1_3;
    using OverrideStandardMethods.Task4;
    using OverrideStandardMethods.Task5_6;
    using System;

    class Program
    {
        static void Main()
        {
            #region tasks[1-3]
            Student firstStudent = new Student("Pesho", "Petrov", "Ivanov", "20012", "08888888", "pesho@abv,bg", "OOP",
                Speciality.ComputerSystem, University.BurgasFreeUniversity, Faculty.CS);

            Student secondStudent = new Student("Toshko", "Todorov", "Yordanov", "20013", "08881674", "ToshkoMashinata@abv.bg", "C#",
                Speciality.ComputerTechnology, University.SofiaUniversity, Faculty.EE);

            Student thirdStudent = new Student("Kalistrati", "Carvulanov", "Popishki", "20013", "09123848", "kalniq@gmail.com", "suspended",
                Speciality.Medicine, University.UniversityOfEconomics, Faculty.FMI);

            Console.WriteLine(firstStudent);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(firstStudent.Equals(secondStudent));
            Console.WriteLine(firstStudent.Equals(firstStudent));
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(firstStudent.GetHashCode());
            Console.WriteLine(new string('-', 30));

            Student newStudent = firstStudent.Clone() as Student;
            Console.WriteLine(newStudent);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(newStudent.CompareTo(secondStudent));
            Console.WriteLine(new string('-', 30));
            #endregion

            #region task4
            Person testPerson = new Person("BaiIvan",82);
            Console.WriteLine(testPerson);
            Person testPersonWithoutAge = new Person("BaiPenio");
            Console.WriteLine(testPersonWithoutAge);

            #endregion

            #region task5-6
            BitArray64 number = new BitArray64(18);
            foreach (var digit in number)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
            Console.WriteLine(number.GetHashCode());
            #endregion

            
        }
    }
}
