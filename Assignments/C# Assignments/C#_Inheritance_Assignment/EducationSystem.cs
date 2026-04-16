using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace C__Inheritance_Assignment
{
    public class Student
    {
        public int Studentid { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        public Student(int studentid, string name ,double marks)
        {
            Studentid = studentid;
            Name = name;
            Marks = marks;
        }

        public virtual void CalculateGrade()
        {
            if (Marks > 50)
            {
                Console.WriteLine("Pass");

            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }

    public class SchoolStudent : Student
    {
        public SchoolStudent(int studentid, string name, double marks) : base(studentid, name, marks) { }

        public override void CalculateGrade()
        {
            if (Marks > 40)
            {
                Console.WriteLine("Pass");

            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
    public class CollegeStudent : Student
    {
        public CollegeStudent(int studentid, string name, double marks) : base(studentid, name, marks) { }
        public override void CalculateGrade()
        {
            base.CalculateGrade();
        }
    }

    public class OnlineStudent : Student
    {
        public OnlineStudent(int studentid, string name, double marks) : base(studentid, name, marks) { }
        public override void CalculateGrade()
        {
            if (Marks > 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }



}

