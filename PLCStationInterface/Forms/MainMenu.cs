using PLCStationInterface.Classes;
using PLCStationInterface.Classes.PLC;
using PLCStationInterface.Forms;
using PLCStationInterface.Forms.MessageBoxes;
using PLCStationInterface.Forms.SettingsLogin;
using PLCStationInterface.JDO;
using PLCStationInterface.UDT;
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

        private SettingsJDO settings { get; set; } = new SettingsJDO();

        private PLCSettings plcSettings;
        private StationTCPServerSettings stationTCPServerSettings;
        private Diagnostics diagnostics;
        private AboutApp aboutApp;
        private PLC plc;
        private LoginBox loginBox;

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

            ReadSettingsJSON(SETTING_FILE_PATH, ENCRIPTION_KEY);

            plc = new PLC();
            loginBox = new LoginBox(settings.SettingsLogin);
            plcSettings = new PLCSettings(settings.PLCSettings);
            stationTCPServerSettings = new StationTCPServerSettings(settings);
            diagnostics = new Diagnostics(plc);
            aboutApp = new AboutApp();

            Translator.LanguageChanged += Translate;

            AddPage(plcSettings);
            AddPage(stationTCPServerSettings);
            AddPage(diagnostics);
            AddPage(aboutApp);

            Translator.Language = Language.ENG;

            loginBox.LogedChanged += Login_Changed;

            ActiveButton = btnAboutApp;
            ActivePage = aboutApp;

            pages.Add(btnPLCSettings, plcSettings);
            pages.Add(btnStationTCPServerSettings, stationTCPServerSettings);
            pages.Add(btnDiagnostics, diagnostics);
            pages.Add(btnAboutApp, aboutApp);

            // ODSTRANIT PRO DEAKTIVACI AUTOMATICKÉHO PŘIHLAŠOVÁNÍ
            loginBox.LogedIn = true;

            SetPLCDataAndConnect(settings.PLCSettings, ref plc);
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
                EncriptionManager.DecryptFile(Path, CryptKey);
                settings = SettingsJDO.Deserialize(File.ReadAllText(Path));
            }
            else
            {
                File.WriteAllText(Path, settings.Serialize());
            }

            EncriptionManager.EncryptFile(Path, CryptKey);
        }

        private void WriteSettingsJSON(string Path, string CryptKey)
        {
            EncriptionManager.DecryptFile(Path, CryptKey);
            File.WriteAllText(Path, settings.Serialize());
            EncriptionManager.EncryptFile(Path, CryptKey);
        }

        private void pbLoged_Click(object sender, EventArgs e)
        {
            if (loginBox.LogedIn == false)
            {
                loginBox.ShowLoginDialog();
            }
            else
            {
                loginBox.LogedIn = false;
            }
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

        private void SetPLCDataAndConnect(PLCSettingsJDO Settings, ref PLC PLC)
        {
            PLC.IPAddress = Settings.IPAddress;
            PLC.UpdateInterval = Settings.UpdateInterval;
            PLC.Rack = Settings.Rack;
            PLC.Slot = Settings.Slot;
            PLC.ReconnectInterval = 4000;
            PLC.ReconnectEnabled = true;

            PLC.LiveUIntDBNumber = Settings.LiveUIntDBNumber;
            PLC.LiveUIntOffset = Settings.LiveUIntOffset;
            PLC.LiveUIntBufferSize = Settings.LiveUIntBufferSize;

            PLC.ReadDBNumber = Settings.ReadDBNumber;
            PLC.ReadDataBufferOffset = Settings.ReadDataBufferOffset;
            PLC.ReadDataBufferSize = Settings.ReadDataBufferSize;

            PLC.WriteDBNumber = Settings.WriteDBNumber;
            PLC.WriteDataBufferOffset = Settings.WriteDataBufferOffset;
            PLC.WriteDataBufferSize = Settings.WriteDataBufferSize;

#pragma warning disable CS4014
            PLC.ConnectAsync();
#pragma warning restore CS4014
        }
    }
}
