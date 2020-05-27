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
        int counter;
        Stopwatch greenWatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startTimer.Enabled = true;//start the timer

            greenWatch.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            greenWatch.Reset();
            //set displayed elapsed time as 0.0000
            //set colours to og
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            //display time since green was lit
            greenWatch.Stop();
            if (currentRow == 5 )//start is valid
            {
                startTimer.Enabled = false;
                outputLabel.Text = Convert.ToString(greenWatch.Elapsed);
            }
            if (currentRow >= 4)//start is foul
            {
                outputLabel.Text = "FOUL START";
            }
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            yellow1.BackColor = Color.Yellow;
            yellow2.BackColor = Color.Yellow;
            yellow3.BackColor = Color.Yellow;
            greenLabel.BackColor = Color.Green;
            outputLabel.Text = "" + counter;
        }
    }
}
