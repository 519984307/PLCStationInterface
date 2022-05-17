using System;
using System.Collections.Generic;
using System.Text;

namespace PLCStationInterface.JDO.SettingsLogin
{
    public class SettingsLoginJDO
    {
        public string[] UserNames { get; set; } = new string[2] { "Admin", "Maint"};
        public string[] Passwords { get; set; } = new string[2] { "8adxp5jq", "Mnt3012"};
    }
}
