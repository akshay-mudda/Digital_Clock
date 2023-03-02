namespace Digital_Clock
{
    partial class DigitalClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigitalClock));
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.redButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orangeButton = new System.Windows.Forms.Button();
            this.yelowButton = new System.Windows.Forms.Button();
            this.limeButton = new System.Windows.Forms.Button();
            this.cyanButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.backgroundColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.Color.White;
            this.clockLabel.Location = new System.Drawing.Point(6, 33);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(589, 253);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "Loading...";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(12, 315);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(23, 23);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeButton.Location = new System.Drawing.Point(41, 315);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(23, 23);
            this.orangeButton.TabIndex = 2;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // yelowButton
            // 
            this.yelowButton.BackColor = System.Drawing.Color.Yellow;
            this.yelowButton.Location = new System.Drawing.Point(70, 315);
            this.yelowButton.Name = "yelowButton";
            this.yelowButton.Size = new System.Drawing.Size(23, 23);
            this.yelowButton.TabIndex = 3;
            this.yelowButton.UseVisualStyleBackColor = false;
            this.yelowButton.Click += new System.EventHandler(this.yelowButton_Click);
            // 
            // limeButton
            // 
            this.limeButton.BackColor = System.Drawing.Color.Lime;
            this.limeButton.Location = new System.Drawing.Point(99, 315);
            this.limeButton.Name = "limeButton";
            this.limeButton.Size = new System.Drawing.Size(23, 23);
            this.limeButton.TabIndex = 4;
            this.limeButton.UseVisualStyleBackColor = false;
            this.limeButton.Click += new System.EventHandler(this.limeButton_Click);
            // 
            // cyanButton
            // 
            this.cyanButton.BackColor = System.Drawing.Color.Cyan;
            this.cyanButton.Location = new System.Drawing.Point(128, 315);
            this.cyanButton.Name = "cyanButton";
            this.cyanButton.Size = new System.Drawing.Size(23, 23);
            this.cyanButton.TabIndex = 5;
            this.cyanButton.UseVisualStyleBackColor = false;
            this.cyanButton.Click += new System.EventHandler(this.cyanButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(157, 315);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(23, 23);
            this.blueButton.TabIndex = 6;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.BackColor = System.Drawing.Color.Fuchsia;
            this.pinkButton.Location = new System.Drawing.Point(215, 315);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(23, 23);
            this.pinkButton.TabIndex = 7;
            this.pinkButton.UseVisualStyleBackColor = false;
            this.pinkButton.Click += new System.EventHandler(this.pinkButton_Click_1);
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.BlueViolet;
            this.purpleButton.Location = new System.Drawing.Point(186, 315);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(23, 23);
            this.purpleButton.TabIndex = 8;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Click += new System.EventHandler(this.purpleButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.whiteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.whiteButton.FlatAppearance.BorderSize = 0;
            this.whiteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.whiteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.whiteButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteButton.ForeColor = System.Drawing.Color.Black;
            this.whiteButton.Location = new System.Drawing.Point(526, 12);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(69, 31);
            this.whiteButton.TabIndex = 9;
            this.whiteButton.Text = "Reset";
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // backgroundColor
            // 
            this.backgroundColor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.backgroundColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backgroundColor.FlatAppearance.BorderSize = 0;
            this.backgroundColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.backgroundColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.backgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundColor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundColor.Location = new System.Drawing.Point(601, 12);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(84, 31);
            this.backgroundColor.TabIndex = 10;
            this.backgroundColor.Text = "Light / Dark";
            this.backgroundColor.UseVisualStyleBackColor = false;
            this.backgroundColor.Click += new System.EventHandler(this.backgroundColor_Click);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(697, 350);
            this.Controls.Add(this.backgroundColor);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.purpleButton);
            this.Controls.Add(this.pinkButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.cyanButton);
            this.Controls.Add(this.limeButton);
            this.Controls.Add(this.yelowButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.clockLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DigitalClock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button yelowButton;
        private System.Windows.Forms.Button limeButton;
        private System.Windows.Forms.Button cyanButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button pinkButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button backgroundColor;
    }
}

