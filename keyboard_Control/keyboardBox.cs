using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboard
{
    public partial class Form1 : Form
    {
        bool LEFT = false;
        bool RIGHT = false;
        int speed = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) LEFT = true;
            if (e.KeyCode == Keys.Right) RIGHT = true;
        }

        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) LEFT = false;
            if (e.KeyCode == Keys.Right) RIGHT = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int X = pictureBox1.Location.X;
            int Y = pictureBox1.Location.Y;

            if (LEFT && X > 0) 
                pictureBox1.Location = new Point(X - speed, Y);
            if (RIGHT && X < ClientRectangle.Width - pictureBox1.Width) 
                pictureBox1.Location = new Point(X + speed, Y);

        }
    }
}