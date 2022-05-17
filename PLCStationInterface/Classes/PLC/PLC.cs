using Sharp7;
using System;
using System.Threading.Tasks;
using VisualInspection.Utils.Net;
using VisualInspection.Utils.PLC;

namespace PLCStationInterface.Classes.PLC
{
    public class PLC
    {
        public event EventHandler<ushort> LiveUIntChanged;
        public event EventHandler<ClientStatus> StatusChanged;
        public event EventHandler<int> StatusCodeChanged;
        public event EventHandler<byte[]> DataBufferReceived;

        private S7Client client = new S7Client();
        //private S7Client WriteClient = new S7Client();
        private System.Timers.Timer timerUpdating = new System.Timers.Timer();
        private System.Timers.Timer timerReconnecting = new System.Timers.Timer();

        private int ReadStatusCode = -1;

        private ushort liveUInt = 0;
        private bool reconnectEnabled = false;
        //private byte[] readDataBuffer = null;
        private byte[] writeDataBuffer = null;
        private ClientStatus status = ClientStatus.Disconnected;

        public int StatusCode
        {
            get => ReadStatusCode;
            private set
            {
                bool changed = ReadStatusCode != value;
                ReadStatusCode = value;
                if (changed) StatusCodeChanged?.Invoke(this, value);
            }
        }

        public ushort LiveUInt
        {
            get => liveUInt;
            private set
            {
                Status = liveUInt != value ? ClientStatus.Connected : ClientStatus.Disconnected;
                liveUInt = value;
                if (Status == ClientStatus.Connected) LiveUIntChanged?.Invoke(this, value);
            }
        }

        public ClientStatus Status
        {
            get => status;
            private set
            {
                bool changed = status != value;
                status = value;
                if (!changed) return;
                if (value == ClientStatus.Connected) timerUpdating.Start();
                else timerUpdating.Stop();
                UpdateReconnectingTimer();
                StatusChanged?.Invoke(this, value);
            }
        }

        public int UpdateInterval { get => (int)timerUpdating.Interval; set => timerUpdating.Interval = value; }
        public int ReconnectInterval { get => (int)timerReconnecting.Interval; set => timerReconnecting.Interval = value; }
        public bool ReconnectEnabled { get => reconnectEnabled; set { reconnectEnabled = value; UpdateReconnectingTimer(); } }
        //public byte[] ReadDataBuffer { get => readDataBuffer; private set { readDataBuffer = value; DataBufferReceived?.Invoke(this, value); } }
        public byte[] WriteDataBuffer { get { return writeDataBuffer; } set { writeDataBuffer = value; } }

        public string IPAddress { get; set; } = "192.168.1.25";
        public int Rack { get; set; } = 0;
        public int Slot { get; set; } = 1;
        public int ReadDBNumber { get; set; } = 1;
        public int ReadDataBufferOffset { get; set; } = 0;
        public int ReadDataBufferSize { get; set; } = 1;
        public int WriteDBNumber { get; set; } = 1;
        public int WriteDataBufferOffset { get; set; } = 0;
        public int WriteDataBufferSize { get; set; } = 1;
        public int LiveUIntOffset { get; set; } = 0;

        public PLC()
        {
            timerUpdating.Interval = 150;
            timerReconnecting.Interval = 5000;
            timerUpdating.Elapsed += UpdateData;
            timerReconnecting.Elapsed += TryReconnect;
        }



        public void Connect()
        {
            Status = ClientStatus.Connecting;
            StatusCode = client.ConnectTo(IPAddress, Rack, Slot);
            Status = StatusCode == 0 ? ClientStatus.Connected : ClientStatus.Disconnected;
        }

        public async Task ConnectAsync() => await Task.Run(Connect);
        private void TryReconnect(object sender, EventArgs e) => Connect();

        public void Disconnect()
        {
            client.Disconnect();
            Status = ClientStatus.Disconnected;
        }

        private void UpdateReconnectingTimer()
        {
            if (reconnectEnabled && status == ClientStatus.Disconnected) timerReconnecting.Start();
            else timerReconnecting.Stop();
        }

        private void UpdateData(object sender, EventArgs e)
        {
            ReadDataFromPLC();
            WriteDataToPLC();
        }

        private void ReadDataFromPLC()
        {
            byte[] buffer = new byte[ReadDataBufferSize];

            StatusCode = client.DBRead(ReadDBNumber, ReadDataBufferOffset, ReadDataBufferSize, buffer);
            Status = StatusCode == 0 ? ClientStatus.Connected : ClientStatus.Disconnected;
            if (Status == ClientStatus.Disconnected) return;

            LiveUInt = S7.GetUIntAt(buffer, LiveUIntOffset);
            //ReadDataBuffer = buffer;
        }

        private void WriteDataToPLC()
        {
            if (Status != ClientStatus.Connected) return;

            client.DBWrite(WriteDBNumber, WriteDataBufferOffset, WriteDataBufferSize, WriteDataBuffer);
        }
    }
}
