namespace PLCStationInterface.Forms
{
    partial class PLCSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pMainTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pReadWriteSettings = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWriteDB = new System.Windows.Forms.Label();
            this.tbWriteDataOffset = new System.Windows.Forms.TextBox();
            this.tbReadDataOffset = new System.Windows.Forms.TextBox();
            this.tbWriteDB = new System.Windows.Forms.TextBox();
            this.tbReadDB = new System.Windows.Forms.TextBox();
            this.lblReadDataSize = new System.Windows.Forms.Label();
            this.lblReadDataOffset = new System.Windows.Forms.Label();
            this.lblReadDB = new System.Windows.Forms.Label();
            this.tbReadDataSize = new System.Windows.Forms.TextBox();
            this.lblWriteDataOffset = new System.Windows.Forms.Label();
            this.lblWriteDataSize = new System.Windows.Forms.Label();
            this.tbWriteDataSize = new System.Windows.Forms.TextBox();
            this.pReadWriteSettingsTitle = new System.Windows.Forms.Panel();
            this.lblReadWriteTitle = new System.Windows.Forms.Label();
            this.pLiveUIntSettings = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLiveUIntDB = new System.Windows.Forms.TextBox();
            this.lblLiveUIntDB = new System.Windows.Forms.Label();
            this.lblLiveUIntOffset = new System.Windows.Forms.Label();
            this.tbLiveUIntOffset = new System.Windows.Forms.TextBox();
            this.lblLiveUIntSize = new System.Windows.Forms.Label();
            this.tbLiveUIntSize = new System.Windows.Forms.TextBox();
            this.pLiveUIntSettingsTitle = new System.Windows.Forms.Panel();
            this.lblLiveUIntSettingsTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.pGeneralSettings = new System.Windows.Forms.Panel();
            this.tlpRackSlot = new System.Windows.Forms.TableLayoutPanel();
            this.tbPLCSlot = new System.Windows.Forms.TextBox();
            this.lblOLCRack = new System.Windows.Forms.Label();
            this.tbPLCRack = new System.Windows.Forms.TextBox();
            this.lblPLCSlot = new System.Windows.Forms.Label();
            this.tlpIPAddress = new System.Windows.Forms.TableLayoutPanel();
            this.tbUpdateInterval = new System.Windows.Forms.TextBox();
            this.lblUpdateInterval = new System.Windows.Forms.Label();
            this.ipab = new VisualInspection.App.UserControls.IPAddressBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.pGeneralSettingsTitle = new System.Windows.Forms.Panel();
            this.lblGeneralSettings = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDatabaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ipAddressBox = new VisualInspection.App.UserControls.IPAddressBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.pMainTitle.SuspendLayout();
            this.pReadWriteSettings.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.pReadWriteSettingsTitle.SuspendLayout();
            this.pLiveUIntSettings.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pLiveUIntSettingsTitle.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pGeneralSettings.SuspendLayout();
            this.tlpRackSlot.SuspendLayout();
            this.tlpIPAddress.SuspendLayout();
            this.pGeneralSettingsTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 386F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.pMainTitle, 1, 0);
            this.tlpMain.Controls.Add(this.pReadWriteSettings, 1, 3);
            this.tlpMain.Controls.Add(this.pLiveUIntSettings, 1, 2);
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tlpMain.Controls.Add(this.pGeneralSettings, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(439, 820);
            this.tlpMain.TabIndex = 3;
            // 
            // pMainTitle
            // 
            this.pMainTitle.Controls.Add(this.lblTitle);
            this.pMainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainTitle.Location = new System.Drawing.Point(29, 3);
            this.pMainTitle.Name = "pMainTitle";
            this.pMainTitle.Size = new System.Drawing.Size(380, 33);
            this.pMainTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "PLC Settings";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pReadWriteSettings
            // 
            this.pReadWriteSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pReadWriteSettings.Controls.Add(this.tableLayoutPanel6);
            this.pReadWriteSettings.Controls.Add(this.pReadWriteSettingsTitle);
            this.pReadWriteSettings.Location = new System.Drawing.Point(29, 373);
            this.pReadWriteSettings.Name = "pReadWriteSettings";
            this.pReadWriteSettings.Size = new System.Drawing.Size(380, 220);
            this.pReadWriteSettings.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lblWriteDB, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbWriteDataOffset, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.tbReadDataOffset, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.tbWriteDB, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tbReadDB, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblReadDataSize, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.lblReadDataOffset, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lblReadDB, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbReadDataSize, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.lblWriteDataOffset, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lblWriteDataSize, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.tbWriteDataSize, 1, 5);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 7;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(378, 185);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // lblWriteDB
            // 
            this.lblWriteDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWriteDB.AutoSize = true;
            this.lblWriteDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWriteDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWriteDB.Location = new System.Drawing.Point(192, 0);
            this.lblWriteDB.Name = "lblWriteDB";
            this.lblWriteDB.Size = new System.Drawing.Size(183, 28);
            this.lblWriteDB.TabIndex = 8;
            this.lblWriteDB.Text = "Write DB:";
            this.lblWriteDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbWriteDataOffset
            // 
            this.tbWriteDataOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWriteDataOffset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWriteDataOffset.Location = new System.Drawing.Point(192, 92);
            this.tbWriteDataOffset.Name = "tbWriteDataOffset";
            this.tbWriteDataOffset.Size = new System.Drawing.Size(183, 27);
            this.tbWriteDataOffset.TabIndex = 12;
            this.tbWriteDataOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbReadDataOffset
            // 
            this.tbReadDataOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReadDataOffset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReadDataOffset.Location = new System.Drawing.Point(3, 92);
            this.tbReadDataOffset.Name = "tbReadDataOffset";
            this.tbReadDataOffset.Size = new System.Drawing.Size(183, 27);
            this.tbReadDataOffset.TabIndex = 6;
            this.tbReadDataOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWriteDB
            // 
            this.tbWriteDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWriteDB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWriteDB.Location = new System.Drawing.Point(192, 31);
            this.tbWriteDB.Name = "tbWriteDB";
            this.tbWriteDB.Size = new System.Drawing.Size(183, 27);
            this.tbWriteDB.TabIndex = 11;
            this.tbWriteDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbReadDB
            // 
            this.tbReadDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReadDB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReadDB.Location = new System.Drawing.Point(3, 31);
            this.tbReadDB.Name = "tbReadDB";
            this.tbReadDB.Size = new System.Drawing.Size(183, 27);
            this.tbReadDB.TabIndex = 5;
            this.tbReadDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReadDataSize
            // 
            this.lblReadDataSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReadDataSize.AutoSize = true;
            this.lblReadDataSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadDataSize.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReadDataSize.Location = new System.Drawing.Point(3, 122);
            this.lblReadDataSize.Name = "lblReadDataSize";
            this.lblReadDataSize.Size = new System.Drawing.Size(183, 28);
            this.lblReadDataSize.TabIndex = 4;
            this.lblReadDataSize.Text = "Read Data Size:";
            this.lblReadDataSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReadDataOffset
            // 
            this.lblReadDataOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReadDataOffset.AutoSize = true;
            this.lblReadDataOffset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadDataOffset.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReadDataOffset.Location = new System.Drawing.Point(3, 61);
            this.lblReadDataOffset.Name = "lblReadDataOffset";
            this.lblReadDataOffset.Size = new System.Drawing.Size(183, 28);
            this.lblReadDataOffset.TabIndex = 4;
            this.lblReadDataOffset.Text = "Read Data Offset:";
            this.lblReadDataOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReadDB
            // 
            this.lblReadDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReadDB.AutoSize = true;
            this.lblReadDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReadDB.Location = new System.Drawing.Point(3, 0);
            this.lblReadDB.Name = "lblReadDB";
            this.lblReadDB.Size = new System.Drawing.Size(183, 28);
            this.lblReadDB.TabIndex = 4;
            this.lblReadDB.Text = "Read DB:";
            this.lblReadDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbReadDataSize
            // 
            this.tbReadDataSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReadDataSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReadDataSize.Location = new System.Drawing.Point(3, 153);
            this.tbReadDataSize.Name = "tbReadDataSize";
            this.tbReadDataSize.Size = new System.Drawing.Size(183, 27);
            this.tbReadDataSize.TabIndex = 7;
            this.tbReadDataSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWriteDataOffset
            // 
            this.lblWriteDataOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWriteDataOffset.AutoSize = true;
            this.lblWriteDataOffset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWriteDataOffset.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWriteDataOffset.Location = new System.Drawing.Point(192, 61);
            this.lblWriteDataOffset.Name = "lblWriteDataOffset";
            this.lblWriteDataOffset.Size = new System.Drawing.Size(183, 28);
            this.lblWriteDataOffset.TabIndex = 9;
            this.lblWriteDataOffset.Text = "Write Data Offset:";
            this.lblWriteDataOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWriteDataSize
            // 
            this.lblWriteDataSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWriteDataSize.AutoSize = true;
            this.lblWriteDataSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWriteDataSize.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWriteDataSize.Location = new System.Drawing.Point(192, 122);
            this.lblWriteDataSize.Name = "lblWriteDataSize";
            this.lblWriteDataSize.Size = new System.Drawing.Size(183, 28);
            this.lblWriteDataSize.TabIndex = 10;
            this.lblWriteDataSize.Text = "Write Data Size:";
            this.lblWriteDataSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbWriteDataSize
            // 
            this.tbWriteDataSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWriteDataSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWriteDataSize.Location = new System.Drawing.Point(192, 153);
            this.tbWriteDataSize.Name = "tbWriteDataSize";
            this.tbWriteDataSize.Size = new System.Drawing.Size(183, 27);
            this.tbWriteDataSize.TabIndex = 13;
            this.tbWriteDataSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pReadWriteSettingsTitle
            // 
            this.pReadWriteSettingsTitle.Controls.Add(this.lblReadWriteTitle);
            this.pReadWriteSettingsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pReadWriteSettingsTitle.Location = new System.Drawing.Point(0, 0);
            this.pReadWriteSettingsTitle.Name = "pReadWriteSettingsTitle";
            this.pReadWriteSettingsTitle.Size = new System.Drawing.Size(378, 33);
            this.pReadWriteSettingsTitle.TabIndex = 0;
            // 
            // lblReadWriteTitle
            // 
            this.lblReadWriteTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReadWriteTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblReadWriteTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReadWriteTitle.Location = new System.Drawing.Point(0, 0);
            this.lblReadWriteTitle.Name = "lblReadWriteTitle";
            this.lblReadWriteTitle.Size = new System.Drawing.Size(378, 33);
            this.lblReadWriteTitle.TabIndex = 5;
            this.lblReadWriteTitle.Text = "Read / Write Settings";
            this.lblReadWriteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLiveUIntSettings
            // 
            this.pLiveUIntSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLiveUIntSettings.Controls.Add(this.tableLayoutPanel4);
            this.pLiveUIntSettings.Controls.Add(this.pLiveUIntSettingsTitle);
            this.pLiveUIntSettings.Location = new System.Drawing.Point(29, 207);
            this.pLiveUIntSettings.Name = "pLiveUIntSettings";
            this.pLiveUIntSettings.Size = new System.Drawing.Size(380, 159);
            this.pLiveUIntSettings.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tbLiveUIntDB, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblLiveUIntDB, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblLiveUIntOffset, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbLiveUIntOffset, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblLiveUIntSize, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbLiveUIntSize, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(378, 124);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tbLiveUIntDB
            // 
            this.tbLiveUIntDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLiveUIntDB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLiveUIntDB.Location = new System.Drawing.Point(3, 31);
            this.tbLiveUIntDB.Name = "tbLiveUIntDB";
            this.tbLiveUIntDB.Size = new System.Drawing.Size(183, 27);
            this.tbLiveUIntDB.TabIndex = 5;
            this.tbLiveUIntDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLiveUIntDB
            // 
            this.lblLiveUIntDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLiveUIntDB.AutoSize = true;
            this.lblLiveUIntDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLiveUIntDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLiveUIntDB.Location = new System.Drawing.Point(3, 0);
            this.lblLiveUIntDB.Name = "lblLiveUIntDB";
            this.lblLiveUIntDB.Size = new System.Drawing.Size(183, 28);
            this.lblLiveUIntDB.TabIndex = 4;
            this.lblLiveUIntDB.Text = "Live UInt DB:";
            this.lblLiveUIntDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLiveUIntOffset
            // 
            this.lblLiveUIntOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLiveUIntOffset.AutoSize = true;
            this.lblLiveUIntOffset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLiveUIntOffset.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLiveUIntOffset.Location = new System.Drawing.Point(192, 0);
            this.lblLiveUIntOffset.Name = "lblLiveUIntOffset";
            this.lblLiveUIntOffset.Size = new System.Drawing.Size(183, 28);
            this.lblLiveUIntOffset.TabIndex = 4;
            this.lblLiveUIntOffset.Text = "Live UInt Offset:";
            this.lblLiveUIntOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLiveUIntOffset
            // 
            this.tbLiveUIntOffset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLiveUIntOffset.Location = new System.Drawing.Point(192, 31);
            this.tbLiveUIntOffset.Name = "tbLiveUIntOffset";
            this.tbLiveUIntOffset.Size = new System.Drawing.Size(183, 27);
            this.tbLiveUIntOffset.TabIndex = 8;
            this.tbLiveUIntOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLiveUIntSize
            // 
            this.lblLiveUIntSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLiveUIntSize.AutoSize = true;
            this.lblLiveUIntSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLiveUIntSize.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLiveUIntSize.Location = new System.Drawing.Point(3, 61);
            this.lblLiveUIntSize.Name = "lblLiveUIntSize";
            this.lblLiveUIntSize.Size = new System.Drawing.Size(183, 28);
            this.lblLiveUIntSize.TabIndex = 4;
            this.lblLiveUIntSize.Text = "Live UInt Size:";
            this.lblLiveUIntSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLiveUIntSize
            // 
            this.tbLiveUIntSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLiveUIntSize.Location = new System.Drawing.Point(3, 92);
            this.tbLiveUIntSize.Name = "tbLiveUIntSize";
            this.tbLiveUIntSize.Size = new System.Drawing.Size(183, 27);
            this.tbLiveUIntSize.TabIndex = 7;
            this.tbLiveUIntSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pLiveUIntSettingsTitle
            // 
            this.pLiveUIntSettingsTitle.Controls.Add(this.lblLiveUIntSettingsTitle);
            this.pLiveUIntSettingsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLiveUIntSettingsTitle.Location = new System.Drawing.Point(0, 0);
            this.pLiveUIntSettingsTitle.Name = "pLiveUIntSettingsTitle";
            this.pLiveUIntSettingsTitle.Size = new System.Drawing.Size(378, 33);
            this.pLiveUIntSettingsTitle.TabIndex = 0;
            // 
            // lblLiveUIntSettingsTitle
            // 
            this.lblLiveUIntSettingsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLiveUIntSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblLiveUIntSettingsTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLiveUIntSettingsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblLiveUIntSettingsTitle.Name = "lblLiveUIntSettingsTitle";
            this.lblLiveUIntSettingsTitle.Size = new System.Drawing.Size(378, 33);
            this.lblLiveUIntSettingsTitle.TabIndex = 5;
            this.lblLiveUIntSettingsTitle.Text = "Live UInt Settings";
            this.lblLiveUIntSettingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnApply, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(29, 599);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(380, 218);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Location = new System.Drawing.Point(41, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 43);
            this.panel1.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(0, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 43);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(184, 0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(114, 43);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(41, 100);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(298, 41);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pGeneralSettings
            // 
            this.pGeneralSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGeneralSettings.Controls.Add(this.tlpRackSlot);
            this.pGeneralSettings.Controls.Add(this.tlpIPAddress);
            this.pGeneralSettings.Controls.Add(this.pGeneralSettingsTitle);
            this.pGeneralSettings.Location = new System.Drawing.Point(29, 42);
            this.pGeneralSettings.Name = "pGeneralSettings";
            this.pGeneralSettings.Size = new System.Drawing.Size(380, 159);
            this.pGeneralSettings.TabIndex = 9;
            // 
            // tlpRackSlot
            // 
            this.tlpRackSlot.ColumnCount = 2;
            this.tlpRackSlot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRackSlot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRackSlot.Controls.Add(this.tbPLCSlot, 1, 1);
            this.tlpRackSlot.Controls.Add(this.lblOLCRack, 0, 0);
            this.tlpRackSlot.Controls.Add(this.tbPLCRack, 0, 1);
            this.tlpRackSlot.Controls.Add(this.lblPLCSlot, 1, 0);
            this.tlpRackSlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpRackSlot.Location = new System.Drawing.Point(0, 94);
            this.tlpRackSlot.Name = "tlpRackSlot";
            this.tlpRackSlot.RowCount = 4;
            this.tlpRackSlot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpRackSlot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpRackSlot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpRackSlot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpRackSlot.Size = new System.Drawing.Size(378, 64);
            this.tlpRackSlot.TabIndex = 1;
            // 
            // tbPLCSlot
            // 
            this.tbPLCSlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPLCSlot.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPLCSlot.Location = new System.Drawing.Point(192, 31);
            this.tbPLCSlot.Name = "tbPLCSlot";
            this.tbPLCSlot.Size = new System.Drawing.Size(183, 27);
            this.tbPLCSlot.TabIndex = 7;
            this.tbPLCSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOLCRack
            // 
            this.lblOLCRack.AutoSize = true;
            this.lblOLCRack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOLCRack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOLCRack.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOLCRack.Location = new System.Drawing.Point(3, 0);
            this.lblOLCRack.Name = "lblOLCRack";
            this.lblOLCRack.Size = new System.Drawing.Size(183, 28);
            this.lblOLCRack.TabIndex = 5;
            this.lblOLCRack.Text = "PLC Rack:";
            this.lblOLCRack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPLCRack
            // 
            this.tbPLCRack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPLCRack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPLCRack.Location = new System.Drawing.Point(3, 31);
            this.tbPLCRack.Name = "tbPLCRack";
            this.tbPLCRack.Size = new System.Drawing.Size(183, 27);
            this.tbPLCRack.TabIndex = 5;
            this.tbPLCRack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPLCSlot
            // 
            this.lblPLCSlot.AutoSize = true;
            this.lblPLCSlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPLCSlot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPLCSlot.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPLCSlot.Location = new System.Drawing.Point(192, 0);
            this.lblPLCSlot.Name = "lblPLCSlot";
            this.lblPLCSlot.Size = new System.Drawing.Size(183, 28);
            this.lblPLCSlot.TabIndex = 6;
            this.lblPLCSlot.Text = "PLC Slot:";
            this.lblPLCSlot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpIPAddress
            // 
            this.tlpIPAddress.ColumnCount = 2;
            this.tlpIPAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpIPAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpIPAddress.Controls.Add(this.tbUpdateInterval, 1, 1);
            this.tlpIPAddress.Controls.Add(this.lblUpdateInterval, 1, 0);
            this.tlpIPAddress.Controls.Add(this.ipab, 0, 1);
            this.tlpIPAddress.Controls.Add(this.lblIPAddress, 0, 0);
            this.tlpIPAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpIPAddress.Location = new System.Drawing.Point(0, 33);
            this.tlpIPAddress.Name = "tlpIPAddress";
            this.tlpIPAddress.RowCount = 4;
            this.tlpIPAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpIPAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpIPAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpIPAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpIPAddress.Size = new System.Drawing.Size(378, 61);
            this.tlpIPAddress.TabIndex = 0;
            // 
            // tbUpdateInterval
            // 
            this.tbUpdateInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUpdateInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUpdateInterval.Location = new System.Drawing.Point(192, 31);
            this.tbUpdateInterval.Name = "tbUpdateInterval";
            this.tbUpdateInterval.Size = new System.Drawing.Size(183, 27);
            this.tbUpdateInterval.TabIndex = 9;
            this.tbUpdateInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUpdateInterval
            // 
            this.lblUpdateInterval.AutoSize = true;
            this.lblUpdateInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpdateInterval.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateInterval.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUpdateInterval.Location = new System.Drawing.Point(192, 0);
            this.lblUpdateInterval.Name = "lblUpdateInterval";
            this.lblUpdateInterval.Size = new System.Drawing.Size(183, 28);
            this.lblUpdateInterval.TabIndex = 8;
            this.lblUpdateInterval.Text = "Update Interval:";
            this.lblUpdateInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ipab
            // 
            this.ipab.BlinkBackColor = System.Drawing.Color.Salmon;
            this.ipab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipab.IPAddress = "";
            this.ipab.IPAddressAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipab.Location = new System.Drawing.Point(4, 32);
            this.ipab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipab.Name = "ipab";
            this.ipab.Size = new System.Drawing.Size(181, 23);
            this.ipab.TabIndex = 6;
            this.ipab.TextBoxBackColor = System.Drawing.SystemColors.Window;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIPAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIPAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIPAddress.Location = new System.Drawing.Point(3, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(183, 28);
            this.lblIPAddress.TabIndex = 4;
            this.lblIPAddress.Text = "IP Adderess:";
            this.lblIPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pGeneralSettingsTitle
            // 
            this.pGeneralSettingsTitle.Controls.Add(this.lblGeneralSettings);
            this.pGeneralSettingsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pGeneralSettingsTitle.Location = new System.Drawing.Point(0, 0);
            this.pGeneralSettingsTitle.Name = "pGeneralSettingsTitle";
            this.pGeneralSettingsTitle.Size = new System.Drawing.Size(378, 33);
            this.pGeneralSettingsTitle.TabIndex = 0;
            // 
            // lblGeneralSettings
            // 
            this.lblGeneralSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneralSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblGeneralSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGeneralSettings.Location = new System.Drawing.Point(0, 0);
            this.lblGeneralSettings.Name = "lblGeneralSettings";
            this.lblGeneralSettings.Size = new System.Drawing.Size(378, 33);
            this.lblGeneralSettings.TabIndex = 5;
            this.lblGeneralSettings.Text = "General Settings";
            this.lblGeneralSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbDatabaseName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 83);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(103, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 29);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLC Rack:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDatabaseName
            // 
            this.tbDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatabaseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDatabaseName.Location = new System.Drawing.Point(3, 36);
            this.tbDatabaseName.Name = "tbDatabaseName";
            this.tbDatabaseName.Size = new System.Drawing.Size(94, 29);
            this.tbDatabaseName.TabIndex = 5;
            this.tbDatabaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(103, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "PLC Slot:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ipAddressBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.BlinkBackColor = System.Drawing.Color.Salmon;
            this.ipAddressBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipAddressBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipAddressBox.IPAddress = "";
            this.ipAddressBox.IPAddressAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipAddressBox.Location = new System.Drawing.Point(4, 4);
            this.ipAddressBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(92, 21);
            this.ipAddressBox.TabIndex = 6;
            this.ipAddressBox.TextBoxBackColor = System.Drawing.SystemColors.Window;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatabaseName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatabaseName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDatabaseName.Location = new System.Drawing.Point(3, 0);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(94, 50);
            this.lblDatabaseName.TabIndex = 4;
            this.lblDatabaseName.Text = "IP Adderess:";
            this.lblDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PLCSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(439, 823);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PLCSettings";
            this.Text = "PLCSettings";
            this.VisibleChanged += new System.EventHandler(this.PLCSettings_VisibleChanged);
            this.tlpMain.ResumeLayout(false);
            this.pMainTitle.ResumeLayout(false);
            this.pReadWriteSettings.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.pReadWriteSettingsTitle.ResumeLayout(false);
            this.pLiveUIntSettings.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.pLiveUIntSettingsTitle.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pGeneralSettings.ResumeLayout(false);
            this.tlpRackSlot.ResumeLayout(false);
            this.tlpRackSlot.PerformLayout();
            this.tlpIPAddress.ResumeLayout(false);
            this.tlpIPAddress.PerformLayout();
            this.pGeneralSettingsTitle.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pMainTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDatabaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private VisualInspection.App.UserControls.IPAddressBox ipAddressBox;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.Panel pReadWriteSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblWriteDB;
        private System.Windows.Forms.TextBox tbWriteDataOffset;
        private System.Windows.Forms.TextBox tbReadDataOffset;
        private System.Windows.Forms.TextBox tbWriteDB;
        private System.Windows.Forms.TextBox tbReadDB;
        private System.Windows.Forms.Label lblReadDataSize;
        private System.Windows.Forms.Label lblReadDataOffset;
        private System.Windows.Forms.Label lblReadDB;
        private System.Windows.Forms.TextBox tbReadDataSize;
        private System.Windows.Forms.Label lblWriteDataOffset;
        private System.Windows.Forms.Label lblWriteDataSize;
        private System.Windows.Forms.TextBox tbWriteDataSize;
        private System.Windows.Forms.Panel pReadWriteSettingsTitle;
        private System.Windows.Forms.Label lblReadWriteTitle;
        private System.Windows.Forms.Panel pLiveUIntSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tbLiveUIntDB;
        private System.Windows.Forms.Label lblLiveUIntDB;
        private System.Windows.Forms.Label lblLiveUIntOffset;
        private System.Windows.Forms.TextBox tbLiveUIntOffset;
        private System.Windows.Forms.Label lblLiveUIntSize;
        private System.Windows.Forms.TextBox tbLiveUIntSize;
        private System.Windows.Forms.Panel pLiveUIntSettingsTitle;
        private System.Windows.Forms.Label lblLiveUIntSettingsTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel pGeneralSettings;
        private System.Windows.Forms.TableLayoutPanel tlpRackSlot;
        private System.Windows.Forms.TextBox tbPLCSlot;
        private System.Windows.Forms.Label lblOLCRack;
        private System.Windows.Forms.TextBox tbPLCRack;
        private System.Windows.Forms.Label lblPLCSlot;
        private System.Windows.Forms.TableLayoutPanel tlpIPAddress;
        private System.Windows.Forms.TextBox tbUpdateInterval;
        private System.Windows.Forms.Label lblUpdateInterval;
        private VisualInspection.App.UserControls.IPAddressBox ipab;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Panel pGeneralSettingsTitle;
        private System.Windows.Forms.Label lblGeneralSettings;
    }
}