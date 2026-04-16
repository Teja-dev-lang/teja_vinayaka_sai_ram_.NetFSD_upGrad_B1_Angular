using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignments1
{
    public class Doctor
    {
        int PatientID;
        string PatientName;
        int Age;
        string Disease;

        public Doctor(int patientid, string patientname, int age, string disease)
        {
            PatientID = patientid;
            PatientName = patientname;
            Age = age;
            Disease = disease;
        }
        public static void Main()
        {
            Doctor p = new Doctor(101, "Ravi Kumar", 45, "Diabetes");
            Console.WriteLine($"Patient id : {p.PatientID}");
            Console.WriteLine($"Patient Name : {p.PatientName}");
            Console.WriteLine($"Age : {p.Age}");
            Console.WriteLine($"Disease: {p.Disease}");
        }
    }
}
