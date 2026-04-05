using System;

namespace C__Inheritance_Assignment
{
    public class staff
    {
        public int staffid;
        public string name;
        public double basesalary;

        public staff(int staffid, string name, double basesalary)
        {
            this.staffid = staffid;
            this.name = name;
            this.basesalary = basesalary;
        }

        public virtual void CalcuateSalary()
        {
            Console.WriteLine($"The Total Salary : {basesalary}");
        }
    }

    public class Doctor : staff
    {
        public double consultationfee;

        public Doctor(int staffid, string name, double salary, double consultationfee)
            : base(staffid, name, salary)
        {
            this.consultationfee = consultationfee;
        }

        public override void CalcuateSalary()
        {
            double total_sal = consultationfee + basesalary;
            Console.WriteLine($"Doctor Salary : {total_sal}");
        }
    }

    public class Nurse : staff
    {
        double NightShiftAllowance;

        public Nurse(int staffid, string name, double salary, double allowance)
            : base(staffid, name, salary)
        {
            NightShiftAllowance = allowance;
        }

        public override void CalcuateSalary()
        {
            double total_sal = basesalary + NightShiftAllowance;
            Console.WriteLine($"Nurse Salary : {total_sal}");
        }
    }

    public class LabTechnician : staff
    {
        double EquipmentAllowance;

        public LabTechnician(int staffid, string name, double salary, double allowance)
            : base(staffid, name, salary)
        {
            EquipmentAllowance = allowance;
        }

        public override void CalcuateSalary()
        {
            double total_sal = basesalary + EquipmentAllowance;
            Console.WriteLine($"Lab Technician Salary : {total_sal}");
        }
    }

}