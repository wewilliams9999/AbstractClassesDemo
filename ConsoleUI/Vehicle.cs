using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        /* The vehicle class shall have three string properties Year, Make, and Model - Done
        * Set the defaults to something generic in the Vehicle class - Done
        * Vehicle shall have an abstract method called DriveAbstract with no implementation - Done
        * Vehicle shall have a virtual method called DriveVirtual with a base implementation.*/
        public int Year { get; set; } = 2020;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";
        
        public abstract void DriveAbstract(); //a.k.a. stubbed out method - has no implementation in base class
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }


    }
}
