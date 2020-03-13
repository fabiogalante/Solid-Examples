using System;

namespace Isp
{
    public class Car : ICar // IVehicle
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
    }
}
