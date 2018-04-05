using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HotClicker
{
    public partial class Form1 : Form
    {
        bool timerRunning = false;
        int totalCommands;
        int currentCommand = 0;
        int elapsedTime = 0;
        List<Task> Tasks = new List<Task>();

        private void playSound(bool flagStart)
        {
            int NUM_OF_BEEPS=2;
            if (flagStart)
            {
                NUM_OF_BEEPS = 5;
            }
            for (int i = 0; i <= NUM_OF_BEEPS; i++)
            {
                System.Media.SystemSounds.Beep.Play();
                Thread.Sleep(100);
            }
        }
        private void startStop()
        {
            try
            {
                currentCommand = 0; 
                if (timerRunning)
                {
                    progressBar1.Value = 0;
                    elapsedTime = 0;
                    lblTimeRemaining.Text = "0//0";
                    timerRunning = false;
                    tmrClicker.Stop();
                    btnStartStop.Text = "Start";
                    playSound(false);
                }
                else
                {
                    totalCommands = lstCommands.Items.Count;
                    timerRunning = true;
                    tmrClicker.Start();
                    btnStartStop.Text = "Stop";
                    playSound(true);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Error #001: Incorrect inputs.");
            }
        }
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            startStop();
        }
        private void tmrClicker_Tick(object sender, EventArgs e)
        {
            int id = currentCommand;
            int type = Tasks[id].Type;
            int time = Tasks[id].TimeMS;
            int x = Tasks[id].X;
            int y = Tasks[id].Y;
            string cmd = Tasks[id].Command;
            elapsedTime++;
            double d1 = Convert.ToDouble(elapsedTime);
            double d2 = Convert.ToDouble(time);
            int val = Convert.ToInt32( ((d1 / d2) * 100) );
            lblTimeRemaining.Text = elapsedTime.ToString() + "/" + time.ToString() +  " - " + (currentCommand + 1).ToString();
            if (elapsedTime < time)
            {
                progressBar1.Value = val;
                return;
            }
            if (type == 0)
                keyClick(cmd);
            else if (type == 1)
                mouseClick(true, x, y);
            else if (type == 2)
                mouseClick(false, x, y);
            elapsedTime = 0;
            progressBar1.Value = 0;
            currentCommand++;
            if (currentCommand >= totalCommands)
                currentCommand = 0;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0); 
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddMouseL_Click(object sender, EventArgs e)
        {
            Tasks.Add(new Task(txtDelayBetweenClicks.Text, txtX.Text, txtY.Text, 1));
            lstCommands.Items.Add("Mouse Click [LEFT] - X: " + txtX.Text + " - Y: " + txtY.Text + " - Time: " + txtDelayBetweenClicks.Text);
            txtAdd.Text = "";
            txtDelayBetweenClicks.Text = "";
        }
        private void btnAddMouseR_Click(object sender, EventArgs e)
        {
            Tasks.Add(new Task(txtDelayBetweenClicks.Text, txtX.Text, txtY.Text, 2));
            lstCommands.Items.Add("Mouse Click [RIGHT] - X: " + txtX.Text + " - Y: " + txtY.Text + " - Time: " + txtDelayBetweenClicks.Text);
            txtAdd.Text = "";
            txtDelayBetweenClicks.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tasks.Add(new Task(txtAdd.Text, Convert.ToInt32(txtDelayBetweenClicks.Text)));
            lstCommands.Items.Add("Command: " + txtAdd.Text + " - Time: " + txtDelayBetweenClicks.Text);
            txtAdd.Text = "";
            txtDelayBetweenClicks.Text = "";
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lstCommands.SelectedIndex;
                Tasks.RemoveAt(i);
                lstCommands.Items.RemoveAt(i);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You didnt select an item to remove.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tmrMousePosition.Start();
        }
        private void tmrMousePosition_Tick(object sender, EventArgs e)
        {
            lblMousePosition.Text = "Mouse Position: X: " + Cursor.Position.X.ToString() + " - Y: " + Cursor.Position.Y.ToString();
        }
    }
}
