using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public Car()
        {

        }
        public Car(string year, string make, string model, int doors)
        {
            Year = year;
            Make = make;
            Model = model;
            Doors = doors;
        }

        public int Doors = 4;

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine($"The {Year} {Make} {Model} Accellerates Forward");
        }

        public override void DriveVirtual(Vehicle vehicle)
        {
            base.DriveVirtual(vehicle);
        }
    }
}
