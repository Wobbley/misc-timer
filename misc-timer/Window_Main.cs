using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace Timed_Shutdown
{
    public partial class Window_Main : Form
    {
        public decimal seconds { get; set; }
        public decimal minutes { get; set; }
        public decimal hours { get; set; }
        public Boolean paused { get; set; }
        public int flag { get; set; }

        public Window_Main()
        {
            InitializeComponent();
            timer1.Interval = (1000) * (1);
            timer1.Enabled = false;
            buttonStop.Visible = false;
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboTask.SelectedIndex != -1)
            {
                //disable number boxes
                timerSeconds.Enabled = false;
                timerMinutes.Enabled = false;
                timerHours.Enabled = false;
                checkBoxForced.Enabled = false;
                comboTask.Enabled = false;
                //

                seconds = timerSeconds.Value;
                minutes = timerMinutes.Value;
                hours = timerHours.Value;

                updateLabels();

                timer1.Enabled = true;
                buttonStart.Visible = false;
                buttonStop.Visible = true;
                if (checkBoxForced.Checked)
                {
                    flag = comboTask.SelectedIndex + 4;
                }
                else
                {
                    flag = comboTask.SelectedIndex;
                }
            }
            else
            {
                MessageBox.Show("You need to select an action!");
            }

            //MessageBox.Show(flag.ToString());
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            seconds = 0;
            minutes = 0;
            hours = 0;

            timerSeconds.Enabled = true;
            timerMinutes.Enabled = true;
            timerHours.Enabled = true;
            checkBoxForced.Enabled = true;
            comboTask.Enabled = true;

            updateLabels();

            buttonStop.Visible = false;
            buttonStart.Visible = true;

            
        }
    

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0 && minutes == 0 && hours == 0)
            {
                timer1.Enabled = false;
                ShutDownComputer(flag);
                MessageBox.Show("Shutdown!");
            }
            else
            {
                if (seconds < 1)
                {
                    seconds = 59;
                    if (minutes == 0)
                    {
                        minutes = 59;
                        if (hours != 0)
                        {
                            hours--;
                        }
                    }
                    else
                    {
                        minutes--;
                    }

                }
                else 
                {
                    seconds--;
                }
            }
            updateLabels();
        }

        private void timerSeconds_ValueChanged(object sender, EventArgs e)
        {

        }


        private void ShutDownComputer(int flag)
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();
            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams = mcWin32.GetMethodParameters("Win32Shutdown");
            // Flag 1 means we want to shut down the system
            mboShutdownParams["Flags"] = flag;
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown", mboShutdownParams, null);
            }
        }
        private void updateLabels()
        {
            labelSeconds.Text = seconds.ToString();
            labelMinutes.Text = minutes.ToString();
            labelHours.Text = hours.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelSeconds_Click(object sender, EventArgs e)
        {

        }

        private void comboTask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
