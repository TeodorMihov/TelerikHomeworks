using System;
namespace Animals
{
    class Program
    {
        static void Main()
        {
            Dog kuche = new Dog("Kudjo", "Male", 12);
            kuche.ProduceSound();

            Dog[] dogs = new Dog[]
        {
            new Dog("Dog1", "Male", 12),
            new Dog("Dog2", "Male", 5 ),
            new Dog("Dog3", "Male", 5 ),
            new Dog("Dog4", "Male", 6 ),
            new Dog("Dog5", "Male", 8),
        };
            int avgYearsDogs = Animal.AvgAge(dogs);

            Tomcat[] cats = new Tomcat[]
        {
            new Tomcat("cat1", "Male", 12),
            new Tomcat("cat2", "Male", 11),
            new Tomcat("cat3", "Male", 2),
            new Tomcat("cat4", "Male", 5),
            new Tomcat("cat5", "Male", 7),
            new Tomcat("cat6", "Male", 18),
        };
            int avg = Animal.AvgAge(cats);

            Console.WriteLine("Dog average age: {0}",avgYearsDogs);
        }
    }
}
