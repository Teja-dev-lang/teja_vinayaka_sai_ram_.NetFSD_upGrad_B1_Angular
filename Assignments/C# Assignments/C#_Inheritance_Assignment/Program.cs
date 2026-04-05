namespace C__Inheritance_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Question-1
            staff s1 = new Doctor(123, "Teja", 300000, 200);
            staff s2 = new Nurse(124, "Ravi", 250000, 5000);
            staff s3 = new LabTechnician(125, "Anil", 200000, 3000);

            s1.CalcuateSalary();
            s2.CalcuateSalary();
            s3.CalcuateSalary();

            //2 Question-2
            Saving_Account acc = new Saving_Account(2234,2300);
            acc.CalculateInterest();

            CurrentAccount acc1 = new CurrentAccount(40002, 220);
            acc1.CalculateInterest();


            //3 Question-3
            List<Order> Orders = new List<Order>();

            Orders.Add(new Order(1, 2000));
            Orders.Add(new ExpressOrder(2, 4000));
            Orders.Add(new InternationalOrder(3, 6000));

            foreach (Order order in Orders)
            {
                Console.WriteLine("OrderID : " + order.OrderID);
                Console.WriteLine("Shipping Cost : " + order.CalculateShippingCost());
                Console.WriteLine();
            }

            //4 Question 4
            ElectricCar ecar = new ElectricCar(202, "Tesla", "Electric");
            ecar.StartVehicle();

            Console.WriteLine();

            // question 5
            Student s = new Student(104,"ram",77);
            s.CalculateGrade();

            CollegeStudent c = new CollegeStudent(109, "vikas", 34);
            c.CalculateGrade();


        }
    }
}
