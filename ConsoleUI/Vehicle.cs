using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year = "1776";
        public string Make = "Franklin";
        public string Model = "Automated cart";

        public abstract void DriveAbstract(Vehicle vehicle);
        
        public virtual void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"The {this.Year} {this.Make} {this.Model} moves forward as you press the accelerator.");
        }
    }


}
