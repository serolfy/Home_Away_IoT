namespace ProjectBroker
{
    partial class Form1
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.groupBoxSec = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSecKey = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCloudPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCloudIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSensorIP = new System.Windows.Forms.TextBox();
            this.textBoxSensorPort = new System.Windows.Forms.TextBox();
            this.labelConfig = new System.Windows.Forms.Label();
            this.buttonExitConfig = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textLog = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelConfig.SuspendLayout();
            this.groupBoxSec.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.checkedListBox1, 2);
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Server Running",
            "API Running",
            "Subscriber Alive ",
            "All systems running normal"});
            this.checkedListBox1.Location = new System.Drawing.Point(4, 4);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(470, 132);
            this.checkedListBox1.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonConfig);
            this.panelMenu.Controls.Add(this.buttonStop);
            this.panelMenu.Controls.Add(this.buttonRestart);
            this.panelMenu.Controls.Add(this.buttonLog);
            this.panelMenu.Controls.Add(this.buttonStart);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(301, 1010);
            this.panelMenu.TabIndex = 6;
            // 
            // buttonConfig
            // 
            this.buttonConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConfig.FlatAppearance.BorderSize = 0;
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfig.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold);
            this.buttonConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonConfig.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfig.Image")));
            this.buttonConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfig.Location = new System.Drawing.Point(0, 842);
            this.buttonConfig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonConfig.Size = new System.Drawing.Size(301, 170);
            this.buttonConfig.TabIndex = 6;
            this.buttonConfig.Text = "    Config";
            this.buttonConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold);
            this.buttonStop.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStop.Image")));
            this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.Location = new System.Drawing.Point(0, 672);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonStop.Size = new System.Drawing.Size(301, 170);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "    Stop";
            this.buttonStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRestart.Enabled = false;
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRestart.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestart.Image")));
            this.buttonRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestart.Location = new System.Drawing.Point(0, 502);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonRestart.Size = new System.Drawing.Size(301, 170);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.Text = "    Restart ";
            this.buttonRestart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLog.FlatAppearance.BorderSize = 0;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold);
            this.buttonLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLog.Image = ((System.Drawing.Image)(resources.GetObject("buttonLog.Image")));
            this.buttonLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLog.Location = new System.Drawing.Point(0, 332);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonLog.Size = new System.Drawing.Size(301, 170);
            this.buttonLog.TabIndex = 2;
            this.buttonLog.Text = "    View Log";
            this.buttonLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonStart.Image")));
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(0, 162);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonStart.Size = new System.Drawing.Size(301, 170);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "    Start";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(301, 162);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(301, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1349, 162);
            this.panelTitleBar.TabIndex = 7;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Snow;
            this.labelTitle.Location = new System.Drawing.Point(595, 50);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(166, 57);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            // 
            // panelConfig
            // 
            this.panelConfig.AutoSize = true;
            this.panelConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelConfig.Controls.Add(this.groupBoxSec);
            this.panelConfig.Controls.Add(this.groupBox3);
            this.panelConfig.Controls.Add(this.groupBox2);
            this.panelConfig.Controls.Add(this.labelConfig);
            this.panelConfig.Controls.Add(this.buttonExitConfig);
            this.panelConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfig.Location = new System.Drawing.Point(301, 162);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(1349, 848);
            this.panelConfig.TabIndex = 1;
            this.panelConfig.Visible = false;
            // 
            // groupBoxSec
            // 
            this.groupBoxSec.Controls.Add(this.label2);
            this.groupBoxSec.Controls.Add(this.label3);
            this.groupBoxSec.Controls.Add(this.textBoxSecKey);
            this.groupBoxSec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxSec.Location = new System.Drawing.Point(447, 146);
            this.groupBoxSec.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxSec.Name = "groupBoxSec";
            this.groupBoxSec.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxSec.Size = new System.Drawing.Size(250, 217);
            this.groupBoxSec.TabIndex = 38;
            this.groupBoxSec.TabStop = false;
            this.groupBoxSec.Text = "Security";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "SecKey:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Encryption:";
            // 
            // textBoxSecKey
            // 
            this.textBoxSecKey.Location = new System.Drawing.Point(122, 89);
            this.textBoxSecKey.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSecKey.Name = "textBoxSecKey";
            this.textBoxSecKey.Size = new System.Drawing.Size(105, 29);
            this.textBoxSecKey.TabIndex = 32;
            this.textBoxSecKey.Text = "return";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxCloudPort);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxCloudIP);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(136, 364);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(250, 163);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cloud";
            // 
            // textBoxCloudPort
            // 
            this.textBoxCloudPort.Location = new System.Drawing.Point(110, 94);
            this.textBoxCloudPort.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCloudPort.Name = "textBoxCloudPort";
            this.textBoxCloudPort.Size = new System.Drawing.Size(105, 29);
            this.textBoxCloudPort.TabIndex = 43;
            this.textBoxCloudPort.Text = "50250";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "PORT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "IP:";
            // 
            // textBoxCloudIP
            // 
            this.textBoxCloudIP.Location = new System.Drawing.Point(73, 35);
            this.textBoxCloudIP.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCloudIP.Name = "textBoxCloudIP";
            this.textBoxCloudIP.Size = new System.Drawing.Size(142, 29);
            this.textBoxCloudIP.TabIndex = 29;
            this.textBoxCloudIP.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxSensorIP);
            this.groupBox2.Controls.Add(this.textBoxSensorPort);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(136, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(250, 217);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "PORT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "IP:";
            // 
            // textBoxSensorIP
            // 
            this.textBoxSensorIP.Location = new System.Drawing.Point(73, 35);
            this.textBoxSensorIP.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSensorIP.Name = "textBoxSensorIP";
            this.textBoxSensorIP.Size = new System.Drawing.Size(142, 29);
            this.textBoxSensorIP.TabIndex = 29;
            this.textBoxSensorIP.Text = "";
            // 
            // textBoxSensorPort
            // 
            this.textBoxSensorPort.Location = new System.Drawing.Point(110, 83);
            this.textBoxSensorPort.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSensorPort.Name = "textBoxSensorPort";
            this.textBoxSensorPort.Size = new System.Drawing.Size(105, 29);
            this.textBoxSensorPort.TabIndex = 32;
            this.textBoxSensorPort.Text = "2224";
            // 
            // labelConfig
            // 
            this.labelConfig.AutoSize = true;
            this.labelConfig.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelConfig.Location = new System.Drawing.Point(535, 50);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(321, 51);
            this.labelConfig.TabIndex = 1;
            this.labelConfig.Text = "Configurations";
            // 
            // buttonExitConfig
            // 
            this.buttonExitConfig.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonExitConfig.Location = new System.Drawing.Point(3, 3);
            this.buttonExitConfig.Name = "buttonExitConfig";
            this.buttonExitConfig.Size = new System.Drawing.Size(58, 58);
            this.buttonExitConfig.TabIndex = 0;
            this.buttonExitConfig.Text = "X";
            this.buttonExitConfig.UseVisualStyleBackColor = true;
            this.buttonExitConfig.Click += new System.EventHandler(this.buttonExitConfig_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 629F));
            this.tableLayoutPanel1.Controls.Add(this.textLog, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(328, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1239, 762);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // textLog
            // 
            this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLog.BackColor = System.Drawing.Color.DimGray;
            this.textLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textLog, 2);
            this.textLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLog.Location = new System.Drawing.Point(4, 166);
            this.textLog.Margin = new System.Windows.Forms.Padding(4);
            this.textLog.MinimumSize = new System.Drawing.Size(557, 557);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(1231, 592);
            this.textLog.TabIndex = 4;
            this.textLog.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1650, 1010);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1500, 1074);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            this.groupBoxSec.ResumeLayout(false);
            this.groupBoxSec.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.Button buttonExitConfig;
        public System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCloudPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCloudIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSensorIP;
        private System.Windows.Forms.TextBox textBoxSensorPort;
        private System.Windows.Forms.GroupBox groupBoxSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSecKey;
    }
}

