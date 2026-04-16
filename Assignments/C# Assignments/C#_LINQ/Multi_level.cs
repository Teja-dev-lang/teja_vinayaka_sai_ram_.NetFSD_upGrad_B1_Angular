using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ
{
    public record StudentRecords(int Id, string Name, string Class, string Subject, double Marks);
    internal class Multi_level
    {

        static void Main()
        {
            List<StudentRecords> std = new List<StudentRecords>
            {
                new StudentRecords(1, "Teja", "10A", "Math", 85),
                new StudentRecords(2, "Rahul", "10A", "Science", 78),
                new StudentRecords(3, "Anjali", "10B", "Math", 92),
                new StudentRecords(4, "Kiran", "10B", "English", 67),
                new StudentRecords(5, "Sneha", "10A", "Math", 88),
                new StudentRecords(6, "Arjun", "10C", "Science", 74)
            };

            var grp_class = std
                .GroupBy(e => e.Class)
                .Select(classGroup => new
                {
                    Class = classGroup.Key,
                    Subjects = classGroup.GroupBy(e => e.Subject)
                });

            foreach (var item in grp_class)
            {
                Console.WriteLine($"Class: {item.Class}");

                foreach (var subjectGroup in item.Subjects)
                {
                    Console.WriteLine($"  Subject: {subjectGroup.Key}");

                    foreach (var student in subjectGroup)
                    {
                        Console.WriteLine($"    {student.Name} - {student.Marks}");
                    }
                }
            }


        }
    }
}
