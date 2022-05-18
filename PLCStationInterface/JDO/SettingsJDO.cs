using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using PLCStationInterface.JDO;
using PLCStationInterface.JDO.SettingsLogin;

namespace PLCStationInterface.UDT
{
    public class SettingsJDO
    {
        public PLCSettingsJDO PLCSettings { get; set; } = new PLCSettingsJDO();
        public TCPServerSettingsJDO TCPServerSettings { get; set; } = new TCPServerSettingsJDO();
        public SettingsLoginJDO SettingsLogin { get; set; } = new SettingsLoginJDO();

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public static SettingsJDO Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<SettingsJDO>(json);
        }
    }
}
