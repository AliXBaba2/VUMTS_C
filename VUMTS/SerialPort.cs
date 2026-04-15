
namespace VUMTS
{
    internal class SerialPort
    {
        internal readonly bool IsOpen;
        private string v1;
        private int v2;
        private object none;
        private int v3;
        private object one;

        public SerialPort(string v1, int v2, object none, int v3, object one)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.none = none;
            this.v3 = v3;
            this.one = one;
        }

        public int ReadTimeout { get; internal set; }
        public int WriteTimeout { get; internal set; }
        public Action<object, SerialDataReceivedEventArgs> DataReceived { get; internal set; }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal string ReadExisting()
        {
            throw new NotImplementedException();
        }
    }
}