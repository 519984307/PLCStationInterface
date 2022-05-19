
namespace PLCStationInterface
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnPLCSettings = new System.Windows.Forms.Button();
            this.btnStationTCPServerSettings = new System.Windows.Forms.Button();
            this.btnDiagnostics = new System.Windows.Forms.Button();
            this.pbLanguage = new System.Windows.Forms.PictureBox();
            this.p0 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.btnAboutApp = new System.Windows.Forms.Button();
            this.tst = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Panel();
            this.pbLoged = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.Panel();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguage)).BeginInit();
            this.p0.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoged)).BeginInit();
            this.p1.SuspendLayout();
            this.pMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::PLCStationInterface.Properties.Resources.NexenLogo;
            this.pbLogo.Location = new System.Drawing.Point(17, 8);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(260, 133);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnPLCSettings
            // 
            this.btnPLCSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPLCSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPLCSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPLCSettings.FlatAppearance.BorderSize = 0;
            this.btnPLCSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnPLCSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLCSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPLCSettings.ForeColor = System.Drawing.Color.White;
            this.btnPLCSettings.Location = new System.Drawing.Point(0, 0);
            this.btnPLCSettings.Name = "btnPLCSettings";
            this.btnPLCSettings.Size = new System.Drawing.Size(295, 61);
            this.btnPLCSettings.TabIndex = 1;
            this.btnPLCSettings.Text = "PLC Settings";
            this.btnPLCSettings.UseVisualStyleBackColor = false;
            this.btnPLCSettings.Click += new System.EventHandler(this.pagesBtn_Click);
            // 
            // btnStationTCPServerSettings
            // 
            this.btnStationTCPServerSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStationTCPServerSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStationTCPServerSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStationTCPServerSettings.FlatAppearance.BorderSize = 0;
            this.btnStationTCPServerSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnStationTCPServerSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStationTCPServerSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStationTCPServerSettings.ForeColor = System.Drawing.Color.White;
            this.btnStationTCPServerSettings.Location = new System.Drawing.Point(0, 61);
            this.btnStationTCPServerSettings.Name = "btnStationTCPServerSettings";
            this.btnStationTCPServerSettings.Size = new System.Drawing.Size(295, 61);
            this.btnStationTCPServerSettings.TabIndex = 2;
            this.btnStationTCPServerSettings.Text = "Station TCP Server Settings";
            this.btnStationTCPServerSettings.UseVisualStyleBackColor = false;
            this.btnStationTCPServerSettings.Click += new System.EventHandler(this.pagesBtn_Click);
            // 
            // btnDiagnostics
            // 
            this.btnDiagnostics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiagnostics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiagnostics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDiagnostics.FlatAppearance.BorderSize = 0;
            this.btnDiagnostics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDiagnostics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnostics.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiagnostics.ForeColor = System.Drawing.Color.White;
            this.btnDiagnostics.Location = new System.Drawing.Point(0, 122);
            this.btnDiagnostics.Name = "btnDiagnostics";
            this.btnDiagnostics.Size = new System.Drawing.Size(295, 61);
            this.btnDiagnostics.TabIndex = 3;
            this.btnDiagnostics.Text = "Diagnostics";
            this.btnDiagnostics.UseVisualStyleBackColor = false;
            this.btnDiagnostics.Click += new System.EventHandler(this.pagesBtn_Click);
            // 
            // pbLanguage
            // 
            this.pbLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLanguage.Image = global::PLCStationInterface.Properties.Resources.cz;
            this.pbLanguage.Location = new System.Drawing.Point(33, 17);
            this.pbLanguage.Name = "pbLanguage";
            this.pbLanguage.Size = new System.Drawing.Size(100, 50);
            this.pbLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLanguage.TabIndex = 4;
            this.pbLanguage.TabStop = false;
            this.pbLanguage.Click += new System.EventHandler(this.pbLanguage_Click);
            // 
            // p0
            // 
            this.p0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p0.Controls.Add(this.p3);
            this.p0.Controls.Add(this.p2);
            this.p0.Controls.Add(this.p1);
            this.p0.Dock = System.Windows.Forms.DockStyle.Left;
            this.p0.Location = new System.Drawing.Point(0, 37);
            this.p0.Name = "p0";
            this.p0.Size = new System.Drawing.Size(297, 817);
            this.p0.TabIndex = 6;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p3.Controls.Add(this.btnAboutApp);
            this.p3.Controls.Add(this.tst);
            this.p3.Controls.Add(this.btnDiagnostics);
            this.p3.Controls.Add(this.btnStationTCPServerSettings);
            this.p3.Controls.Add(this.btnPLCSettings);
            this.p3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p3.Location = new System.Drawing.Point(0, 233);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(295, 582);
            this.p3.TabIndex = 8;
            // 
            // btnAboutApp
            // 
            this.btnAboutApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAboutApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAboutApp.FlatAppearance.BorderSize = 0;
            this.btnAboutApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAboutApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutApp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAboutApp.ForeColor = System.Drawing.Color.White;
            this.btnAboutApp.Location = new System.Drawing.Point(0, 244);
            this.btnAboutApp.Name = "btnAboutApp";
            this.btnAboutApp.Size = new System.Drawing.Size(295, 61);
            this.btnAboutApp.TabIndex = 11;
            this.btnAboutApp.Text = "About App";
            this.btnAboutApp.UseVisualStyleBackColor = false;
            this.btnAboutApp.Click += new System.EventHandler(this.pagesBtn_Click);
            // 
            // tst
            // 
            this.tst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tst.Dock = System.Windows.Forms.DockStyle.Top;
            this.tst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tst.FlatAppearance.BorderSize = 0;
            this.tst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.tst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tst.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tst.ForeColor = System.Drawing.Color.White;
            this.tst.Location = new System.Drawing.Point(0, 183);
            this.tst.Name = "tst";
            this.tst.Size = new System.Drawing.Size(295, 61);
            this.tst.TabIndex = 12;
            this.tst.Text = "Station Interface Data Status";
            this.tst.UseVisualStyleBackColor = false;
            this.tst.Click += new System.EventHandler(this.pagesBtn_Click);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p2.Controls.Add(this.pbLoged);
            this.p2.Controls.Add(this.pbLanguage);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 151);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(295, 82);
            this.p2.TabIndex = 7;
            // 
            // pbLoged
            // 
            this.pbLoged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLoged.Image = global::PLCStationInterface.Properties.Resources.login;
            this.pbLoged.Location = new System.Drawing.Point(162, 22);
            this.pbLoged.Name = "pbLoged";
            this.pbLoged.Size = new System.Drawing.Size(99, 40);
            this.pbLoged.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoged.TabIndex = 5;
            this.pbLoged.TabStop = false;
            this.pbLoged.Click += new System.EventHandler(this.pbLoged_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p1.Controls.Add(this.pbLogo);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(295, 151);
            this.p1.TabIndex = 6;
            // 
            // pagePanel
            // 
            this.pagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePanel.Location = new System.Drawing.Point(297, 37);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(439, 817);
            this.pagePanel.TabIndex = 7;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMain.Controls.Add(this.panel2);
            this.pMain.Controls.Add(this.panel1);
            this.pMain.Controls.Add(this.btnClose);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(736, 37);
            this.pMain.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(41, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 35);
            this.panel2.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(656, 35);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "PLC <--> Station Interface";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 35);
            this.panel1.TabIndex = 3;
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::PLCStationInterface.Properties.Resources._2760214;
            this.pbIcon.Location = new System.Drawing.Point(6, 6);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(27, 22);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            this.pbIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.pbIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            this.pbIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(697, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(736, 854);
            this.Controls.Add(this.pagePanel);
            this.Controls.Add(this.p0);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Database Administration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguage)).EndInit();
            this.p0.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoged)).EndInit();
            this.p1.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnPLCSettings;
        private System.Windows.Forms.Button btnStationTCPServerSettings;
        private System.Windows.Forms.Button btnDiagnostics;
        private System.Windows.Forms.PictureBox pbLanguage;
        private System.Windows.Forms.Panel p0;
        private System.Windows.Forms.Panel pagePanel;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.PictureBox pbLoged;
        private System.Windows.Forms.Button btnAboutApp;
        private System.Windows.Forms.Button tst;
    }
}

