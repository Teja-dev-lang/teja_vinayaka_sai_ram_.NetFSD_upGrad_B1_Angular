namespace C__Interfaces_Assignment
{
    //public interface IGovtRules
    //{
    //    public double EmployeePF(double basicSalary);
    //    public string LeaveDetails();
    //    public double gratuityAmount(float serviceCompleted, double basicSalary);
    //}
    //public class TCS : IGovtRules
    //{

    //    public int Empid { get; set; }
    //    public string Name { get; set; }
    //    public string Dept { get; set; }
    //    public string Desg { get; set; }
    //    public double BasicSalary { get; set; }

    //    public TCS(int empid, string name, string dept, string desg, double basic_salary)
    //    {
    //        Empid = empid;
    //        Name = name;
    //        Dept = dept;
    //        Desg = desg;
    //        BasicSalary = basic_salary;
    //    }
    //    public double EmployeePF(double basicSalary)
    //    {

    //        double EmpContri = basicSalary * 0.0833;
    //        double PensionFund = basicSalary * 0.0367;
    //        return (EmpContri + PensionFund);

    //    }
    //    public string LeaveDetails()
    //    {
    //        return $"The Leave Struture in {this.GetType().Name} :\n 1 day of Casual Leave per month\n12 days of Sick Leave per year\n10 days of Previlage Leave per year";
    //    }

    //    public double gratuityAmount(float serviceCompleted, double basicSalary)
    //    {
    //        double gratuityAmount = 0;
    //        ;
    //        if (serviceCompleted >= 20.0)
    //        {
    //            gratuityAmount = basicSalary * 3;
    //        }
    //        else if (serviceCompleted >= 10.0)
    //        {
    //            gratuityAmount = basicSalary * 2;
    //        }
    //        else if (serviceCompleted >= 5.0)
    //        {
    //            gratuityAmount = basicSalary;
    //        }
    //        return gratuityAmount;
    //    }

    //}

    //public class Accenture : IGovtRules
    //{

    //    public int Empid { get; set; }
    //    public string Name { get; set; }
    //    public string Dept { get; set; }
    //    public string Desg { get; set; }
    //    public double BasicSalary { get; set; }

    //    public Accenture(int empid, string name, string dept, string desg, double basic_salary)
    //    {
    //        Empid = empid;
    //        Name = name;
    //        Dept = dept;
    //        Desg = desg;
    //        BasicSalary = basic_salary;
    //    }
    //    public double EmployeePF(double basicSalary)
    //    {
    //        double EmpeeContri = basicSalary * 0.12;
    //        double EmpContri = basicSalary * 0.0833;
    //        double PensionFund = basicSalary * 0.0367;
    //        return (EmpeeContri + EmpContri + PensionFund);

    //    }
    //    public string LeaveDetails()
    //    {
    //        return $"The Leave Struture in {this.GetType().Name} :\n 2 day of Casual Leave per month\n 5 days of Sick Leave per year\n 5 days of Previlage Leave per year";
    //    }

    //    public double gratuityAmount(float serviceCompleted, double basicSalary)
    //    {
    //        double gratuityAmount = 0;
    //        return gratuityAmount;
    //    }
    //}

    public class Program
    {
        static void Main(string[] args)
        {
            //TCS emp1 = new TCS(123, "teja", "IT", "AI DEV", 30000);
            //Console.WriteLine(emp1.gratuityAmount(112.3f, 2000));
            //Console.WriteLine(emp1.EmployeePF(30000));
            //Console.WriteLine(emp1.LeaveDetails()); 
        }
    }
}

