using PLCStationInterface.Classes;
using PLCStationInterface.Classes.PLC;
using PLCStationInterface.UDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualInspection.Utils;
using VisualInspection.Utils.Net;

namespace PLCStationInterface.Forms
{
    public partial class Diagnostics : Form
    {
        private PLC PLC;

        public Diagnostics(PLC plc)
        {
            InitializeComponent();

            PLC = plc;  

            Translator.LanguageChanged += Translate;

            PLCStatusDot.Client = PLC;

            PLC.LiveUIntStatusCodeChanged += LiveUIntStatusCode_Changed;
            PLC.ReadStatusCodeChanged += ReadStatusCode_Changed;
            PLC.WriteStatusCodeChanged += WriteStatusCode_Changed;
            PLC.LiveUIntChanged += LiveUInt_Changed;
        }

        private void WriteStatusCode_Changed(object sender, int e)
        {
            lblWriteStatusCodeData.InvokeIfRequired((label) => label.Text = e.ToString());

            tbWriteMassage.InvokeIfRequired(label => label.Text = PLC.GetErrorMessage(e));
        }

        private void ReadStatusCode_Changed(object sender, int e)
        {
            lblReadStatusCodeData.InvokeIfRequired((label) => label.Text = e.ToString());

            tbReadMessage.InvokeIfRequired(label => label.Text = PLC.GetErrorMessage(e));
        }

        private void LiveUIntStatusCode_Changed(object sender, int e)
        {
            lblLiveUIntStatusCodeData.InvokeIfRequired((label) => label.Text = e.ToString());

            tbLiveUIntMessage.InvokeIfRequired(label => label.Text = PLC.GetErrorMessage(e));
        }

        private void LiveUInt_Changed(object sender, ushort e)
        {
            lblPLCStatusCodeData.InvokeIfRequired((label) => label.Text = e.ToString());
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                lblTCPServerStatus.Text = "Status Serveru Stanic:";
                lblPLCStatus.Text = "Status PLC:";
            }
            else if (Translator.Language == Language.ENG)
            {
                lblTCPServerStatus.Text = "Station Server Status:";
                lblPLCStatus.Text = "PLC Status:";
            }
        }
    }
}
