using PLCStationInterface.Classes;
using PLCStationInterface.Classes.PLC;
using PLCStationInterface.Forms;
using PLCStationInterface.Forms.MessageBoxes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PLCStationInterface
{
    public partial class MainMenu : Form
    {
        private readonly Color SELECTED_BUTTON_COLOR = Color.FromArgb(128, 0, 128);
        private readonly Color DEFAULT_BUTTON_COLOR = Color.FromArgb(64,64,64);

        private readonly string SETTING_FILE_PATH = "settings.json";
        private readonly string ENCRIPTION_KEY = "W]rs6^%]";

        private PLCSettings plcSettings;
        private StationTCPServerSettings stationTCPServerSettings;
        private Diagnostics diagnostics;
        private AboutApp aboutApp;
        private PLC plc;

        private bool mouseDown;
        private Point lastLocation;

        private Button activeButton;
        public Button ActiveButton
        {
            get { return activeButton; }
            set 
            {
                if (activeButton != null)
                {
                    activeButton.BackColor = DEFAULT_BUTTON_COLOR;
                }

                activeButton = value;

                activeButton.BackColor = SELECTED_BUTTON_COLOR;
            }
        }

        private Form activePage;
        public Form ActivePage
        {
            get { return activePage; }
            set
            {
                if (activePage != null)
                {
                    activePage.Hide();
                }

                activePage = value;

                activePage.Show();
            }
        }

        private Dictionary<Button, Form> pages = new Dictionary<Button, Form>();

        public MainMenu()
        {
            InitializeComponent();

            plc = new PLC();
            plcSettings = new PLCSettings();
            stationTCPServerSettings = new StationTCPServerSettings();
            diagnostics = new Diagnostics();
            aboutApp = new AboutApp();

            //ReadSettingsJSON(SETTING_FILE_PATH, ENCRIPTION_KEY);

            Translator.LanguageChanged += Translate;

            AddPage(plcSettings);
            AddPage(stationTCPServerSettings);
            AddPage(diagnostics);
            AddPage(aboutApp);

            Translator.Language = Language.ENG;

            //loginBox.LogedChanged += Login_Changed;

            ActiveButton = btnAboutApp;
            ActivePage = aboutApp;

            pages.Add(btnPLCSettings, plcSettings);
            pages.Add(btnStationTCPServerSettings, stationTCPServerSettings);
            pages.Add(btnDiagnostics, diagnostics);
            pages.Add(btnAboutApp, aboutApp);


            //DataToServer.StationInformation.StationName = Settings.StationSettings.StationName;
            //DataToServer.StationInformation.StationID = Settings.StationSettings.StationID;
            //DataToServer.NonOperation = 0;
            //DataToServer.UserInformation.Status = LoginResult.NoLogged;

            //mySQLDatabase.ExceptionChanged += MySqlExceptionChanged_ShowPopUp;
            //readerTCPClient.ExceptionChanged += TCPClientExceptionChanged_ShowPopUp;
            //serverTCPClient.ExceptionChanged += TCPClientExceptionChanged_ShowPopUp;
            //interfacTCPIPClient.ExceptionChanged += TCPClientExceptionChanged_ShowPopUp;


            // ODSTRANIT PRO DEAKTIVACI AUTOMATICKÉHO PŘIHLAŠOVÁNÍ
            //loginBox.LogedIn = true;

            plc.IPAddress = "192.168.0.1";
            plc.UpdateInterval = 150;
            plc.Rack = 0;
            plc.Slot = 1;
            plc.WriteDBNumber = 10;
            plc.ReadDBNumber = 10;
            plc.ReadDataBufferSize = 2;
            plc.WriteDataBufferOffset = 24;
            plc.WriteDataBufferSize = 9;

            plc.WriteDataBuffer = new byte[plc.WriteDataBufferSize];
            plc.WriteDataBuffer[8] = 0;

            plc.Connect();


        }

        private void TCPClientExceptionChanged_ShowPopUp(object sender, Exception e)
        {
            Invoke((MethodInvoker)delegate ()
            {
                CustomMessageBox.ShowPopup("TCPIP Client Error", e.Message);
            });
        }

        private void AddPage(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(form);
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                Text = "PLC <--> Station Interface";
                lblTitle.Text = "NMP Station Tire Inspection";
                btnPLCSettings.Text = "Přihlášení do VII";
                btnStationTCPServerSettings.Text = "Změna Hesla";
                btnDiagnostics.Text = "Diagnostika";
                btnAboutApp.Text = "O Aplikaci";
            }
            else if (Translator.Language == Language.ENG)
            {
                Text = "PLC <--> Station Interface";
                lblTitle.Text = "NMP Station Tire Inspection";
                btnPLCSettings.Text = "Login to VII";
                btnStationTCPServerSettings.Text = "Change Password";
                btnDiagnostics.Text = "Diagnostics";
                btnAboutApp.Text = "About App";
            }
        }

        private void ReadSettingsJSON(string Path, string CryptKey)
        {
            if (File.Exists(Path))
            {
                //EncriptionManager.DecryptFile(Path, CryptKey);
                //Settings = SettingsJDO.Deserialize(File.ReadAllText(Path));
            }
            else
            {
                //File.WriteAllText(Path, Settings.Serialize());
            }

            EncriptionManager.EncryptFile(Path, CryptKey);
        }

        private void WriteSettingsJSON(string Path, string CryptKey)
        {
            //EncriptionManager.DecryptFile(Path, CryptKey);
            //File.WriteAllText(Path, Settings.Serialize());
            //EncriptionManager.EncryptFile(Path, CryptKey);
        }

        private void pbLoged_Click(object sender, EventArgs e)
        {
            //if(loginBox.LogedIn == false)
            //{
            //    loginBox.ShowLoginDialog();
            //}
            //else
            //{
            //    loginBox.LogedIn = false;
            //}
        }

        private void Login_Changed(object sender, bool e)
        {
            if (e == true)
            {
                pbLoged.Image.Dispose();
                pbLoged.Image = Properties.Resources.logout;
            }
            else
            {
                pbLoged.Image.Dispose();
                pbLoged.Image = Properties.Resources.login;
            }
        }

        private void pbLanguage_Click(object sender, EventArgs e)
        {
            if (Translator.Language == Language.CZ)
            {
                pbLanguage.Image.Dispose();
                pbLanguage.Image = Properties.Resources.cz;
                Translator.Language = Language.ENG;
            }
            else
            {
                pbLanguage.Image.Dispose();
                pbLanguage.Image = Properties.Resources.gb;
                Translator.Language = Language.CZ;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //login.SetStopNonOPInfosAndSendToDB();

            Application.Exit();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteSettingsJSON(SETTING_FILE_PATH, ENCRIPTION_KEY);
        }

        private void pagesBtn_Click(object sender, EventArgs e)
        {
            ActiveButton = sender as Button;
            ActivePage = pages[ActiveButton];
        }
    }
}
