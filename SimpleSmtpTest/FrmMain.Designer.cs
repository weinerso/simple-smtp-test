namespace SimpleSmtpTest
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxSSL = new System.Windows.Forms.CheckBox();
            this.nupPort = new System.Windows.Forms.NumericUpDown();
            this.cboxDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.nupTimeout = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkClear = new System.Windows.Forms.LinkLabel();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeout)).BeginInit();
            this.gbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 291);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(285, 40);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(75, 25);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(196, 20);
            this.txtHost.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(75, 77);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(196, 20);
            this.txtUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(75, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(196, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(75, 205);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(196, 20);
            this.txtFrom.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "From:";
            // 
            // cboxSSL
            // 
            this.cboxSSL.AutoSize = true;
            this.cboxSSL.Location = new System.Drawing.Point(75, 152);
            this.cboxSSL.Name = "cboxSSL";
            this.cboxSSL.Size = new System.Drawing.Size(74, 17);
            this.cboxSSL.TabIndex = 6;
            this.cboxSSL.Text = "Use SSL?";
            this.cboxSSL.UseVisualStyleBackColor = true;
            // 
            // nupPort
            // 
            this.nupPort.Location = new System.Drawing.Point(75, 51);
            this.nupPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupPort.Name = "nupPort";
            this.nupPort.Size = new System.Drawing.Size(196, 20);
            this.nupPort.TabIndex = 2;
            this.nupPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // cboxDefaultCredentials
            // 
            this.cboxDefaultCredentials.AutoSize = true;
            this.cboxDefaultCredentials.Location = new System.Drawing.Point(75, 129);
            this.cboxDefaultCredentials.Name = "cboxDefaultCredentials";
            this.cboxDefaultCredentials.Size = new System.Drawing.Size(143, 17);
            this.cboxDefaultCredentials.TabIndex = 5;
            this.cboxDefaultCredentials.Text = "Use Default Credentials?";
            this.cboxDefaultCredentials.UseVisualStyleBackColor = true;
            this.cboxDefaultCredentials.CheckedChanged += new System.EventHandler(this.cboxDefaultCredentials_CheckedChanged);
            // 
            // nupTimeout
            // 
            this.nupTimeout.Location = new System.Drawing.Point(75, 178);
            this.nupTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupTimeout.Name = "nupTimeout";
            this.nupTimeout.Size = new System.Drawing.Size(196, 20);
            this.nupTimeout.TabIndex = 7;
            this.nupTimeout.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Timeout:";
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.txtTo);
            this.gbConfig.Controls.Add(this.label7);
            this.gbConfig.Controls.Add(this.txtHost);
            this.gbConfig.Controls.Add(this.nupTimeout);
            this.gbConfig.Controls.Add(this.label1);
            this.gbConfig.Controls.Add(this.label6);
            this.gbConfig.Controls.Add(this.label2);
            this.gbConfig.Controls.Add(this.cboxDefaultCredentials);
            this.gbConfig.Controls.Add(this.label3);
            this.gbConfig.Controls.Add(this.txtUser);
            this.gbConfig.Controls.Add(this.nupPort);
            this.gbConfig.Controls.Add(this.label4);
            this.gbConfig.Controls.Add(this.cboxSSL);
            this.gbConfig.Controls.Add(this.txtPassword);
            this.gbConfig.Controls.Add(this.txtFrom);
            this.gbConfig.Controls.Add(this.label5);
            this.gbConfig.Location = new System.Drawing.Point(12, 12);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(285, 273);
            this.gbConfig.TabIndex = 18;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Configurations";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(75, 231);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(196, 20);
            this.txtTo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "To:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(483, 340);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(221, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/weinerso/simple-smtp-test";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Version 1.0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Log:";
            // 
            // linkClear
            // 
            this.linkClear.AutoSize = true;
            this.linkClear.Location = new System.Drawing.Point(656, 12);
            this.linkClear.Name = "linkClear";
            this.linkClear.Size = new System.Drawing.Size(48, 13);
            this.linkClear.TabIndex = 12;
            this.linkClear.TabStop = true;
            this.linkClear.Text = "Clear log";
            this.linkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(13, 337);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(283, 16);
            this.pbar.TabIndex = 24;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtxtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOutput.Location = new System.Drawing.Point(306, 28);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.ReadOnly = true;
            this.rtxtOutput.Size = new System.Drawing.Size(398, 303);
            this.rtxtOutput.TabIndex = 25;
            this.rtxtOutput.Text = "";
            this.rtxtOutput.TextChanged += new System.EventHandler(this.rtxtOutput_TextChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 362);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.linkClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gbConfig);
            this.Controls.Add(this.btnTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple SMTP Test";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeout)).EndInit();
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cboxSSL;
        private System.Windows.Forms.NumericUpDown nupPort;
        private System.Windows.Forms.CheckBox cboxDefaultCredentials;
        private System.Windows.Forms.NumericUpDown nupTimeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkClear;
        private System.Windows.Forms.ProgressBar pbar;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.RichTextBox rtxtOutput;
    }
}