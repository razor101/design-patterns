using System;

namespace design_patterns.AdapterPattern
{
    public class VehicleAdapter : IPlane
    {
        private readonly IVehicle vehicle;

        public VehicleAdapter(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public void Fly()
        {
            vehicle.Drive();
        }
    }
}