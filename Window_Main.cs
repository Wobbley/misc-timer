using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timed_Shutdown
{
    public partial class Window_Main : Form
    {
        public decimal seconds { get; set; }
        public decimal minutes { get; set; }
        public decimal hours { get; set; }
        public Boolean paused { get; set; }
        public int selectedIndex { get; set; }
        public Timed_Shutdown.Actions act = new Timed_Shutdown.Actions();

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

                seconds = timerSeconds.Value;
                minutes = timerMinutes.Value;
                hours = timerHours.Value;

                updateLabels();

                timer1.Enabled = true;
                buttonStart.Visible = false;
                buttonStop.Visible = true;

                selectedIndex = comboTask.SelectedIndex;
                if (checkBoxForced.Checked)
                {
                    selectedIndex = selectedIndex + 4;
                }
                
            }
            else
            {
                MessageBox.Show("You need to select an action!");
            }
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
                doTask(selectedIndex);


                //Clean and update the interface.
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


        private void updateLabels()
        {
            labelSeconds.Text = seconds.ToString();
            labelMinutes.Text = minutes.ToString();
            labelHours.Text = hours.ToString();
        }

        private void doTask(int selectedIndex){
            if (selectedIndex == 3)
            {
                act.Alarm();
            }
            else if (selectedIndex < 7)
            {
                act.ShutDownComputer(selectedIndex);
            }
            else
            {
                MessageBox.Show("Invalid Action!");
            }
        }
    }
}
