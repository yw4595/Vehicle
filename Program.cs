using System;

namespace Vehicles
{
    /// <summary>
    /// Author: ChatGPT
    /// Purpose of the class: To define the base class of all vehicles
    /// Restrictions on the usage or known errors: None
    /// </summary>
    public class Vehicle
    {
        // class members
    }

    /// <summary>
    /// Author: ChatGPT
    /// Purpose of the class: To define the IPassengerCarrier interface
    /// Restrictions on the usage or known errors: None
    /// </summary>
    public interface IPassengerCarrier
    {
        /// <summary>
        /// Purpose of the method: To load passengers
        /// Restrictions on the usage or known errors: None
        /// </summary>
        void LoadPassenger();
    }

    /// <summary>
    /// Author: ChatGPT
    /// Purpose of the class: To define the IHeavyLoadCarrier interface
    /// Restrictions on the usage or known errors: None
    /// </summary>
    public interface IHeavyLoadCarrier
    {
        /// <summary>
        /// Purpose of the method: To load heavy load
        /// Restrictions on the usage or known errors: None
        /// </summary>
        void LoadHeavyLoad();
    }

    /// <summary>
    /// Author: ChatGPT
    /// Purpose of the class: To define the derived class of vehicle for _424DoubleBogey
    /// Restrictions on the usage or known errors: None
    /// </summary>
    public class _424DoubleBogey : Vehicle, IPassengerCarrier, IHeavyLoadCarrier
    {
        /// <summary>
        /// Purpose of the method: To load passengers
        /// Restrictions on the usage or known errors: None
        /// </summary>
        public virtual void LoadPassenger()
        {
            Console.WriteLine("_424DoubleBogey is loading passengers");
        }

        /// <summary>
        /// Purpose of the method: To load heavy load
        /// Restrictions on the usage or known errors: None
        /// </summary>
        public virtual void LoadHeavyLoad()
        {
            Console.WriteLine("_424DoubleBogey is loading heavy load");
        }
    }
}
