using System;
using Microsoft.SPOT;

namespace IoTALGYAN.NineSensorsShield.Sensors
{
    internal class RPR0521Impl :RPR0521
    {
        public bool Initialize()
        {
            throw new NotImplementedException();
        }

        public RPR0521SensorReading TakeMeasurement()
        {
            throw new NotImplementedException();
        }

        public RPR0521Impl(NineSensorsSield owner)
        {
            Owner = owner;
        }

        private NineSensorsSield Owner;
    }
}
