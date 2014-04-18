using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private List<List<Point>> strokesList = new List<List<Point>>();
        private List<Pen> penList = new List<Pen>();
        private List<Point> currentStroke;
        private System.Drawing.Pen myPen = new Pen(Color.Red, 5);
        private bool drawing = false;

        public Form1()
        {
            // Init and setup painting/mouse events
            InitializeComponent();
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
        }

        private void canvas_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        // Draw all our strokes. And the color corrisponding to each stroke.
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < strokesList.Count; i++) {
                e.Graphics.DrawLines(penList[i], strokesList[i].ToArray());
            }
        }

        private void canvas_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) 
        // Paint on the canvas when the Left mouse button is down.
        {
            if (drawing)
            {
                currentStroke.Add(e.Location);
                this.Refresh();
            }
        }

        private void canvas_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        // Start drawing and record current stoke.
        {
            drawing = true;
            currentStroke = new List<Point>();
            currentStroke.Add(e.Location);
            strokesList.Add(currentStroke);
            penList.Add(myPen);
        }

        private void canvas_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) 
        // Stop drawing
        { 
            drawing = false; 
            foreach(Pen pen in penList) Console.Write(pen.Color+":"+pen.Width+",");
            Console.WriteLine();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Blue, brushSize.Value);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Red, brushSize.Value);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Yellow, brushSize.Value);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Lime, brushSize.Value);
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Orange, brushSize.Value);
        }

        private void btnAqua_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Aqua, brushSize.Value);
        }

        private void btnViolet_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Violet, brushSize.Value);
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Pink, brushSize.Value);
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.White, brushSize.Value);
        }

        private void btnLightGrey_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.LightGray, brushSize.Value);
        }

        private void btnGrey_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Gray, brushSize.Value);
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            myPen = new Pen(Color.Black, brushSize.Value);
        }

        private void brushSize_Scroll(object sender, EventArgs e)
        {
            myPen.Width = brushSize.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        // On clear empty list and repaint
        {
            strokesList.Clear();
            penList.Clear();
            canvas.Refresh();
        }

    }
}
