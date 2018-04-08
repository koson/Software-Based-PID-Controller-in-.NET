using System;
using NationalInstruments.DAQmx;


namespace PID_Application
{

    public abstract class PID
    {
        private double a;
        private double b;
        private double c;
        private double input, output, setPoint;
        private double currentError, previousError, sumOfErrors, errorStep;
        private double timeStep;

        public PID(double timeStep)
        {
            this.timeStep = timeStep;

            previousError = 0.0;
            sumOfErrors = 0.0;
            errorStep = 0.0;
        }

        //inheriting classes must implement their own adjustment for the 
        //output present of the PID
        abstract public void AdjustOutput();

        //Output Estimation is clearly defined in base class
        //A proportional term - B integral term - C Derivative term
        protected double OutputEstimate()
        {
            currentError = setPoint - input;

            errorStep = currentError - previousError;

            sumOfErrors = sumOfErrors + currentError;
            output = A * currentError + B * timeStep * sumOfErrors + (C / timeStep) * (errorStep);

            previousError = currentError;

            return output;
        }

        public void ReturnErrors(out double currentError,out double sumOfErrors,out double errorStep){
            currentError = this.currentError;
            sumOfErrors = this.sumOfErrors;
            errorStep = this.errorStep;
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        protected double OutPut
        {
            get { return output; }
        }
        protected double Input
        {
            set { input = value; }
        }
        protected double SetPoint
        {
            set { setPoint = value; sumOfErrors = 0.0; previousError = 0.0; }
            get { return setPoint; }
        }
    }

    public class TemperatureController : PID, IDisposable
    {
        //this class is designed to read temperatures from an LM335 temperature sensor with 10mV/°K and adjusts voltage output based on temperature read. 
        //Default temperature coefficient for TempSensor is that of the LM335 (0.01mV/K)
        //Update() should be called at intervals according to the timesteps user desires. Temperature units of measurement are default Celsius unless user specifies
        //otherwise. if not a supported unit of temperature (C,F,K) then reading of sensor will
        //return 0

        private NationalInstruments.DAQmx.Task writeTask;
        private AnalogSingleChannelWriter writer;
        private TempSensor sensor;

        private bool disposed = false;

        public TemperatureController(double timeStep,string tempUnits,string aiChannel,AIVoltageUnits aiUnits,string aoChannel,AOVoltageUnits aoUnits) : base(timeStep)
        {
            sensor = new TempSensor(aiChannel, aiUnits, tempUnits);
            writeTask = new NationalInstruments.DAQmx.Task();
            writer = new AnalogSingleChannelWriter(writeTask.Stream);

            writeTask.AOChannels.CreateVoltageChannel(aoChannel, "", -10.0, 10.0, aoUnits);
            
            sensor.TemperatureCoefficient = 0.01; //temperature controller inherently contains a temp sensor with 0.01mV/K coefficient
        } 

        public override void AdjustOutput()
        {
            Input = sensor.ReadSensor();            //read the sensor
            OutputEstimate();                       //estimate the output based on errors
            
            if (OutPut > 10.0)
                writer.WriteSingleSample(true, 10.0); //write the new output. Output min and max are default +-10.0V
            else if (OutPut < -10.0)
                writer.WriteSingleSample(true, -10.0);
            else
                writer.WriteSingleSample(true, OutPut);
        }


        #region IDisposable
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
                    writer.WriteSingleSample(true, 0.0);
                    writeTask.Dispose();
                    sensor.Dispose();
                }
                disposed = true;
            }
        }
        ~TemperatureController()
        {
            Dispose(false);
        }
        #endregion

        public double DesiredTemp
        {
            set { SetPoint = value;  }
            get { return SetPoint; }
        }
        public double TempRead
        {
            get { return sensor.ReadSensor(); }
        }
    }

    public class TempSensor : IDisposable
    {
        //this is a temperature sensor object, has units and a coefficient
        //expected. The LM335 can only be read, excitation voltage can 
        //be included optionally if conservation of power and self heating prevention is required.

        private double temperatureCoefficient;
        private string tempUnits;

        private NationalInstruments.DAQmx.Task readTask;
        private AnalogSingleChannelReader reader;

        private bool disposed = false;

        public TempSensor(string physicalChannelName,AIVoltageUnits aiUnits,string tempUnits)
        {
            this.tempUnits = tempUnits;

            readTask = new NationalInstruments.DAQmx.Task();
            reader = new AnalogSingleChannelReader(readTask.Stream);
            readTask.AIChannels.CreateVoltageChannel(physicalChannelName,"",AITerminalConfiguration.Rse,-10.0,10.0,aiUnits);
        }

        public double ReadSensor()
        {
            if (tempUnits == "C")
                return (reader.ReadSingleSample() / temperatureCoefficient) - 273.15;
            else if (tempUnits == "F")
                return ((reader.ReadSingleSample() / temperatureCoefficient) - 273.15) * (9.0 / 5.0) + 32.0;
            else if (tempUnits == "K")
                return (reader.ReadSingleSample() / temperatureCoefficient);
            else
                return 0.0;
        }

        #region IDisposable
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
                    readTask.Dispose();
                }
                disposed = true;
            }
        }
        ~TempSensor()
        {
            Dispose(false);
        }
        #endregion

        //properties -- must set the temperature coefficient after object instantiation
        public double TemperatureCoefficient
        {
            set { temperatureCoefficient = value; }
            get { return temperatureCoefficient; }
        }

    }

}
