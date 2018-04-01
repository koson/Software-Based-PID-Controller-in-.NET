PID Control Software Chart Displays

The displays found on the front panel of this program display the temperature history since the start of 
PID being turned on. The top chart displays a zoom on the setpoint temperature +/- 5° while the bottom 
chart displays the temperature around setpoint +/- 15°. The units displayed are selectable between Celsius
or Farenheit. You may not change the units while the program output is running. To change the units displayed
you can find the option under Menu or by pressing (Ctrl + U) on the keyboard.

PID parameter contributions are displayed as a fraction of the net voltage being written to the DAQ board.
This is to give the user a better visual cue as to the effects of changing one of the constants. The constants 
are A, B, and C for the proportional, integral, and derivative components respectively. 

Time to equilibrium is calculated as the number of timesteps since the start of the program. This value is just an estimate and should just be used as a reference for the length of time to reach an equilibrium.
