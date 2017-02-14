using System;
using Microsoft.SPOT;

namespace IoTALGYAN.NineSensorsShield.Sensors
{
    internal class BM1383Impl : BM1383
    {
        public bool Initialize()
        {
            throw new NotImplementedException();
        }

        public BM1383SensorReading TakeMeasurement()
        {
            throw new NotImplementedException();
        }

        public BM1383Impl(NineSensorsSield owner)
        {
            Owner = owner;
        }

        private NineSensorsSield Owner;
    }
}
