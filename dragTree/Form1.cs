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
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            greenWatch.Stop();

            
            if (greenWatch.ElapsedMilliseconds > 0)
            {
                outputLabel.Text = "0." + greenWatch.ElapsedMilliseconds.ToString("000");
            }
            else
            {
                outputLabel.Text = "FOUL START";
            }           
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            switch (currentRow)
            {
                case 1:
                    yellow1.BackColor = Color.Yellow;
                    break;
                case 2:
                    yellow2.BackColor = Color.Yellow;
                    break;
                case 3:
                    yellow3.BackColor = Color.Yellow;
                    break;
                case 4:
                    greenLabel.BackColor = Color.Green;
                    startTimer.Stop();
                    greenWatch.Start();
                    break;
            }
           currentRow++;
        }
    }
}
