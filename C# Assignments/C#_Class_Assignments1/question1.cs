using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignments1
{
    public class Patient
    {
        int PatientID;
        string PatientName;
        int Age;
        string Disease;

        public Patient(int patientid,string patientname,int age,string disease) 
        {
            PatientID = patientid;
            PatientName = patientname;
            Age = age;
            Disease = disease;
        }
        public static void Main()
        {
            Patient p = new Patient(101,"Ravi Kumar",45,"Diabetes");
            Console.WriteLine($"Patient id : {p.PatientID}");
            Console.WriteLine($"Patient Name : {p.PatientName}");
            Console.WriteLine($"Age : {p.Age}");
            Console.WriteLine($"Disease: {p.Disease}");
        }
    }
}
