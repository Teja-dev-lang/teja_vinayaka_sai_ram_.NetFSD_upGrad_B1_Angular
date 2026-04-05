using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C__Inheritance_Assignment
{
    public class Vehicle
    {
        public int VehicleNumber
        {
            get; set;
        }
        public string Brand { get; set; }

        public Vehicle(int vehicleNumber, string brand)
        {
            VehicleNumber = vehicleNumber;
            Brand = brand;
        }

        public void StartVehicle()
        {
            Console.WriteLine($"{Brand} is Started..");
            
        }
    }

    public class Car : Vehicle
    {
        public string FuelType{ get; set; }
        public Car(int vehicleNumber, string brand, string fuelType) : base(vehicleNumber, brand)
        {
            FuelType = fuelType;
        }
    }

    sealed class ElectricCar : Car
    {
        public ElectricCar(int vehicleNumber, string brand, string FuelType) : base(vehicleNumber, brand, FuelType) { }
    }

}
