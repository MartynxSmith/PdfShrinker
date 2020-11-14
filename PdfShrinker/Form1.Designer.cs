namespace PdfShrinker
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.comboBoxQuality = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.overwriteoriginals = new System.Windows.Forms.CheckBox();
            this.maintaintimestamps = new System.Windows.Forms.CheckBox();
            this.settings = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbFile = new System.Windows.Forms.ProgressBar();
            this.pbOverall = new System.Windows.Forms.ProgressBar();
            this.lblFileStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.logbox = new System.Windows.Forms.TextBox();
            this.settings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "-- Drop documents to compress here --";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(646, 48);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(481, 86);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // comboBoxQuality
            // 
            this.comboBoxQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQuality.FormattingEnabled = true;
            this.comboBoxQuality.Items.AddRange(new object[] {
            "Screen",
            "eBook",
            "Printer",
            "Prepress",
            "Default"});
            this.comboBoxQuality.Location = new System.Drawing.Point(1024, 27);
            this.comboBoxQuality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxQuality.Name = "comboBoxQuality";
            this.comboBoxQuality.Size = new System.Drawing.Size(103, 28);
            this.comboBoxQuality.TabIndex = 5;
            this.comboBoxQuality.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuality_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(941, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quality";
            // 
            // overwriteoriginals
            // 
            this.overwriteoriginals.AccessibleName = "Overwrite Originals";
            this.overwriteoriginals.AutoSize = true;
            this.overwriteoriginals.Location = new System.Drawing.Point(6, 36);
            this.overwriteoriginals.Name = "overwriteoriginals";
            this.overwriteoriginals.Size = new System.Drawing.Size(166, 24);
            this.overwriteoriginals.TabIndex = 7;
            this.overwriteoriginals.Text = "Overwrite Originals";
            this.overwriteoriginals.UseVisualStyleBackColor = true;
            // 
            // maintaintimestamps
            // 
            this.maintaintimestamps.AccessibleName = "Maintain Last Modified Timestamps";
            this.maintaintimestamps.AutoSize = true;
            this.maintaintimestamps.Location = new System.Drawing.Point(6, 66);
            this.maintaintimestamps.Name = "maintaintimestamps";
            this.maintaintimestamps.Size = new System.Drawing.Size(284, 24);
            this.maintaintimestamps.TabIndex = 8;
            this.maintaintimestamps.Text = "Maintain Last Modified Timestamps";
            this.maintaintimestamps.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Controls.Add(this.maintaintimestamps);
            this.settings.Controls.Add(this.overwriteoriginals);
            this.settings.Controls.Add(this.label2);
            this.settings.Controls.Add(this.comboBoxQuality);
            this.settings.Location = new System.Drawing.Point(12, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(1134, 100);
            this.settings.TabIndex = 10;
            this.settings.TabStop = false;
            this.settings.Text = "Settings";
            this.settings.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.logbox);
            this.groupBox1.Controls.Add(this.pbFile);
            this.groupBox1.Controls.Add(this.pbOverall);
            this.groupBox1.Controls.Add(this.lblFileStatus);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 522);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // pbFile
            // 
            this.pbFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFile.Location = new System.Drawing.Point(7, 100);
            this.pbFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbFile.Name = "pbFile";
            this.pbFile.Size = new System.Drawing.Size(613, 31);
            this.pbFile.TabIndex = 4;
            // 
            // pbOverall
            // 
            this.pbOverall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOverall.Location = new System.Drawing.Point(7, 50);
            this.pbOverall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbOverall.Name = "pbOverall";
            this.pbOverall.Size = new System.Drawing.Size(613, 31);
            this.pbOverall.TabIndex = 3;
            // 
            // lblFileStatus
            // 
            this.lblFileStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFileStatus.AutoEllipsis = true;
            this.lblFileStatus.Location = new System.Drawing.Point(7, 81);
            this.lblFileStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileStatus.Name = "lblFileStatus";
            this.lblFileStatus.Size = new System.Drawing.Size(613, 28);
            this.lblFileStatus.TabIndex = 2;
            this.lblFileStatus.Text = "...";
            this.lblFileStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 19);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(613, 26);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready!";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logbox
            // 
            this.logbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.logbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logbox.ForeColor = System.Drawing.Color.LawnGreen;
            this.logbox.Location = new System.Drawing.Point(3, 142);
            this.logbox.MinimumSize = new System.Drawing.Size(100, 100);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ReadOnly = true;
            this.logbox.Size = new System.Drawing.Size(1128, 377);
            this.logbox.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1158, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PDF Compressor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox comboBoxQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox overwriteoriginals;
        private System.Windows.Forms.CheckBox maintaintimestamps;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pbFile;
        private System.Windows.Forms.ProgressBar pbOverall;
        private System.Windows.Forms.Label lblFileStatus;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.TextBox logbox;
    }
}

