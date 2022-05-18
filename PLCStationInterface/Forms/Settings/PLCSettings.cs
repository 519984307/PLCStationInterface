using PLCStationInterface.Classes;
using PLCStationInterface.Forms.MessageBoxes;
using PLCStationInterface.UDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLCStationInterface.Forms
{
    public partial class PLCSettings : Form
    {
        private SettingsJDO Settings;

        private string ErrorMessageBoxTitle = "";
        private string[] Errors = new string[7];

        private string MessageMessageBoxTitle = "";
        private string Message = "";

        public PLCSettings(SettingsJDO settings)
        {
            InitializeComponent();

            Settings = settings;

            SetInitValues();
        }

        private void PLCSettings_VisibleChanged(object sender, EventArgs e)
        {
            SetInitValues();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //if (LoginBox.CheckLogin() == false) return;

            if (CheckGeneralSettings()) return;

            //if (TextBoxHelper.TbInputIsText(tbDatabaseUserName))
            //{
            //    Settings.DatabaseSettings.DatabaseUserName = tbDatabaseUserName.Text;
            //}
            //else
            //{
            //    CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[5]);
            //    return;
            //}

            //if (tbDatabasePassword.Text != null && tbDatabasePassword.Text != "")
            //{
            //    Settings.DatabaseSettings.DatabasePassword = tbDatabasePassword.Text;
            //}
            //else
            //{
            //    CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[6]);
            //    return;
            //}

            //CustomMessageBox.ShowPopup(MessageMessageBoxTitle, Message);

            //MySQLDatabase.DatabaseName = Settings.DatabaseSettings.DatabaseName;
            //MySQLDatabase.IPAddress = Settings.DatabaseSettings.IPAddress;
            //MySQLDatabase.UserName = Settings.DatabaseSettings.DatabaseUserName;
            //MySQLDatabase.Password = Settings.DatabaseSettings.DatabasePassword;
        }

        private bool CheckGeneralSettings()
        {
            if (ipab.IPAddressValid)
            {
                Settings.PLCSettings.IPAddress = ipab.IPAddress;
            }
            else
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[0]);
                return true;
            }

            if (TextBoxHelper.TbInputIsNumber(tbUpdateInterval))
            {
                Settings.PLCSettings.UpdateInterval = int.Parse(tbUpdateInterval.Text);
            }
            else
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[1]);
                return true;
            }

            if (TextBoxHelper.TbInputIsNumber(tbPLCRack))
            {
                Settings.PLCSettings.Rack = int.Parse(tbPLCRack.Text);
            }
            else
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[2]);
                return true;
            }

            if (TextBoxHelper.TbInputIsNumber(tbPLCSlot))
            {
                Settings.PLCSettings.Slot = int.Parse(tbPLCSlot.Text);
            }
            else
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[4]);
                return true;
            }

            return false;
        }

        private void SetInitValues()
        {
            ipab.IPAddress = Settings.PLCSettings.IPAddress;
            tbUpdateInterval.Text = Settings.PLCSettings.UpdateInterval.ToString();
            tbPLCRack.Text = Settings.PLCSettings.Rack.ToString();
            tbPLCSlot.Text = Settings.PLCSettings.Slot.ToString();

            tbLiveUIntDB.Text = Settings.PLCSettings.LiveUIntDBNumber.ToString();
            tbLiveUIntOffset.Text = Settings.PLCSettings.LiveUIntOffset.ToString();
            tbLiveUIntSize.Text = Settings.PLCSettings.LiveUIntBufferSize.ToString();

            tbReadDB.Text = Settings.PLCSettings.ReadDBNumber.ToString();
            tbReadDataOffset.Text = Settings.PLCSettings.ReadDataBufferOffset.ToString();
            tbReadDataSize.Text = Settings.PLCSettings.ReadDataBufferSize.ToString();

            tbWriteDB.Text = Settings.PLCSettings.WriteDBNumber.ToString();
            tbWriteDataOffset.Text = Settings.PLCSettings.WriteDataBufferOffset.ToString();
            tbWriteDataSize.Text = Settings.PLCSettings.WriteDataBufferSize.ToString();
        }
    }
}
