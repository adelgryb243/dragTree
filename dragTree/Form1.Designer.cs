namespace dragTree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yellow1 = new System.Windows.Forms.Label();
            this.yellow2 = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.yellow3 = new System.Windows.Forms.Label();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(475, 227);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(108, 78);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(637, 227);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(108, 78);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // goButton
            // 
            this.goButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.goButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(475, 333);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(270, 68);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(487, 115);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(274, 77);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "REACTION: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 60);
            this.label2.TabIndex = 10;
            this.label2.Text = "THE       RACING       TREE";
            // 
            // yellow1
            // 
            this.yellow1.BackColor = System.Drawing.Color.Maroon;
            this.yellow1.Location = new System.Drawing.Point(66, 115);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(373, 47);
            this.yellow1.TabIndex = 13;
            // 
            // yellow2
            // 
            this.yellow2.BackColor = System.Drawing.Color.Maroon;
            this.yellow2.Location = new System.Drawing.Point(69, 194);
            this.yellow2.Name = "yellow2";
            this.yellow2.Size = new System.Drawing.Size(370, 47);
            this.yellow2.TabIndex = 14;
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.greenLabel.Location = new System.Drawing.Point(72, 347);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(367, 54);
            this.greenLabel.TabIndex = 15;
            // 
            // yellow3
            // 
            this.yellow3.BackColor = System.Drawing.Color.Maroon;
            this.yellow3.Location = new System.Drawing.Point(69, 271);
            this.yellow3.Name = "yellow3";
            this.yellow3.Size = new System.Drawing.Size(370, 51);
            this.yellow3.TabIndex = 16;
            // 
            // startTimer
            // 
            this.startTimer.Interval = 400;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yellow3);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.yellow2);
            this.Controls.Add(this.yellow1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yellow1;
        private System.Windows.Forms.Label yellow2;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label yellow3;
        private System.Windows.Forms.Timer startTimer;
    }
}

