using System;
using Microsoft.SPOT;

namespace IoTALGYAN.NineSensorsShield.Sensors
{
    internal class ML8511Impl : ML8511
    {
        public bool Initialize()
        {
            throw new NotImplementedException();
        }

        public ML8511SensorReading TakeMeasurement()
        {
            throw new NotImplementedException();
        }

        public ML8511Impl(NineSensorsSield owner)
        {
            Owner = owner;
        }

        private NineSensorsSield Owner;
    }
}
