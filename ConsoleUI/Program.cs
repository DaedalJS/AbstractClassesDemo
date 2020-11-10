using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car delorean = new Car("1983", "DMC", "DeLorean", 2);
            Motorcycle harley = new Motorcycle("1992", "Harley Davidson", "Junker", "Chopper");
            Vehicle relic = new Car();
            Vehicle dunebuggy = new Car("2000", "Custom", "Mud Buggy", 0);
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(delorean);
            vehicles.Add(relic);
            vehicles.Add(dunebuggy);
            vehicles.Add(harley);

            foreach (Vehicle x in vehicles) { 
                Console.WriteLine($"{x.Year} {x.Make} {x.Model}. \n");
                }
            // Call each of the drive methods for one car and one motorcycle

            relic.DriveVirtual(relic);
            Console.WriteLine("\n");
            delorean.DriveAbstract(delorean);
            Console.WriteLine("\n");
            harley.DriveVirtual(harley);
            Console.WriteLine("\n");
            harley.DriveAbstract(harley);

                #endregion
            Console.ReadLine();
        }
    }
}
