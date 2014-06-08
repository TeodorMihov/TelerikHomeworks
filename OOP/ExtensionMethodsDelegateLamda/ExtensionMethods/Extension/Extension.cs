namespace ExtensionMethods
{
    using ExtensionMethods.Students;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Extension
    {
        public static string Substring(this StringBuilder str, int index, int length)
        {
            if (index < 0 || index > str.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            if (index + length > str.Length)
            {
                throw new IndexOutOfRangeException("Length is too big");
            }

            return str.ToString().Substring(index, length);
        }

        public static decimal Sum<T>(this IEnumerable<T> collection)
            where T : struct
        {
            decimal result = 0;
            foreach (dynamic number in collection)
            {
                result += number;
            }

            return result;
        }

        public static decimal Product<T>(this IEnumerable<T> collection)
            where T : struct
        {
            decimal product = 1;
            foreach (dynamic number in collection)
            {
                product *= number;
            }

            return product;
        }

        public static decimal MinNumber<T>(this IEnumerable<T> collection)
            where T : struct
        {
            decimal minNumber = decimal.MaxValue;

            foreach (dynamic number in collection)
            {
                if (minNumber > number)
                {
                    minNumber = number;
                }
            }
            return minNumber;
        }

        public static decimal MaxNumber<T>(this IEnumerable<T> collection)
            where T : struct
        {
            decimal maxNumber = decimal.MinValue;
            foreach (dynamic number in collection)
            {
                if (maxNumber < number)
                {
                    maxNumber = number;
                }
            }
            return maxNumber;
        }

        //task 10
        public static void StudentsFromSecondGroup(this List<Student> student)
        {
            var secondGroup = student.OrderBy(st => st.FirstName).Where(st => st.GroupNumber == 2);
            Console.WriteLine("Students from second group(method):");
            secondGroup.ToList().ForEach(Console.WriteLine);
        }

        // task 17
        public static string LongestFirstName(this List<Student> student)
        {
            int longestFirstNameLength = 0;
            string longestFirstName = "";
            foreach (var st in student)
            {
                int currentName = st.FirstName.Length;
                if (currentName > longestFirstNameLength)
                {
                    longestFirstNameLength = currentName;
                    longestFirstName = st.FirstName;
                }
            }
            return longestFirstName ;
        }
    }
}
