namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*Define abstract class Human with first name and last name. 
    Define new class Student which is derived from Human and has new field – grade. 
    Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending order. 
    Merge the lists and sort them by first name and last name.*/

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Gencho", 4),
                new Student("Stanka", 6),
                new Student("Pesho", 5),
            };

            var sortStudentsByGrade = students.OrderBy(st => st.Grade);
            sortStudentsByGrade.ToList().ForEach(Console.WriteLine);

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Worker1", "Joro", 200, 8),
                new Worker("Worker2", "Ivo", 320, 8),
                new Worker("Worker3", "Teo", 500, 8),
                new Worker("Worker4", "Pumo", 452, 8),
                new Worker("Worker5", "CMoK", 5042, 8),
                new Worker("Worker6", "CMoTaH", 5182, 8),
            };
            Console.WriteLine(new string('-', 30));

            var sortStudentsByMoneyPerHour = workers.OrderByDescending(st => st.MoneyPerHour());
            sortStudentsByMoneyPerHour.ToList().ForEach(Console.WriteLine);
            Console.WriteLine(new string('-',30));

            var merged = students.Concat<Human>(workers).ToList();
            var sortMergedHumans = merged.OrderBy(sr => sr.FirstName);
            sortMergedHumans.ToList().ForEach(Console.WriteLine);
        }
    }
}
