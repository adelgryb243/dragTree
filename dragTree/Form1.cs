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

namespace dragTree
{
    public partial class Form1 : Form
    {
        int currentRow = 1;
        Stopwatch greenWatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startTimer.Enabled = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            greenWatch.Reset();

            currentRow = 1;

            outputLabel.Text = " ";

            yellow1.BackColor = Color.Maroon;
            yellow2.BackColor = Color.Maroon;
            yellow3.BackColor = Color.Maroon;
            greenLabel.BackColor = Color.DarkOliveGreen;

            startTimer.Enabled = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            greenWatch.Stop();
            TimeSpan elapsed = greenWatch.Elapsed;

            if (currentRow <= 4)
            {
                outputLabel.Text = "FOUL START";
            }
           if (currentRow == 5)
            {
                
                outputLabel.Text = elapsed.ToString(@"ss\:ff");
            }
            
        }

        private void startTimer_Tick(object sender, EventArgs e)
        { 
            yellow1.BackColor = Color.Yellow;
            currentRow=2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yellow2.BackColor = Color.Yellow;
            currentRow=3;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            yellow3.BackColor = Color.Yellow;
            currentRow=4;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            greenLabel.BackColor = Color.Green;
            greenWatch.Start();
            currentRow=5;
        }
    }
}
