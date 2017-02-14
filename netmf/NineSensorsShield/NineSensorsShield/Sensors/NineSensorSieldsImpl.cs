using System;
using Microsoft.SPOT;

namespace IoTALGYAN.NineSensorsShield
{
    public partial class NineSensorsSield
    {
        protected static bool initializeImpl(string jsonConfig)
        {
            myInstance = new NineSensorsSield();
            Sensors.KEX03Impl kex03 = new Sensors.KEX03Impl(myInstance);
            if(kex03.Initialize())
            {
                KEX03 = kex03;
            }
            else
            {
                return false;
            }
            Sensors.BM1422Impl bm1422 = new Sensors.BM1422Impl(myInstance);
            if (bm1422.Initialize())
            {
                BM1422 = bm1422;
            }
            else
            {
                return false;
            }
            Sensors.HTS22Impl hts22 = new Sensors.HTS22Impl(myInstance);
            if (hts22.Initialize())
            {
                HTS22 = hts22;
            }
            else
            {
                return false;
            }
            Sensors.RPR0521Impl rpr0521 = new Sensors.RPR0521Impl(myInstance);
            if (rpr0521.Initialize())
            {
                RPR0521 = rpr0521;
            }
            else
            {
                return false;
            }
            Sensors.BM1383Impl bm1383 = new Sensors.BM1383Impl(myInstance);
            if (bm1383.Initialize())
            {
                BM1383 = bm1383;
            }
            else
            {
                return false;
            }
            Sensors.ML8511Impl ml8511 = new Sensors.ML8511Impl(myInstance);
            if (ml8511.Initialize())
            {
                ML8511 = ml8511;
            }
            else
            {
                return false;
            }
            return true;
        }

        protected static NineSensorsSield myInstance;
    }
}
