namespace Animals
{
    using System;
    public class Animal : ISound
    {
        private string name;
        private string sex;
        private sbyte age;

        public Animal(string name, string sex, sbyte age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Sex
        {
            get { return this.name; }
            private set { this.sex = value; }
        }

        public sbyte Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public virtual void ProduceSound()
        {
            Console.WriteLine("brrr");
        }

        public static int AvgAge(Animal[] animals)
        {
            int averageSum = 0;
            foreach (var animal in animals)
            {
                averageSum += animal.Age;
            }

            return averageSum / animals.Length;
        }
    }
}
