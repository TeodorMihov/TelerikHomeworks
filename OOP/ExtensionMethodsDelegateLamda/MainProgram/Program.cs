namespace MainProgram
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using ExtensionMethods;
    using ExtensionMethods.Students;

    class Program
    {
        static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.Append("Some ");
            test.Append("text ");
            test.Append("to ");
            test.Append("test.");

            Console.WriteLine(test.Substring(2, 7));

            // task for students
            List<Student> studentsArray = new List<Student>()
            {
                new Student("Geogri", "Ivanov"),
                new Student("Ivan", "Simeonov"),
                new Student("Zlatan", "Ivanov"),
                new Student("Asen", "Grigorov",21),
                new Student("John", "Doe", 18),
                new Student("Jane", "Doe", 24),
                new Student("Michael", "Johnson", 54, "230206","12783612", "aaaaaaaa@abv.bg", new List<int>{2,3,6},2, new Group(2,"Eng")),
                new Student("Bob", "Branklin", 25),
                new Student("Bart", "Beklina", 26, "230312", "0112783612", "aaaaaaaa@abva.bg", new List<int>{2,6,4},2,new Group(2,"Math")),
                new Student("Clay", "Woodly", 17),
                new Student("Steven", "Abbel", 22, "230406", "0212783612", "aaaaaaaa@abv.bg", new List<int>{2,2},1,new Group(1,"Math")),
            };
            // task 3 - unfinished
             var firstNameIsSmaller = studentsArray.FindAll(st => st.FirstNameBeforeLast);

            // task 4 
            var Between18And24 = studentsArray.FindAll(st => st.Age >= 18 && st.Age >= 24);
            Console.WriteLine("All students between 18 adn 24 years:");
            Between18And24.ForEach(Console.WriteLine);

            // task 5
            var sortByFullName = studentsArray.OrderByDescending(st => st.FirstName).ThenBy(st => st.LastName);
            Console.WriteLine("Students are sorted by descending order:");
            sortByFullName.ToList().ForEach(Console.WriteLine);

            // task 6 
            var ageDevisibleBy7and3 = studentsArray.FindAll(st => st.Age % 7 == 0 && st.Age % 3 == 0);
            Console.WriteLine("Students with age devisible by 3 and 7:");
            ageDevisibleBy7and3.ForEach(Console.WriteLine);

            // task 7 
            //ExtensionMethods.Timer.delegateTimer newTimer = new ExtensionMethods.Timer.delegateTimer(ExtensionMethods.Timer.Interval);
            //newTimer(3);
            //newTimer(1);

            //task 9
            var secondGroupStudents = studentsArray.FindAll(st => st.GroupNumber == 2);
            Console.WriteLine("Students from second group:");
            secondGroupStudents.ForEach(Console.WriteLine);

            // task 10
            studentsArray.StudentsFromSecondGroup();

            // task 11
            var abvEmail = studentsArray.Where(st => st.Email.Contains("abv.bg"));
            Console.WriteLine("Students with abv.bg emails:");
            abvEmail.ToList().ForEach(Console.WriteLine);

            //task 12 
            var sofiaNumber = studentsArray.Where(st => st.Tel.StartsWith("02"));
            Console.WriteLine("Students with phone number from Sf:");
            sofiaNumber.ToList().ForEach(Console.WriteLine);

            //task 13
            var exelentStudents = studentsArray.Where(st => st.Marks.Contains(6))
                .Select(st => new
                {
                    FullName = string.Format("{0} {1}", st.FirstName, st.LastName),
                    Marks = string.Join(",", st.Marks)
                });

            // task 14 
            var marksTwo = studentsArray.FindAll(st => st.Marks.Count == 2);
            Console.WriteLine("Students with marks F:");
            marksTwo.ToList().ForEach(Console.WriteLine);

            // task 15
            var enrolledIn2006 = studentsArray.Where(st => 
            {   
                if (st.FacultetNumber != null)
                {
                    var digit = st.FacultetNumber.Substring(4);
                    if (digit.IndexOf("06") != -1)
                    {
                        return true;
                    }
                }
                
                return false;
            });
            Console.WriteLine("Students that enrolled in 2006:");
            enrolledIn2006.ToList().ForEach(Console.WriteLine);

            // task 16
            //List<Student> test = new List<Student>();
            //var mathDep =
            //    from arr in studentsArray
            //    join st in test on arr.Group.DepartmentName 
            //    select new {arr.FirstName, arr.LastName}

            // task 17
            var longestFirstName = studentsArray.LongestFirstName();
            Console.WriteLine("The student with longest name is: {0}",longestFirstName);

            // task 18
            var groupNameStudents = studentsArray.Where(st => st.Group.GroupNumber != 0);
            Console.WriteLine("Students with group name:");
            groupNameStudents.ToList().ForEach(Console.WriteLine);
        }
    }
}
