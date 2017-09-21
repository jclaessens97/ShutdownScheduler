using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownScheduler
{
    public partial class MainForm : Form
    {
        private enum TimeTypes : byte
        {
            Milliseconds = 0,
            Seconds,
            Minutes,
            Hours
        }
        private bool showCustomMessagebox;

        public MainForm()
        {
            InitializeComponent();
            cbTimeType.DataSource = Enum.GetValues(typeof(TimeTypes));
            cbTimeType.SelectedItem = TimeTypes.Milliseconds;
            showCustomMessagebox = cbCustomMessagebox.Checked;
        }

        #region Events

        private void cbTimeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            switch (cb.SelectedItem)
            {
                //TODO set maximum according
                case TimeTypes.Milliseconds:
                    numTime.Maximum = 10000;
                    break;
                case TimeTypes.Seconds:
                    numTime.Maximum = 10000;
                    break;
                case TimeTypes.Minutes:
                    numTime.Maximum = 10000;
                    break;
                case TimeTypes.Hours:
                    numTime.Maximum = 200;
                    break;
            }
        }

        private void cbCustomMessagebox_CheckedChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            showCustomMessagebox = cb.Checked;
        }

        private void btnShutdownOrCancel_Click(object sender, EventArgs e)
        {
            if (btnShutdownOrCancel.Text == "Cancel")
            {
                Cancel();
                btnShutdownOrCancel.Text = "Schedule shutdown";
            }
            else
            {
                Schedule();
                btnShutdownOrCancel.Text = "Cancel";
            }
        }

        private void pbHelpIcon_Click(object sender, EventArgs e)
        {
            var msg = "Windows 10 shows own messages about scheduled shutdowns, but sometimes they fail.";
            msg += "If you want to be sure to always get the dialog or if your on an earlier version of windows, it shows custom messageboxes.";
            msg += "You can enable or disable them by using the checkbox.";
            ShowMessageBox(msg);
        }

        #endregion

        #region Methods

        private void Schedule()
        {
            string command = "shutdown";
            string msg = string.Empty;

            if (rbShutdown.Checked)
            {
                command += " /s";
                msg = "Shutdown ";
            }
            else if (rbLogOff.Checked)
            {
                command += " /l";
                msg = "Log off ";
            }
            else if (rbRestart.Checked)
            {
                command += " /r";
                msg = "Restart ";
            }

            var timeTypes = (TimeTypes) cbTimeType.SelectedIndex;
            var time = ConvertToSecs(Int32.Parse(numTime.Text), timeTypes);
            command += " /t " + time;

            ExecuteCommand(command);

            if (showCustomMessagebox)
            {
                msg += " is scheduled " + numTime.Text + " " + timeTypes + " from now.";
                ShowMessageBox(msg);
            }
        }

        private void Cancel()
        {
            string command = "shutdown /a";
            ExecuteCommand(command);

            if (showCustomMessagebox)
            {
                ShowMessageBox("Scheduled shutdown is canceled!");
            }
        }

        #endregion

        #region Auxilary Methods

        private double ConvertToSecs(int timeToConvert, TimeTypes timeType)
        {
            TimeSpan ts = new TimeSpan();
            switch (timeType)
            {
                case TimeTypes.Milliseconds:
                    ts = new TimeSpan(0, 0, 0, 0, timeToConvert);
                    break;
                case TimeTypes.Seconds:
                    ts = new TimeSpan(0, 0, timeToConvert);
                    break;
                case TimeTypes.Minutes:
                    ts = new TimeSpan(0, timeToConvert, 0);
                    break;
                case TimeTypes.Hours:
                    ts = new TimeSpan(timeToConvert, 0, 0);
                    break;
            }

            Debug.WriteLine(ts.TotalSeconds);

            return ts.TotalSeconds;
        }

        private void ExecuteCommand(string cmd)
        {
            Debug.WriteLine(cmd);

            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.FileName = "cmd.exe";
            psi.Arguments = "/C " + cmd;
            p.StartInfo = psi;
            p.Start();
            //p.WaitForExit();
        }

        private void ShowMessageBox(string msg)
        {
            MessageBox.Show(this, msg, "ShutdownScheduler");
        }

        #endregion
    }
}
