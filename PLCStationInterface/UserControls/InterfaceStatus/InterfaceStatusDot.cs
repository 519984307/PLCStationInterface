using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLCStationInterface.UserControls.InterfaceStatus
{
    public partial class InterfaceStatusDot : UserControl
    {
        private static readonly Image GreenDot = Properties.Resources.GreenDot_3;
        private static readonly Image WhiteDot = Properties.Resources.WhiteDot_2;

        private bool status;

        public bool Status
        {
            get { return status; }
            set 
            { 
                status = value;
                
                if(status) pb.Image = GreenDot;
                else pb.Image = WhiteDot;
            }
        }

        public InterfaceStatusDot()
        {
            InitializeComponent();
        }
    }
}
