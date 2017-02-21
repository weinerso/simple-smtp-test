using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSmtpTest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Log("Ready.");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            btnTest.Enabled = false;
            pbar.Style = ProgressBarStyle.Marquee;
            gbConfig.Enabled = false;
            bgWorker.RunWorkerAsync();

        }

        private void cboxDefaultCredentials_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Enabled = !cboxDefaultCredentials.Checked;
            txtPassword.Enabled = !cboxDefaultCredentials.Checked;
        }

        private void Log(string message)
        {
            message = message.Replace(Environment.NewLine, " ");
            var datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            rtxtOutput.DeselectAll();
            rtxtOutput.SelectionFont = new Font(rtxtOutput.SelectionFont, FontStyle.Bold);
            rtxtOutput.AppendText("[" + datetime + "] ");
            rtxtOutput.SelectionFont = new Font(rtxtOutput.SelectionFont, FontStyle.Regular);
            rtxtOutput.AppendText(message);
            rtxtOutput.AppendText(Environment.NewLine);
        }

        private void linkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rtxtOutput.Clear();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bgWorker.ReportProgress(0, "Sending email to " + txtTo.Text);

            try
            {
                var email = new Email();

                email.Host = txtHost.Text;
                email.Port = (int)nupPort.Value;
                email.Ssl = cboxSSL.Checked;
                email.To = txtTo.Text;
                email.From = txtFrom.Text;
                email.User = txtUser.Text;
                email.Password = txtPassword.Text;
                email.UseDefaultCredentials = cboxDefaultCredentials.Checked;
                email.Timeout = (int)nupTimeout.Value;
                email.SendMail();

                e.Result = "Test completed.";
            }
            catch (Exception ex)
            {
                e.Result = "ERROR: " + ex.Message;
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Log(e.UserState.ToString());
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Log(e.Result.ToString());
            gbConfig.Enabled = true;
            pbar.Style = ProgressBarStyle.Blocks;
            btnTest.Enabled = true;
        }

        private void rtxtOutput_TextChanged(object sender, EventArgs e)
        {
            rtxtOutput.SelectionStart = rtxtOutput.Text.Length;
            rtxtOutput.ScrollToCaret();
        }
    }
}
