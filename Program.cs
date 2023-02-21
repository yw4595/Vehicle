using System;
using Vehicles;

namespace Traffic
// Author: Yanzhi Wang
// Purpose: Adds a passenger to a vehicle that implements IPassengerCarrier interface
// Restrictions: None
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", 4, 5); // create a new Car object
            Bike myBike = new Bike("Trek", 2, 1); // create a new Bike object
            Bus myBus = new Bus("Greyhound", 6, 45); // create a new Bus object

            AddPassenger(myCar); // call AddPassenger with Car object
            AddPassenger(myBike); // call AddPassenger with Bike object
            AddPassenger(myBus); // call AddPassenger with Bus object

            object myObject = new object(); // create a new object that does not implement IPassengerCarrier
            AddPassenger(myObject); // try calling AddPassenger with non-IPassengerCarrier object
        }

        /// <summary>
        /// Adds a passenger to a vehicle that implements IPassengerCarrier interface
        /// </summary>
        /// <param name="vehicle">Any object that implements IPassengerCarrier interface</param>
        /// <remarks>
        /// Restrictions: None
        /// Known Errors: None
        /// </remarks>
        static void AddPassenger(object vehicle)
        {
            if (vehicle is IPassengerCarrier) // check if object implements IPassengerCarrier interface
            {
                IPassengerCarrier passengerCarrier = (IPassengerCarrier)vehicle; // cast object to IPassengerCarrier
                passengerCarrier.LoadPassenger(); // call LoadPassenger method from IPassengerCarrier interface
                Console.WriteLine(vehicle.ToString()); // call ToString method on object passed in
            }
            else // object does not implement IPassengerCarrier interface
            {
                Console.WriteLine("The object passed does not implement IPassengerCarrier interface.");
            }
        }
    }
}
