using System;
using System.Collections.Generic;

namespace HelloWorldPt2
{
    interface IVehicle
    {
        void Drive();
        void Park();
    }

    public class BMWCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving into the bus stop");
        }
        public void Park()
        {
            Console.WriteLine("Parking on as many parking spots as possible at the same time");
        }
    }

    public class AnyOtherCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving to the destination");
        }
        public void Park()
        {
            Console.WriteLine("Parking on a single parking spot");
        }
    }

}
