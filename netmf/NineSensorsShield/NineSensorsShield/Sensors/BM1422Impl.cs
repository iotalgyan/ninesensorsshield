using System;
using Microsoft.SPOT;

namespace IoTALGYAN.NineSensorsShield.Sensors
{
    internal class BM1422Impl : BM1422
    {
        public bool Initialize()
        {
            throw new NotImplementedException();
        }

        public BM1422SensorReading TakeMeasurement()
        {
            throw new NotImplementedException();
        }

        public BM1422Impl(NineSensorsSield owner)
        {
            Owner = owner;
        }

        private NineSensorsSield Owner;
    }
}

