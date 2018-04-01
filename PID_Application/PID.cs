using System;
using NationalInstruments.DAQmx;


namespace PID_Application
{
    //this class is designed to read temperatures from an LM335 temperature sensor with 10mV/°K and adjusts voltage output based on temperature read.
    //Update() should be called at intervals according to the timesteps user desires. Temperature units of measurement are default Celsius unless user specifies.

    public class PID : IDisposable
    {

        //class members
        private double proportionalTerm;
        private double integralTerm;
        private double derivativeTerm;
        private double tempSet;
        protected double tempRead;
        private double currentError, errorSum, previousError, voltageOut;
        private double timeStep;
        private int numOfSteps;
        private string units;

        private bool disposed = false;

        private NationalInstruments.DAQmx.Task readTask = new NationalInstruments.DAQmx.Task();
        private NationalInstruments.DAQmx.Task writeTask = new NationalInstruments.DAQmx.Task();
        private AnalogSingleChannelReader reader;
        private AnalogSingleChannelWriter writer;

        //class constructor
        public PID(string deviceSel,int channelInSel,int channelOutSel,AITerminalConfiguration measureType) 
        {
            numOfSteps = 0;
            voltageOut = 0.0;
            previousError = 0.0;
            units = "Celsius";

            string outChannel = deviceSel + string.Format("/ao{0}", channelOutSel);
            string inChannel = deviceSel + string.Format("/ai{0}", channelInSel);

            writeTask.AOChannels.CreateVoltageChannel(outChannel, "", -10.0, 10.0, AOVoltageUnits.Volts);
            readTask.AIChannels.CreateVoltageChannel(inChannel, "", measureType, -10.0, 10.0, AIVoltageUnits.Volts);

            reader = new AnalogSingleChannelReader(readTask.Stream);
            writer = new AnalogSingleChannelWriter(writeTask.Stream);

        }

        //public methods
        public void Update()
        {
            double voltageToWrite;

            tempRead = reader.ReadSingleSample(); //reads voltage from temperature sensor

            if (units == "Farenheit")
                currentError = tempSet - ((tempRead / 0.01) - 273.15)*(9.0/5.0) + 32.0;
            else
                currentError = tempSet - ((tempRead / 0.01) - 273.15); //based on units selected return temperature of that type  

            voltageToWrite = OutputSet(currentError);      
    
            if(voltageToWrite >= 10.0)
                writer.WriteSingleSample(true, 10.0);
            else if(voltageToWrite <= -10.0)
                writer.WriteSingleSample(true, -10.0);
            else
                writer.WriteSingleSample(true, voltageToWrite);

        }


        public void Off() //make sure to clear pins
        {
            writeTask.Stop();
            writer.WriteSingleSample(true, 0.0);
        }

        //garbage collection for DAQmx tasks
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    writeTask.Dispose();
                    readTask.Dispose();
                }
                disposed = true;
            }
        }
        ~PID(){
            Dispose(false);
        }

        //internal methods
        private double OutputSet(double currentError)
        {
            double A, B, C;
            A = proportionalTerm;
            B = integralTerm;
            C = derivativeTerm;

            errorSum = errorSum + currentError;

            voltageOut = A * currentError + B * errorSum * timeStep + (C / timeStep) * (currentError - previousError) ;

            previousError = currentError;
            numOfSteps++;

            return voltageOut;
        }

        //Write Only Properties
        public double ProportionalTerm
        {
            set { proportionalTerm = value; }
        }
        public double Integralterm
        {
            set { integralTerm = value; }
        }
        public double DerivativeTerm
        {
            set { derivativeTerm = value; }
        }

        //Read Only Properties
        public double TempRead
        {
            get
            {
                if (units == "Farenheit")
                    return ((tempRead / 0.01) - 273.15) * (9.0 / 5.0) + 32.0;
                else
                    return ((tempRead / 0.01) - 273.15);
            }
        }
        public int NumOfSteps
        {
            get { return numOfSteps; }
        }
        public double ProportionalContribution
        {
            get
            {
                if (voltageOut > 0.0)
                    return ((currentError * proportionalTerm) / voltageOut);
                else
                    return 0.0;
            }
        }
        public double IntegralContribution
        {
            get
            {
                if (voltageOut > 0.0)
                    return ((errorSum * (integralTerm * timeStep)) / voltageOut);
                else
                    return 0.0;
            }
        }
        public double DerivativeContribution
        {
            get
            {
                if (voltageOut > 0.0)
                    return (((currentError - previousError) * derivativeTerm / timeStep) / voltageOut);
                else
                    return 0.0;
            }
        }

        //Read/Write Properties
        public string Units
        {
            get
            {
                return units;
            }
            set
            {
                if (value != "Celsius" && value != "Farenheit")
                    units = "Celsius";
                else
                    units = value;
            }
        }
        public double TimeStep
        {
            set //reset errors on change of tempSet reference
            {
                timeStep = value;
                errorSum = 0.0;
                previousError = 0.0;
            }
            get
            {
                return timeStep;
            }
        }
        public double TempSet
        {
            set
            {
                tempSet = value;
                errorSum = 0.0;
                previousError = 0.0;
            }
            get
            {
                return tempSet;
            }
        }
    }

}
