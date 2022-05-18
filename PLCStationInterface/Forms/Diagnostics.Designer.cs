
namespace PLCStationInterface.Forms
{
    partial class Diagnostics
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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.clientStatusDot3 = new PLCStationInterface.UserControls.ClientStatusDot();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.clientStatusDot5 = new PLCStationInterface.UserControls.ClientStatusDot();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.clientStatusDot4 = new PLCStationInterface.UserControls.ClientStatusDot();
            this.label2 = new System.Windows.Forms.Label();
            this.clientStatusDot1 = new PLCStationInterface.UserControls.ClientStatusDot();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPLCStatusCodeData = new System.Windows.Forms.Label();
            this.lblPLCLiveUInt = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWriteStatusCodeData = new System.Windows.Forms.Label();
            this.lblWriteStatusCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReadStatusCodeData = new System.Windows.Forms.Label();
            this.lblReadStatusCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPLCStatusCode = new System.Windows.Forms.Label();
            this.lblLiveUIntStatusCodeData = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PLCStatusDot = new PLCStationInterface.UserControls.ClientStatusDot();
            this.lblPLCStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TCPServerStatusDot = new PLCStationInterface.UserControls.ClientStatusDot();
            this.lblTCPServerStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLiveUIntMessage = new System.Windows.Forms.Label();
            this.lblReadMessage = new System.Windows.Forms.Label();
            this.lblWriteMessage = new System.Windows.Forms.Label();
            this.tbLiveUIntMessage = new System.Windows.Forms.TextBox();
            this.tbReadMessage = new System.Windows.Forms.TextBox();
            this.tbWriteMassage = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel6.Controls.Add(this.clientStatusDot3, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // clientStatusDot3
            // 
            this.clientStatusDot3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientStatusDot3.Client = null;
            this.clientStatusDot3.Location = new System.Drawing.Point(118, 3);
            this.clientStatusDot3.Name = "clientStatusDot3";
            this.clientStatusDot3.Size = new System.Drawing.Size(79, 94);
            this.clientStatusDot3.Status = VisualInspection.Utils.Net.ClientStatus.Disconnected;
            this.clientStatusDot3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Status:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel8.Controls.Add(this.clientStatusDot5, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // clientStatusDot5
            // 
            this.clientStatusDot5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientStatusDot5.Client = null;
            this.clientStatusDot5.Location = new System.Drawing.Point(118, 3);
            this.clientStatusDot5.Name = "clientStatusDot5";
            this.clientStatusDot5.Size = new System.Drawing.Size(79, 94);
            this.clientStatusDot5.Status = VisualInspection.Utils.Net.ClientStatus.Disconnected;
            this.clientStatusDot5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 100);
            this.label3.TabIndex = 0;
            this.label3.Text = "Database Status:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel7.Controls.Add(this.clientStatusDot4, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // clientStatusDot4
            // 
            this.clientStatusDot4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientStatusDot4.Client = null;
            this.clientStatusDot4.Location = new System.Drawing.Point(118, 3);
            this.clientStatusDot4.Name = "clientStatusDot4";
            this.clientStatusDot4.Size = new System.Drawing.Size(79, 94);
            this.clientStatusDot4.Status = VisualInspection.Utils.Net.ClientStatus.Disconnected;
            this.clientStatusDot4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 100);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientStatusDot1
            // 
            this.clientStatusDot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientStatusDot1.Client = null;
            this.clientStatusDot1.Location = new System.Drawing.Point(357, 3);
            this.clientStatusDot1.Name = "clientStatusDot1";
            this.clientStatusDot1.Size = new System.Drawing.Size(79, 36);
            this.clientStatusDot1.Status = VisualInspection.Utils.Net.ClientStatus.Disconnected;
            this.clientStatusDot1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 100);
            this.label5.TabIndex = 1;
            this.label5.Text = "PLC Status Code:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel10.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 100);
            this.label4.TabIndex = 3;
            this.label4.Text = "XXXX";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 100);
            this.label6.TabIndex = 1;
            this.label6.Text = "PLC LiveUInt:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel11.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 100);
            this.label7.TabIndex = 3;
            this.label7.Text = "XXXX";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 100);
            this.label8.TabIndex = 1;
            this.label8.Text = "PLC LiveUInt:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel12.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 100);
            this.label9.TabIndex = 3;
            this.label9.Text = "XXXX";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 100);
            this.label10.TabIndex = 1;
            this.label10.Text = "PLC LiveUInt:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel14.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel14.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 100);
            this.label13.TabIndex = 3;
            this.label13.Text = "XXXX";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 100);
            this.label14.TabIndex = 1;
            this.label14.Text = "PLC LiveUInt:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel15);
            this.panel1.Controls.Add(this.tableLayoutPanel13);
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel9);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(50, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 258);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel15.Controls.Add(this.lblPLCStatusCodeData, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.lblPLCLiveUInt, 0, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 210);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(336, 42);
            this.tableLayoutPanel15.TabIndex = 9;
            // 
            // lblPLCStatusCodeData
            // 
            this.lblPLCStatusCodeData.AutoSize = true;
            this.lblPLCStatusCodeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPLCStatusCodeData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPLCStatusCodeData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPLCStatusCodeData.Location = new System.Drawing.Point(254, 0);
            this.lblPLCStatusCodeData.Name = "lblPLCStatusCodeData";
            this.lblPLCStatusCodeData.Size = new System.Drawing.Size(79, 42);
            this.lblPLCStatusCodeData.TabIndex = 3;
            this.lblPLCStatusCodeData.Text = "XXXX";
            this.lblPLCStatusCodeData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPLCLiveUInt
            // 
            this.lblPLCLiveUInt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPLCLiveUInt.AutoSize = true;
            this.lblPLCLiveUInt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPLCLiveUInt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPLCLiveUInt.Location = new System.Drawing.Point(3, 0);
            this.lblPLCLiveUInt.Name = "lblPLCLiveUInt";
            this.lblPLCLiveUInt.Size = new System.Drawing.Size(245, 42);
            this.lblPLCLiveUInt.TabIndex = 1;
            this.lblPLCLiveUInt.Text = "PLC LiveUInt:";
            this.lblPLCLiveUInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel13.Controls.Add(this.lblWriteStatusCodeData, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.lblWriteStatusCode, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 168);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(336, 42);
            this.tableLayoutPanel13.TabIndex = 8;
            // 
            // lblWriteStatusCodeData
            // 
            this.lblWriteStatusCodeData.AutoSize = true;
            this.lblWriteStatusCodeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWriteStatusCodeData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWriteStatusCodeData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWriteStatusCodeData.Location = new System.Drawing.Point(254, 0);
            this.lblWriteStatusCodeData.Name = "lblWriteStatusCodeData";
            this.lblWriteStatusCodeData.Size = new System.Drawing.Size(79, 42);
            this.lblWriteStatusCodeData.TabIndex = 3;
            this.lblWriteStatusCodeData.Text = "XXXX";
            this.lblWriteStatusCodeData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWriteStatusCode
            // 
            this.lblWriteStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWriteStatusCode.AutoSize = true;
            this.lblWriteStatusCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWriteStatusCode.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWriteStatusCode.Location = new System.Drawing.Point(3, 0);
            this.lblWriteStatusCode.Name = "lblWriteStatusCode";
            this.lblWriteStatusCode.Size = new System.Drawing.Size(245, 42);
            this.lblWriteStatusCode.TabIndex = 1;
            this.lblWriteStatusCode.Text = "Write Status Code:";
            this.lblWriteStatusCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel5.Controls.Add(this.lblReadStatusCodeData, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblReadStatusCode, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 126);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(336, 42);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // lblReadStatusCodeData
            // 
            this.lblReadStatusCodeData.AutoSize = true;
            this.lblReadStatusCodeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReadStatusCodeData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadStatusCodeData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReadStatusCodeData.Location = new System.Drawing.Point(254, 0);
            this.lblReadStatusCodeData.Name = "lblReadStatusCodeData";
            this.lblReadStatusCodeData.Size = new System.Drawing.Size(79, 42);
            this.lblReadStatusCodeData.TabIndex = 3;
            this.lblReadStatusCodeData.Text = "XXXX";
            this.lblReadStatusCodeData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReadStatusCode
            // 
            this.lblReadStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReadStatusCode.AutoSize = true;
            this.lblReadStatusCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadStatusCode.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReadStatusCode.Location = new System.Drawing.Point(3, 0);
            this.lblReadStatusCode.Name = "lblReadStatusCode";
            this.lblReadStatusCode.Size = new System.Drawing.Size(245, 42);
            this.lblReadStatusCode.TabIndex = 1;
            this.lblReadStatusCode.Text = "Read Status Code:";
            this.lblReadStatusCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel9.Controls.Add(this.lblPLCStatusCode, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblLiveUIntStatusCodeData, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 84);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(336, 42);
            this.tableLayoutPanel9.TabIndex = 6;
            // 
            // lblPLCStatusCode
            // 
            this.lblPLCStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPLCStatusCode.AutoSize = true;
            this.lblPLCStatusCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPLCStatusCode.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPLCStatusCode.Location = new System.Drawing.Point(3, 0);
            this.lblPLCStatusCode.Name = "lblPLCStatusCode";
            this.lblPLCStatusCode.Size = new System.Drawing.Size(245, 42);
            this.lblPLCStatusCode.TabIndex = 1;
            this.lblPLCStatusCode.Text = "Live UInt Status Code:";
            this.lblPLCStatusCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLiveUIntStatusCodeData
            // 
            this.lblLiveUIntStatusCodeData.AutoSize = true;
            this.lblLiveUIntStatusCodeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLiveUIntStatusCodeData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLiveUIntStatusCodeData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLiveUIntStatusCodeData.Location = new System.Drawing.Point(254, 0);
            this.lblLiveUIntStatusCodeData.Name = "lblLiveUIntStatusCodeData";
            this.lblLiveUIntStatusCodeData.Size = new System.Drawing.Size(79, 42);
            this.lblLiveUIntStatusCodeData.TabIndex = 2;
            this.lblLiveUIntStatusCodeData.Text = "XXXX";
            this.lblLiveUIntStatusCodeData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.PLCStatusDot, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPLCStatus, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 42);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // PLCStatusDot
            // 
            this.PLCStatusDot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PLCStatusDot.Client = null;
            this.PLCStatusDot.Location = new System.Drawing.Point(254, 3);
            this.PLCStatusDot.Name = "PLCStatusDot";
            this.PLCStatusDot.Size = new System.Drawing.Size(79, 36);
            this.PLCStatusDot.Status = VisualInspection.Utils.Net.ClientStatus.Disconnected;
            this.PLCStatusDot.TabIndex = 1;
            // 
            // lblPLCStatus
            // 
            this.lblPLCStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPLCStatus.AutoSize = true;
            this.lblPLCStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPLCStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPLCStatus.Location = new System.Drawing.Point(3, 0);
            this.lblPLCStatus.Name = "lblPLCStatus";
            this.lblPLCStatus.Size = new System.Drawing.Size(245, 42);
            this.lblPLCStatus.TabIndex = 0;
            this.lblPLCStatus.Text = "PLC Status:";
            this.lblPLCStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.Controls.Add(this.TCPServerStatusDot, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTCPServerStatus, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(336, 42);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // TCPServerStatusDot
            // 
            this.TCPServerStatusDot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCPServerStatusDot.Client = null;
            this.TCPServerStatusDot.Location = new System.Drawing.Point(254, 3);
            this.TCPServerStatusDot.Name = "TCPServerStatusDot";
            this.TCPServerStatusDot.Size = new System.Drawing.Size(79, 36);
            this.TCPServerStatusDot.Status = VisualInspection.Utils.Net.ClientStatus.Disconnected;
            this.TCPServerStatusDot.TabIndex = 2;
            // 
            // lblTCPServerStatus
            // 
            this.lblTCPServerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTCPServerStatus.AutoSize = true;
            this.lblTCPServerStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTCPServerStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTCPServerStatus.Location = new System.Drawing.Point(3, 0);
            this.lblTCPServerStatus.Name = "lblTCPServerStatus";
            this.lblTCPServerStatus.Size = new System.Drawing.Size(245, 42);
            this.lblTCPServerStatus.TabIndex = 0;
            this.lblTCPServerStatus.Text = "TCP Server Status:";
            this.lblTCPServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel16, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 639);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.lblLiveUIntMessage, 0, 2);
            this.tableLayoutPanel16.Controls.Add(this.lblReadMessage, 0, 5);
            this.tableLayoutPanel16.Controls.Add(this.lblWriteMessage, 0, 8);
            this.tableLayoutPanel16.Controls.Add(this.tbLiveUIntMessage, 0, 3);
            this.tableLayoutPanel16.Controls.Add(this.tbReadMessage, 0, 6);
            this.tableLayoutPanel16.Controls.Add(this.tbWriteMassage, 0, 9);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(50, 330);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 12;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(336, 298);
            this.tableLayoutPanel16.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(330, 33);
            this.label11.TabIndex = 1;
            this.label11.Text = "PLC Errors Messages";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLiveUIntMessage
            // 
            this.lblLiveUIntMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLiveUIntMessage.AutoSize = true;
            this.lblLiveUIntMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLiveUIntMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLiveUIntMessage.Location = new System.Drawing.Point(3, 48);
            this.lblLiveUIntMessage.Name = "lblLiveUIntMessage";
            this.lblLiveUIntMessage.Size = new System.Drawing.Size(330, 33);
            this.lblLiveUIntMessage.TabIndex = 2;
            this.lblLiveUIntMessage.Text = "Live UInt Message:";
            this.lblLiveUIntMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReadMessage
            // 
            this.lblReadMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReadMessage.AutoSize = true;
            this.lblReadMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReadMessage.Location = new System.Drawing.Point(3, 129);
            this.lblReadMessage.Name = "lblReadMessage";
            this.lblReadMessage.Size = new System.Drawing.Size(330, 33);
            this.lblReadMessage.TabIndex = 3;
            this.lblReadMessage.Text = "Read Message:";
            this.lblReadMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWriteMessage
            // 
            this.lblWriteMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWriteMessage.AutoSize = true;
            this.lblWriteMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWriteMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWriteMessage.Location = new System.Drawing.Point(3, 210);
            this.lblWriteMessage.Name = "lblWriteMessage";
            this.lblWriteMessage.Size = new System.Drawing.Size(330, 33);
            this.lblWriteMessage.TabIndex = 4;
            this.lblWriteMessage.Text = "Write Message:";
            this.lblWriteMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLiveUIntMessage
            // 
            this.tbLiveUIntMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLiveUIntMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLiveUIntMessage.Location = new System.Drawing.Point(3, 84);
            this.tbLiveUIntMessage.Name = "tbLiveUIntMessage";
            this.tbLiveUIntMessage.ReadOnly = true;
            this.tbLiveUIntMessage.Size = new System.Drawing.Size(330, 27);
            this.tbLiveUIntMessage.TabIndex = 5;
            this.tbLiveUIntMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbReadMessage
            // 
            this.tbReadMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReadMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReadMessage.Location = new System.Drawing.Point(3, 165);
            this.tbReadMessage.Name = "tbReadMessage";
            this.tbReadMessage.ReadOnly = true;
            this.tbReadMessage.Size = new System.Drawing.Size(330, 27);
            this.tbReadMessage.TabIndex = 6;
            this.tbReadMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWriteMassage
            // 
            this.tbWriteMassage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWriteMassage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWriteMassage.Location = new System.Drawing.Point(3, 246);
            this.tbWriteMassage.Name = "tbWriteMassage";
            this.tbWriteMassage.ReadOnly = true;
            this.tbWriteMassage.Size = new System.Drawing.Size(330, 27);
            this.tbWriteMassage.TabIndex = 7;
            this.tbWriteMassage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Diagnostics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(439, 823);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnostics";
            this.Text = "Diagnostics";
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private UserControls.ClientStatusDot clientStatusDot3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private UserControls.ClientStatusDot clientStatusDot5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private UserControls.ClientStatusDot clientStatusDot4;
        private System.Windows.Forms.Label label2;
        private UserControls.ClientStatusDot clientStatusDot1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label lblPLCStatusCodeData;
        private System.Windows.Forms.Label lblPLCLiveUInt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label lblWriteStatusCodeData;
        private System.Windows.Forms.Label lblWriteStatusCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblReadStatusCodeData;
        private System.Windows.Forms.Label lblReadStatusCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label lblPLCStatusCode;
        private System.Windows.Forms.Label lblLiveUIntStatusCodeData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls.ClientStatusDot PLCStatusDot;
        private System.Windows.Forms.Label lblPLCStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private UserControls.ClientStatusDot TCPServerStatusDot;
        private System.Windows.Forms.Label lblTCPServerStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLiveUIntMessage;
        private System.Windows.Forms.Label lblReadMessage;
        private System.Windows.Forms.Label lblWriteMessage;
        private System.Windows.Forms.TextBox tbLiveUIntMessage;
        private System.Windows.Forms.TextBox tbReadMessage;
        private System.Windows.Forms.TextBox tbWriteMassage;
    }
}