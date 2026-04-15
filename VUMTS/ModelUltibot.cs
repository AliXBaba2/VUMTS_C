using System;
using System.IO.Ports;

namespace VUMTS
{
    public class ModelUltibot : IModel
    {
        private SerialPort _serialPort;

        private IView view;
        private IController controller;

        private int lastDistance = 0;

        public IView View
        {
            get { return view; }
            set { view = value; }
        }

        public IController Controller
        {
            get { return controller; }
            set { controller = value; }
        }

        public ModelUltibot()
        {
            _serialPort = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);

            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.DataReceived += SerialPort_DataReceived;
        }

        public int getDistance()
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
            }

            return lastDistance;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string message = _serialPort.ReadExisting();

                if (message.Contains("J"))
                    message = message.Split('J')[1];

                if (message.Contains("\n"))
                    message = message.Split('\r')[0];

                if (message != "")
                {
                    if (int.TryParse(message, out int distance))
                    {
                        lastDistance = distance;
                    }
                }
            }
            catch
            {
            }
        }

        public void stop()
        {
            if (_serialPort.IsOpen)
                _serialPort.Close();
        }

        private class Parity
        {
            public static object None { get; internal set; }
        }

        private class StopBits
        {
            public static object One { get; internal set; }
        }
    }
}