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

namespace Basic_Paint
{
    public partial class Form1 : Form
    {
        private List<List<Point>> strokesList = new List<List<Point>>();            // List of all the strokes on the canvas
        private List<Pen> penList = new List<Pen>();                                // Keeps track of the pen (color) used.
        private List<Point> currentStroke;                                          // A "stroke" is a list of points.
        private Color color = Color.Red;                                            // Default color of red
        private System.Drawing.Pen myPen = new Pen(Color.Red, 5);                   // Starting Pen is red with a width of5
        private bool drawing = false;                                               // Currently not drawing on the canvas (mouse not held down)

        public Form1()
        {
            // Init and setup painting/mouse events
            InitializeComponent();
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas_anyColor.Paint += new System.Windows.Forms.PaintEventHandler(this.btnColors_Paint);
        }

        private void btnColors_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Draw onto anyColor as a rainbow color
            LinearGradientBrush br = new LinearGradientBrush(this.canvas_anyColor.ClientRectangle, Color.Black, Color.Black, 0, false);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 1 / 6f, 2 / 6f, 3 / 6f, 4 / 6f, 5 / 6f, 1 };
            cb.Colors = new[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
            br.InterpolationColors = cb;
            // paint
            e.Graphics.FillRectangle(br, this.canvas_anyColor.ClientRectangle);
        }

        private void canvas_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        // Draw all our strokes. And the color corrisponding to each stroke.
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < strokesList.Count; i++)
            {
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
            myPen.StartCap = LineCap.Round;
            myPen.EndCap = LineCap.Round;
            penList.Add(myPen);
        }

        private void canvas_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        // Stop drawing
        {
            drawing = false;
            currentStroke.Add(e.Location); // Adds second point for required line if mouse doesn't move
            // debug information
            this.Refresh();
        }

        private void brushSize_Scroll(object sender, ScrollEventArgs e)
        // Change the width of our pen to the value of the scroll
        {
            myPen = new Pen(color, brushSize.Value);
            myPen.Width = brushSize.Value;
            // debug information
            Console.WriteLine(myPen.Width);
        }

        private void button1_Click(object sender, EventArgs e)
        // On clear empty list and repaint
        {
            strokesList.Clear();
            penList.Clear();
            canvas.Refresh();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            color = Color.Red;
            myPen = new Pen(color, brushSize.Value);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
            myPen = new Pen(color, brushSize.Value);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
            myPen = new Pen(color, brushSize.Value);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            color = Color.Lime;
            myPen = new Pen(color, brushSize.Value);
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            color = Color.Orange;
            myPen = new Pen(color, brushSize.Value);
        }

        private void btnAqua_Click(object sender, EventArgs e)
        {
            color = Color.Aqua;
            myPen = new Pen(color, brushSize.Value);
        }

        private void canvas_anyColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = color;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                color = MyDialog.Color;

            myPen = new Pen(color, brushSize.Value);
        }

        private void btnDarkGray_Click(object sender, EventArgs e)
        {
            color = Color.DarkGray;
            myPen = new Pen(color, brushSize.Value);
        }

        private void btnLightGray_Click(object sender, EventArgs e)
        {
            color = Color.LightGray;
            myPen = new Pen(color, brushSize.Value);
        }
    }
}
