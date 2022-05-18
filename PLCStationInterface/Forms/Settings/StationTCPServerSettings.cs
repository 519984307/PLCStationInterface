﻿using PLCStationInterface.UDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLCStationInterface.Forms
{
    public partial class StationTCPServerSettings : Form
    {
        private SettingsJDO Settings;

        public StationTCPServerSettings(SettingsJDO settings)
        {
            InitializeComponent();

            Settings = settings;
        }
    }
}
