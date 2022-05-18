using System;
using System.Collections.Generic;
using System.Text;

namespace PLCStationInterface.JDO
{
    public class TCPServerSettingsJDO
    {
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public int BroadcastInterval { get; set; }
    }
}
