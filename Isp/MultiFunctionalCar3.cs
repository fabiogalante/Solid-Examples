namespace Isp
{
    public class MultiFunctionalCar3 : IMultiFunctionalVehicle
    {
        private readonly ICar _car;
        private readonly IAirplane _airplane;

        public MultiFunctionalCar3(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }

        public void Drive()
        {
            _car.Drive();
        }

        public void Fly()
        {
            _airplane.Fly();
        }
    }
}
