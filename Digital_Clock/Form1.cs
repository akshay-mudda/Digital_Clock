using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            orangeButton.FlatStyle = FlatStyle.Flat;
            limeButton.FlatStyle = FlatStyle.Flat;
            cyanButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
            purpleButton.FlatStyle = FlatStyle.Flat;
            pinkButton.FlatStyle = FlatStyle.Flat;
            whiteButton.FlatStyle = FlatStyle.Flat;
            yelowButton.FlatStyle = FlatStyle.Flat;
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
            
            clockLabel.AutoSize = true;
            clockLabel.AutoSize = false;
            clockLabel.TextAlign = ContentAlignment.MiddleRight;
            clockLabel.Width = 700;
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string timeText = currentTime.ToString("hh:mm:ss tt");
            clockLabel.Text = timeText;

            
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Red;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor= Color.Orange;
        }

        private void yelowButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor= Color.Yellow;
        }

        private void limeButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor= Color.LimeGreen;
        }

        private void cyanButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor= Color.Cyan;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Blue;
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Pink;
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Purple;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            backgroundColor.BackColor = Color.DarkSeaGreen;

            // Set the foreground color of the button to white
            backgroundColor.ForeColor = Color.White;

            // Set the font of the button to bold
            backgroundColor.Font = new Font(backgroundColor.Font, FontStyle.Bold);

            // Set the flat style of the button to "Flat"
            backgroundColor.FlatStyle = FlatStyle.Flat;

            if (this.BackColor == Color.White)
            {
                clockLabel.ForeColor = Color.Black;
            }
            else
            {
                clockLabel.ForeColor = Color.White;
            }
        }

        private void pinkButton_Click_1(object sender, EventArgs e)
        {
            clockLabel.ForeColor= Color.DeepPink;
        }

        private void backgroundColor_Click(object sender, EventArgs e)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 4; // set the desired radius for the corners
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(0, 0, diameter, diameter);
            path.AddArc(arc, 180, 90);
            arc.X = backgroundColor.Width - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = backgroundColor.Height - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = 0;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            backgroundColor.Region = new Region(path);


            backgroundColor.BackColor = Color.SeaGreen;

            // Set the foreground color of the button to white
            backgroundColor.ForeColor = Color.Black;

            // Set the font of the button to bold
            backgroundColor.Font = new Font(backgroundColor.Font, FontStyle.Bold);

            // Set the flat style of the button to "Flat"
            backgroundColor.FlatStyle = FlatStyle.Flat;

            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White; // Set font color to white
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black; // Set font color to black
            }
        }
    }
}
