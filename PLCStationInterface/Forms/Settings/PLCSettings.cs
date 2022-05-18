using PLCStationInterface.Classes;
using PLCStationInterface.Forms.MessageBoxes;
using PLCStationInterface.JDO;
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
        private PLCSettingsJDO _PLCSettings;

        private string ErrorMessageBoxTitle = "";
        private string[] Errors = new string[13];

        private string MessageMessageBoxTitle = "";
        private string Message = "";

        public PLCSettings(PLCSettingsJDO plcSettings)
        {
            InitializeComponent();

            Translator.LanguageChanged += Translate;

            _PLCSettings = plcSettings;

            SetValuesFromJasonToControls(_PLCSettings);
        }

        private void Translate(object sender, Language e)
        {

            if (Translator.Language == Language.CZ)
            {
                #region Controls Texts

                    #region Main

                        Text = "Nastavení PLC";
                        lblTitle.Text = "Nastavení PLC";

                    #endregion

                    #region General Settings

                        lblGeneralSettingsTitle.Text = "Obecné Nastavení";
                        lblIPAddress.Text = "IP Adresa:";
                        lblUpdateInterval.Text = "Interval Aktualizace:";
                        lblOLCRack.Text = "PLC Rack";
                        lblPLCSlot.Text = "PLC Slot";

                    #endregion

                    #region LiveUInt Settings

                        lblLiveUIntSettingsTitle.Text = "Nastavení Live UIntu";
                        lblLiveUIntDB.Text = "DB Live UIntu:";
                        lblLiveUIntOffset.Text = "Offset Live UIntu:";
                        lblLiveUIntSize.Text = "Délka Live UIntu:";

                    #endregion

                    #region Read / Write Settings

                        lblReadWriteSettingsTitle.Text = "Nastavení Čtení / Zápisu";
                        lblReadDB.Text = "DB pro Čtení:";
                        lblReadDataOffset.Text = "Offset Dat pro Čtení";
                        lblReadDataSize.Text = "Délka Dat pro Čtení:";

                        lblWriteDB.Text = "DB pro Zápis:";
                        lblWriteDataOffset.Text = "Offset Dat pro Zápis:";
                        lblWriteDataSize.Text = "Délka Dat pro Zápis:";

                    #endregion

                    #region Buttons

                        btnConnect.Text = "Připojit";
                        btnDisconnect.Text = "Odpojit";
                        btnApply.Text = "Použít";

                    #endregion

                #endregion

                #region Errors Texts

                    ErrorMessageBoxTitle = "Chyba Uživatelského Vstupu";

                    #region General Settings

                        Errors[0] = "IP Adresa není ve správném tvaru. Např. 192.168.1.5";
                        Errors[1] = "Interval Aktualizace není ve správném tvaru. Interval musí být číslo větší než nula. Např. 150";
                        Errors[2] = "PLC Rack není ve správném tvaru. Interval musí být kladné číslo nebo 0. Např. 0";
                        Errors[3] = "PLC Slot není ve správném tvaru. Interval musí být kladné číslo nebo 0. Např. 0";

                    #endregion

                    #region LiveUInt Settings

                        Errors[4] = "Číslo Datového Bloku Live UIntu není ve správném tvaru. Interval musí být číslo větší než nula. Např. 10";
                        Errors[5] = "Offset Live UIntu není ve správném tvaru. Interval musí být kladné číslo nebo 0. Např. 1";
                        Errors[6] = "Délka Live UIntu není ve správném tvaru. Interval musí být číslo větší než nula. Např. 2";

                    #endregion

                    #region Read / Write Settings

                        Errors[7] = "Číslo Datového Bloku pro Čtení Dat není ve správném tvaru. Interval musí být číslo větší než nula. Např. 10";
                        Errors[8] = "Číslo Offsetu pro Čtení Dat není ve správném tvaru. Interval musí být kladné číslo nebo 0. Např. 1";
                        Errors[9] = "Délka Dat pro Čtení není ve správném tvaru. Interval musí být číslo větší než nula. Např. 2";

                        Errors[10] = "Číslo Datového Bloku pro Zápis Dat není ve správném tvaru. Interval musí být číslo větší než nula. Např. 10";
                        Errors[11] = "Číslo Offsetu pro Zápis Dat není ve správném tvaru. Interval musí být kladné číslo nebo 0. Např. 1";
                        Errors[12] = "Délka Dat pro Zápis není ve správném tvaru. Interval musí být číslo větší než nula. Např. 2";

                #endregion

                #endregion

                #region Messages Texts

                    MessageMessageBoxTitle = "Informace";

                    Message = "Data byla úspěšně uložena.";

                #endregion
            }
            else if (Translator.Language == Language.ENG)
            {
                #region Controls Texts

                    #region Main

                        Text = "PLC Settings";
                        lblTitle.Text = "PLC Settings";

                    #endregion

                    #region General Settings

                        lblGeneralSettingsTitle.Text = "General Settings:";
                        lblIPAddress.Text = "IP Address:";
                        lblUpdateInterval.Text = "Update Interval:";
                        lblOLCRack.Text = "PLC Rack";
                        lblPLCSlot.Text = "PLC Slot";

                    #endregion

                    #region LiveUInt Settings

                        lblLiveUIntSettingsTitle.Text = "Live UInt Settings";
                        lblLiveUIntDB.Text = "Live UInt DB:";
                        lblLiveUIntOffset.Text = "Live UInt Offset:";
                        lblLiveUIntSize.Text = "Live UInt Size:";

                    #endregion

                    #region Read / Write Settings

                        lblReadWriteSettingsTitle.Text = "Read / Write Settings";
                        lblReadDB.Text = "Read DB:";
                        lblReadDataOffset.Text = "Read Data Offset:";
                        lblReadDataSize.Text = "Read Data Size:";

                        lblWriteDB.Text = "Write DB:";
                        lblWriteDataOffset.Text = "Write Data Offset:";
                        lblWriteDataSize.Text = "Write Data Size:";

                    #endregion

                    #region Buttons

                        btnConnect.Text = "Connect";
                        btnDisconnect.Text = "Disconnect";
                        btnApply.Text = "Apply";

                #endregion

                #endregion

                #region Errors Texts

                    ErrorMessageBoxTitle = "Chyba Uživatelského Vstupu";

                    #region General Settings

                        Errors[0] = "IP Address is not in correct format. Eg. 192.168.1.5";
                        Errors[1] = "Update Interval is not in correct format. Interval must be number greather than zero. Eg. Např. 150";
                        Errors[2] = "PLC Rack is not in correct format. Interval must be positive number or 0. Eg. 0";
                        Errors[3] = "PLC Slot is not in correct format. Interval must be positive number or 0. Eg. 0";

                    #endregion

                    #region LiveUInt Settings

                        Errors[4] = "Live Uint Data Block Number is not in correct format. Interval must be number greather than zero. Eg. Např. 10";
                        Errors[5] = "Live UInt Offset is not in correct format. Interval must be positive number or 0. Eg. 1";
                        Errors[6] = "Live UInt Size is not in correct format. Interval must be positive number or 0. Eg. 2";

                    #endregion

                    #region Read / Write Settings

                        Errors[7] = "Read Data Block Number is not in correct format. Interval must be number greather than zero. Eg. Např. 10";
                        Errors[8] = "Read Data Offset is not in correct format. Interval must be positive number or 0. Eg. 1";
                        Errors[9] = "Read Data Size is not in correct format. Interval must be positive number or 0. Eg. 2";

                        Errors[10] = "Write Data Block Number is not in correct format. Interval must be number greather than zero. Eg. Např. 10";
                        Errors[11] = "Write Data Offset is not in correct format. Interval must be positive number or 0. Eg. 1";
                        Errors[12] = "Write Data Size is not in correct format. Interval must be positive number or 0. Eg. 2";

                #endregion

                #endregion

                #region Messages Texts

                    MessageMessageBoxTitle = "Information";

                    Message = "Data was correctly saved.";

                #endregion
            }
        }

        private void PLCSettings_VisibleChanged(object sender, EventArgs e)
        {
            SetValuesFromJasonToControls(_PLCSettings);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //if (LoginBox.CheckLogin() == false) return;

            if (CheckGeneralSettings(ref _PLCSettings)) return;
            if (CheckLiveUIntSettings(ref _PLCSettings)) return;
            if (CheckReadWriteSettings(ref _PLCSettings)) return;

            CustomMessageBox.ShowPopup(MessageMessageBoxTitle, Message);
        }

        private bool CheckGeneralSettings(ref PLCSettingsJDO Settings)
        {
            int value = 0;

            if (ipab.IPAddressValid)
            {
                _PLCSettings.IPAddress = ipab.IPAddress;
            }
            else
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[0]);
                return true;
            }

            if (int.TryParse(tbUpdateInterval.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[1]);
                return true;
            }
            Settings.UpdateInterval = value;

            if (int.TryParse(tbPLCRack.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[2]);
                return true;
            }
            Settings.Rack = value;

            if (int.TryParse(tbPLCSlot.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[3]);
                return true;
            }
            Settings.Slot = value;

            return false;
        }

        private bool CheckLiveUIntSettings(ref PLCSettingsJDO Settings)
        {
            int value = 0;

            if (int.TryParse(tbLiveUIntDB.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[4]);
                return true;
            }
            Settings.LiveUIntDBNumber = value;

            if (int.TryParse(tbLiveUIntOffset.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[5]);
                return true;
            }
            Settings.LiveUIntOffset = value;

            if (int.TryParse(tbLiveUIntSize.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[6]);
                return true;
            }
            Settings.LiveUIntBufferSize = value;

            return false;
        }

        private bool CheckReadWriteSettings(ref PLCSettingsJDO Settings)
        {
            int value = 0;

            if (int.TryParse(tbReadDB.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[7]);
                return true;
            }
            Settings.ReadDBNumber = value;

            if (int.TryParse(tbReadDataOffset.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[8]);
                return true;
            }
            Settings.ReadDataBufferOffset = value;

            if (int.TryParse(tbReadDataSize.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[9]);
                return true;
            }
            Settings.ReadDataBufferSize = value;

            if (int.TryParse(tbWriteDB.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[10]);
                return true;
            }
            Settings.WriteDBNumber = value;

            if (int.TryParse(tbWriteDataOffset.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[11]);
                return true;
            }
            Settings.WriteDataBufferOffset = value;

            if (int.TryParse(tbWriteDataSize.Text, out value) == false)
            {
                CustomMessageBox.ShowPopup(ErrorMessageBoxTitle, Errors[12]);
                return true;
            }
            Settings.WriteDataBufferSize = value;

            return false;
        }

        private void SetValuesFromJasonToControls(PLCSettingsJDO Settings)
        {
            ipab.IPAddress = Settings.IPAddress;
            tbUpdateInterval.Text = Settings.UpdateInterval.ToString();
            tbPLCRack.Text = Settings.Rack.ToString();
            tbPLCSlot.Text = Settings.Slot.ToString();

            tbLiveUIntDB.Text = Settings.LiveUIntDBNumber.ToString();
            tbLiveUIntOffset.Text = Settings.LiveUIntOffset.ToString();
            tbLiveUIntSize.Text = Settings.LiveUIntBufferSize.ToString();

            tbReadDB.Text = Settings.ReadDBNumber.ToString();
            tbReadDataOffset.Text = Settings.ReadDataBufferOffset.ToString();
            tbReadDataSize.Text = Settings.ReadDataBufferSize.ToString();

            tbWriteDB.Text = Settings.WriteDBNumber.ToString();
            tbWriteDataOffset.Text = Settings.WriteDataBufferOffset.ToString();
            tbWriteDataSize.Text = Settings.WriteDataBufferSize.ToString();
        }
    }
}
