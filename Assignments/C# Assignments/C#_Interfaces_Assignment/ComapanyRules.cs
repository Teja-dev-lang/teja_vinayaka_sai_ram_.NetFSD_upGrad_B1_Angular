using System;

namespace C__Interfaces_Assignment
{
    public interface IGovtRules
    {
        double CalculatePF(double basicSalary);   // total PF
        string LeaveDetails();
        double GratuityAmount(double serviceCompleted, double basicSalary);
    }

    public class Employee 
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desg { get; set; }
        public double BasicSalary { get; set; }

        public Employee(int empid, string name, string dept, string desg, double basicSalary)
        {
            Empid = empid;
            Name = name;
            Dept = dept;
            Desg = desg;
            BasicSalary = basicSalary;
        }
    }

    public class TCS : Employee, IGovtRules
    {
        public TCS(int empid, string name, string dept, string desg, double basicSalary)
            : base(empid, name, dept, desg, basicSalary) { }

        public double CalculatePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.0833;
            double pension = basicSalary * 0.0367;

            return employeePF + employerPF + pension;
        }

        public string LeaveDetails()
        {
            return $"TCS Leave Policy:\n" +
                   "1 Casual Leave per month\n" +
                   "12 Sick Leaves per year\n" +
                   "10 Privilege Leaves per year";
        }

        public double GratuityAmount(double serviceCompleted, double basicSalary)
        {
            if (serviceCompleted >= 20)
                return basicSalary * 3;
            else if (serviceCompleted >= 10)
                return basicSalary * 2;
            else if (serviceCompleted >= 5)
                return basicSalary;
            else
                return 0;
        }
    }

    public class Accenture : Employee, IGovtRules
    {
        public Accenture(int empid, string name, string dept, string desg, double basicSalary)
            : base(empid, name, dept, desg, basicSalary) { }

        public double CalculatePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.0833;
            double pension = basicSalary * 0.0367;

            return employeePF + employerPF + pension;
        }

        public string LeaveDetails()
        {
            return $"Accenture Leave Policy:\n" +
                   "2 Casual Leaves per month\n" +
                   "5 Sick Leaves per year\n" +
                   "5 Privilege Leaves per year";
        }

        public double GratuityAmount(double serviceCompleted, double basicSalary)
        {
            if (serviceCompleted >= 10)
                return basicSalary * 2;
            else if (serviceCompleted >= 5)
                return basicSalary;
            else
                return 0;
        }
    }

    class test
    {
        static void Main()
        {
            IGovtRules emp1 = new TCS(101, "Teja", "IT", "Developer", 20000);
            IGovtRules emp2 = new Accenture(102, "Rahul", "HR", "Manager", 30000);

            
            Console.WriteLine("PF: " + emp1.CalculatePF(20000));
            Console.WriteLine(emp1.LeaveDetails());
            Console.WriteLine("Gratuity: " + emp1.GratuityAmount(12, 20000));

            Console.WriteLine("PF: " + emp2.CalculatePF(30000));
            Console.WriteLine(emp2.LeaveDetails());
            Console.WriteLine("Gratuity: " + emp2.GratuityAmount(7, 30000));
        }
    }
}