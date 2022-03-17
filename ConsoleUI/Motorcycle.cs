using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    /* Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - Done
     * 
    * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - Done
    * Provide the implementations for the abstract methods
    * Only in the Motorcycle class will you override the virtual drive method*/
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; } //will have default value of false

        public override void DriveAbstract()
        {
            Console.WriteLine($"I feel so cool driving this motorcycle!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive");
        }

    }

}
