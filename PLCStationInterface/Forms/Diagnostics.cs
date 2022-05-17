using PLCStationInterface.Classes;
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
        public Diagnostics()
        {
            InitializeComponent();

            Translator.LanguageChanged += Translate;
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
