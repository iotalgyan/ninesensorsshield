using System;
using Microsoft.SPOT;

namespace IoTALGYAN.NineSensorsShield.Sensors
{
    internal class HTS22Impl : HTS22
    {
        public bool Initialize()
        {
            throw new NotImplementedException();
        }

        public HTS22SensorReading TakeMeasurement()
        {
            throw new NotImplementedException();
        }

        public HTS22Impl(NineSensorsSield owner)
        {
            Owner = owner;
        }

        private NineSensorsSield Owner;
    }
}
