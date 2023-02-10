using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShutDown_Timer
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }
        //Activation Button
        private void activatebtn_Click(object sender, EventArgs e)
        {
            string HourLabel = (textBoxHour.Text);
            string MinuteLabel = (textBoxMin.Text);
            string SecondLabel = (textBoxSec.Text);
            if (MinuteLabel=="" && SecondLabel =="" && HourLabel!="")
            {
                HourTimer(HourLabel);
            }
            else if (HourLabel == ""& MinuteLabel!="" & SecondLabel == "")
            {
                MinuteTimer(MinuteLabel);
            }
            else if (HourLabel==""&MinuteLabel==""&SecondLabel!="")
            {
                SecondTimer(SecondLabel);
            }
            else if (HourLabel==""&MinuteLabel==""&SecondLabel=="")
            {
                MessageBox.Show("Fill any of this field!", "Error");
            }
            else
            {
                TotalTimer(HourLabel, MinuteLabel, SecondLabel);
            }
            //After Clicking clearing Fields
            textBoxHour.Clear();
            textBoxMin.Clear();
            textBoxSec.Clear();
        }
        //Deactivation Button
        private void deactivatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("shutdown.exe", "/a");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!!", "Erroe");
            }
        }
        private void HourTimer(string hour)
        {
            int ConvertHour=Convert.ToInt32(hour);
            int MultiplySecondsToHour = ConvertHour * 3600;
            try
            {
                Process.Start("shutdown.exe", $"/s /t {MultiplySecondsToHour}");
                MessageBox.Show($"Your PC will turn of in {MultiplySecondsToHour/3600} Hour", "Success");
            }
            catch (SyntaxErrorException ex)
            {
                MessageBox.Show("Label is Empty!", "Error");
            }
        }
        private void MinuteTimer(string min)
        {
            int ConvertHour = Convert.ToInt32(min);
            int MultiplySecondsToMinute = ConvertHour * 60;
            try
            {
                Process.Start("shutdown.exe", $"/s /t {MultiplySecondsToMinute}");
                MessageBox.Show($"Your PC will turn of in {MultiplySecondsToMinute / 60} Minute", "Success");
            }
            catch (SyntaxErrorException ex)
            {
                MessageBox.Show("Label is Empty!", "Error");
            }
        }
        private void SecondTimer(string second)
        {
            int ConvertSecond = Convert.ToInt32(second);
            try
            {
                Process.Start("shutdown.exe", $"/s /t {ConvertSecond}");
                MessageBox.Show($"Your PC will turn of in {ConvertSecond} Second", "Success");
            }
            catch (SyntaxErrorException ex)
            {
                MessageBox.Show("Label is Empty!", "Error");
            }
        }
        private void TotalTimer(string hour,string min,string second)
        {
            int ConvertHour = Convert.ToInt32(hour);
            int ConvertMin = Convert.ToInt32(min);
            int ConvertSecond = Convert.ToInt32(second);
            int MultiplyHourToSecond = ConvertHour * 3600;
            int MultiplyMinuteToSecond = ConvertMin * 60;
            try
            {
                Process.Start("shutdown.exe", $"/s /t {MultiplyHourToSecond+MultiplyMinuteToSecond+ConvertSecond}");
                MessageBox.Show($"Your PC will turn of in {MultiplyHourToSecond / 3600} Hour {MultiplyMinuteToSecond/60} Minute {ConvertSecond} Second", "Success");
            }
            catch (SyntaxErrorException ex)
            {
                MessageBox.Show("Label is Empty!", "Error");
            }
        }
    }
}
