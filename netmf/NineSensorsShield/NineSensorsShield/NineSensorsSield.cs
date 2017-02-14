using System;
using Microsoft.SPOT;

namespace IoTALGYAN.NineSensorsShield
{
    enum SensorType
    {
        KEX03,
        BM1422,
        HTS22,
        RPR0521,
        BM1383,
        ML8511
    }

    /// <summary>
    /// Nine Sensors Shield
    /// </summary>
    public partial class NineSensorsSield
    {
        /// <summary>
        /// Initialize sensor chips
        /// </summary>
        /// <param name="jsonConfig">Describe sensors' initialize parameter by JSON format.</param>
        /// <returns></returns>
        public static bool Initialize(string jsonConfig=null)
        {
            return initializeImpl(jsonConfig);
        }

        public static KEX03 KEX03 { get; internal set; }
        public static BM1422 BM1422 { get; internal set; }
        public static HTS22 HTS22 { get; internal set; }
        public static RPR0521 RPR0521 { get; internal set; }
        public static BM1383 BM1383 { get; internal set; }
        public  static ML8511 ML8511 { get; internal set; }
    }

    public class KEX03SensorReading
    {
        public double AccelX { get; internal set; }
        public double AccelY { get; internal set; }
        public double AccelZ { get; internal set; }
        public double GyroX { get; internal set; }
        public double GyroY { get; internal set; }
        public double GyroZ { get; internal set; }
    }

    public interface KEX03
    {
        /// <summary>
        /// Take latest sensor measured values 
        /// </summary>
        /// <returns>latest measured values</returns>
        KEX03SensorReading TakeMeasurement();   
    }

    public class BM1422SensorReading
    {
        public double MagX { get; internal set; }
        public double MagY { get; internal set; }
        public double MagZ { get; internal set; }
    }

    public interface BM1422
    {
        /// <summary>
        /// Take latest sensor measured values 
        /// </summary>
        /// <returns>latest measured values</returns>
        BM1422SensorReading TakeMeasurement();
    }

    public class HTS22SensorReading
    {
        public double Temperature { get; internal set; }
        public double Humidity { get; internal set; }
    }
    public  interface HTS22
    {
        /// <summary>
        /// Take latest sensor measured values 
        /// </summary>
        /// <returns>latest measured values</returns>
        HTS22SensorReading TakeMeasurement();
    }
    public class RPR0521SensorReading
    {
        public double Distance { get; internal set; }
        public double InfraRedIntensity { get; internal set; }
        public double VisibleIntensity { get; internal set; }
    }
    public interface RPR0521
    {
        /// <summary>
        /// Take latest sensor measured values 
        /// </summary>
        /// <returns>latest measured values</returns>
        RPR0521SensorReading TakeMeasurement();
    }
    public class BM1383SensorReading
    {
        public double Pressure { get; internal set; }
    }
    public interface BM1383
    {
        /// <summary>
        /// Take latest sensor measured values 
        /// </summary>
        /// <returns>latest measured values</returns>
        BM1383SensorReading TakeMeasurement();
    }
    public class ML8511SensorReading
    {
        public double UltraVioletIntensity { get; set; }
    }
    public  interface ML8511
    {
        /// <summary>
        /// Take latest sensor measured values 
        /// </summary>
        /// <returns>latest measured values</returns>
        ML8511SensorReading TakeMeasurement();
    }
}
