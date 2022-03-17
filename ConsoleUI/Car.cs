using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    /* Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - Done
     * 
    //* Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - Done
    //* Provide the implementations for the abstract methods
    //* Only in the Motorcycle class will you override the virtual drive method*/
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"It's fun to drive this car!");
        }
    }
}
