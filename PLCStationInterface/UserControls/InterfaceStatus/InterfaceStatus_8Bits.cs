using PLCStationInterface.UserControls.InterfaceStatus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLCStationInterface.UserControls
{
    public partial class InterfaceStatus_8Bits : UserControl
    {
        List<InterfaceStatusDot> DotsStatus = new List<InterfaceStatusDot>();

        public InterfaceStatus_8Bits()
        {
            InitializeComponent();

            DotsStatus.Add(interfaceStatusDot1);
            DotsStatus.Add(interfaceStatusDot2);
            DotsStatus.Add(interfaceStatusDot3);
            DotsStatus.Add(interfaceStatusDot4);
            DotsStatus.Add(interfaceStatusDot5);
            DotsStatus.Add(interfaceStatusDot6);
            DotsStatus.Add(interfaceStatusDot7);
            DotsStatus.Add(interfaceStatusDot8);

        }

        public bool SetStatus(ushort Index, bool Value)
        {
            if (Index >= DotsStatus.Count) return false;

            DotsStatus[Index].Status = Value;
            return true;
        }
    }
}
