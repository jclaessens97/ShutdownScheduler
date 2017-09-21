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
        #region Data

        private const string BTN_TEXT_CANCEL = "Cancel";
        private const string BTN_TEXT_SCHEDULE = "Schedule shutdown";

        //Set to one week each
        private const int MILLIS_MAX = 604800000;
        private const int SECS_MAX = 604800;
        private const int MINS_MAX = 10080;
        private const int HRS_MAX = 168;

        private enum TimeTypes : byte
        {
            Milliseconds = 0,
            Seconds,
            Minutes,
            Hours
        }
        private enum ShutdownTypes : byte
        {
            Shutdown = 0,
            Logoff,
            Restart
        }

        private bool scheduled;
        private bool showCustomMessagebox;

        public bool Scheduled
        {
            get => scheduled;
            set
            {
                scheduled = value;

                if (scheduled)
                {
                    btnShutdownOrCancel.Text = BTN_TEXT_CANCEL;
                }
                else
                {
                    btnShutdownOrCancel.Text = BTN_TEXT_SCHEDULE;
                }
            }
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        #region Events

        private void cbTimeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            switch (cb.SelectedItem)
            {
                case TimeTypes.Milliseconds:
                    numTime.Maximum = MILLIS_MAX;
                    break;
                case TimeTypes.Seconds:
                    numTime.Maximum = SECS_MAX;
                    break;
                case TimeTypes.Minutes:
                    numTime.Maximum = MINS_MAX;
                    break;
                case TimeTypes.Hours:
                    numTime.Maximum = HRS_MAX;
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
            if (Scheduled)
            {
                Cancel();
            }
            else
            {
                Schedule();
            }
        }

        private void pbHelpIcon_Click(object sender, EventArgs e)
        {
            var msg = "Windows 10 shows own messages about scheduled shutdowns, but sometimes they fail.";
            msg += "If you want to be sure to always get the dialog or if your on an earlier version of windows, it shows custom messageboxes.";
            msg += "You can enable or disable them by using the checkbox.";
            ShowMessageBox(msg);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Terminate();
        }

        #endregion

        #region Methods

        private void Init()
        {
            cbTimeType.DataSource = Enum.GetValues(typeof(TimeTypes));
            rblShutdownTypes.DataSource = Enum.GetValues(typeof(ShutdownTypes));

            numTime.Text = Properties.Settings.Default.Time.ToString();
            cbTimeType.SelectedIndex = Properties.Settings.Default.TimeType;
            rblShutdownTypes.SelectedIndex = Properties.Settings.Default.ShutdownType;
            Scheduled = Properties.Settings.Default.Scheduled;
        }

        private void Schedule()
        {
            string command = "shutdown";
            string msg = string.Empty;

            switch (rblShutdownTypes.SelectedItem)
            {
                case ShutdownTypes.Shutdown:
                    command += " /s";
                    msg = "Shutdown";
                    break;
                case ShutdownTypes.Logoff:
                    command += " /l";
                    msg = "Logoff";
                    break;
                case ShutdownTypes.Restart:
                    command += " /r";
                    msg = "Restart";
                    break;
            }

            var timeTypes = (TimeTypes) cbTimeType.SelectedIndex;
            var time = ConvertToSecs(Int32.Parse(numTime.Text), timeTypes);
            command += " /t " + time;

            ExecuteCommand(command);
            Scheduled = true;

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
            Scheduled = false;

            if (showCustomMessagebox)
            {
                ShowMessageBox("Scheduled shutdown is canceled!");
            }
        }

        private void Terminate()
        {
            Properties.Settings.Default.Time = Int32.Parse(numTime.Text);
            Properties.Settings.Default.TimeType = (byte) cbTimeType.SelectedIndex;
            Properties.Settings.Default.ShutdownType = (byte) rblShutdownTypes.SelectedIndex;
            Properties.Settings.Default.Scheduled = scheduled;
            Properties.Settings.Default.Save();
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
