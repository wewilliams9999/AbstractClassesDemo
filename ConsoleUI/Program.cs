using System;
using System.Collections.Generic;
using System.Linq;
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
             * Create an abstract class called Vehicle - DONE
             * 
             * The vehicle class shall have three string properties Year, Make, and Model - Done
             * Set the defaults to something generic in the Vehicle class - Done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - Done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - Done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - Done
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - Done
             * Provide the implementations for the abstract methods - Done
             * Only in the Motorcycle class will you override the virtual drive method - Done
            */

            // Create a list of Vehicles called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) 
             * but use constructors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2021};
            Motorcycle funVehicle = new Motorcycle() { HasSideCar = true, Make = "Harley Davidson", Model = "Sportster", Year = 2017};
            Vehicle truck = new Car() { HasTrunk = false, Make = "Chevrolet", Model = "GMC Canyon", Year = 2018};
            Vehicle stationWagon = new Car() { HasTrunk = true, Make = "Volkswagen", Model = "Golf Sport", Year = 2016};

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            // Call each of the drive methods for one car and one motorcycle

            vehicles.Add(focus);
            vehicles.Add(funVehicle);
            vehicles.Add(truck);
            vehicles.Add(stationWagon);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make: {veh.Make}.  Model: {veh.Model}.  Year = {veh.Year}.");
                veh.DriveAbstract();
                veh.DriveVirtual();
                Console.WriteLine("------------------------------------------------------------------");
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
