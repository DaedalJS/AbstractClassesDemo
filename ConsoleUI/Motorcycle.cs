using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public Motorcycle(string year, string make, string model, string style)
        {
            Year = year;
            Make = make;
            Model = model;
            Style = style;
        }

        public string Style = "Dual Sports";

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine("The Motorcycle suddenly pops a wheelie as you fall off to the ground in utter shock.");
        }

        public override void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"your {Year} {Make} {Model} makes a satisfying roar as you speed off on your {Style}.");
        }
    }
}
