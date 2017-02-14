using System;
using Microsoft.SPOT;

namespace IoTALGYAN.NineSensorsShield.Sensors
{
    internal class KEX03Impl : KEX03
    {
        public bool Initialize()
        {
            throw new NotImplementedException();
        }

        public KEX03SensorReading TakeMeasurement()
        {
            throw new NotImplementedException();
        }

        public KEX03Impl(NineSensorsSield owner)
        {
            Owner = owner;
        }

        private NineSensorsSield Owner;
    }
}
