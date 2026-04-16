using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ
{
    public record Student(int Id, string name, int age, int marks);
    internal class studentFiltering
    {
        

        static void Main()
        {
            

            List<Student> list = new List<Student>()
            {
                new Student(1, "Teja", 22, 85),
                new Student(2, "Ravi", 21, 78),
                new Student(3, "Anil", 23, 92),
                new Student(4, "Kiran", 20, 67),
                new Student(5, "Sneha", 22, 88),
                new Student(6, "Priya", 21, 74),
                new Student(7, "Rahul", 23, 81),
                new Student(8, "Divya", 20, 90),
                new Student(9, "Vamsi", 22, 69),
                new Student(10, "Nikhil", 21, 95)
            };
            /*
            //1. Get all students with marks > 75
            var results = list.Where(e => e.marks > 75);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            //2. Get students whose age is between 18 and 25
            var FilterAge = list.Where(e => e.age > 18 && e.age < 25);
            foreach (var item in FilterAge)
            {
                Console.WriteLine(item);
            }
            

            //3. Sort students by Marks (descending)

            var sortMarks = list.OrderBy(e => e.marks);
            foreach (var item in sortMarks)
            {
                Console.WriteLine(item);
            }
            */

            //4. Select only Name and Marks

            //all combine query:
            var finalResult = list
                .Where(e => e.marks > 75 && (e.age > 18 && e.age < 25))
                .OrderByDescending(e => e.marks)
                .Select(e=>new { e.name,e.marks});
            foreach (var item in finalResult)
            {
                Console.WriteLine($"{item.name} - {item.marks}");
            }
        }
    }
}
