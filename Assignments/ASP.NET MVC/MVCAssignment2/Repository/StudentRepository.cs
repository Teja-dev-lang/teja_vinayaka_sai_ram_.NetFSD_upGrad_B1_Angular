using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using MVCAssignment2.Models;
using System.Globalization;

namespace MVCAssignment2.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        List<Student> GetAllStudent();
        void DeleteStudent(int id);
        void UpdateStudent(int Id,String Email);
    }
    public class StudentRepository : IStudentRepository
    {
        private List<Student> students = new List<Student>()
        {
            new Student
            {
                Id = 123,
                Name ="teja",
                Age =23,
                Email ="teja@gmail.com" 
            }
        };
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(e => e.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
        }

        public List<Student> GetAllStudent()
        {
            return students.ToList();
        }

        public void UpdateStudent(int Id, string Email)
        {
            //for (int i = 0; i < students.Count; i++)
            //{
            //    if (students[i].Id == Id)
            //    {
            //        students[i].Email = Email;
            //        break;
            //    }
            //}

            var student = students.FirstOrDefault(e => e.Id == Id);
            if (student != null)
            {
                student.Email = Email;
            }
        }
    }
}
