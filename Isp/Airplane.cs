using System;

namespace Isp
{
    public class Airplane : IAirplane  // IVehicle
    {
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
