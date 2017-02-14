# ninesensorsshield
Development site of ninesensorsshield

# Basis of API

* initialize -> initialized sensors 
* get each sensor instance from sensors 
* get measured values from each sensor 
* [optional] receive notification from a sensor via registerd handler 

Each sensor should be corresponded to each real sensor chip. 
Name of sensors and measured values should be same name in all programming language. 

* KXG03   - accelx,accely,accelz gyrox,gyroy,gyroz 
* BM1422  - magx,magy,magz 
* HTS22   - temperature, humidity
* RPR0521 - distance visibleIntensity,infraredIntensity 
* BM1383  - pressure 
* ML8511  - ultraVioletIntensity 

