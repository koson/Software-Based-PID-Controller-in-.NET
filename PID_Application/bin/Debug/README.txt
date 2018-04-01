Pid Software Based Temperature Controller


This program is designed to control the temperature of a device connected to a National Instruments Data Acquisition Board.
You must have one free channel for both the analog in and out of the DAQ board. Temperature is measure in Volts, and based
on the set PID parameters a Voltage is written on the analog out channel selected. 

The timestep between voltage measurements is default set to 10ms. You can unlock the form control by selecting "Unlock Timestep parameter" 
under Menu. Hotkeys are provided for common controls. If a device is not present at the time of program loading, a notification will appear 
telling you no devices were found and all panel controls are disabled until you check the connection of the device and refresh the device 
list which is also located under Menu or by pressing (Ctrl + R).

To display this help again press (Ctrl + H).

Written by Tyler Dula 
Designed and tested on Ni M-Series 6221.
