using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownClock
{
    public partial class Form2 : Form
    {
        string Title;
        DateTime Time;
        public Form2(string title, DateTime time)
        {
            InitializeComponent();
            timer1.Start();
            Title = title;
            Time = time;
            lbTitel.Text = Title;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan timespan = Time - DateTime.Now;
            int Days = timespan.Days;
            lbDays.Text = Days.ToString("000");
           
            if (Days >0)
            {
                circleDays.Maximum = Days;
                circleDays.Minimum = 0;
                circleDays.Value = 1;
            }
            else
            {
                circleDays.Maximum = 1;
                circleDays.Minimum = 0;
                circleDays.Value = 0;
            }
            circleHours.Maximum = 23;
            circleHours.Minimum = 0;


            int h = 23 - DateTime.Now.Hour;
            int m = 59-DateTime.Now.Minute;
            int s = 59-DateTime.Now.Second;

            lbHours.Text = h.ToString("00");
            lbMinutes.Text = m.ToString("00");
            lbSeconds.Text = s.ToString("00");

            circleHours.Value = h;
            circleMinutes.Value = m;
            circleSeconds.Value = s;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void circleHours_Click(object sender, EventArgs e)
        {

        }

        private void lbMinutes_Click(object sender, EventArgs e)
        {

        }

        private void lbSeconds_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://github.com/103cuong";
            System.Diagnostics.Process.Start(targetURL);
        }
    }
}
