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
        private Image canvasImg;                                                    // When a image is loaded store it here so it's redrawn on paint events

        public Form1()
        {
            // Init and setup painting/mouse events
            InitializeComponent();
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas_anyColor.Paint += new System.Windows.Forms.PaintEventHandler(this.btnColors_Paint);
            canvas.Image = new Bitmap(canvas.Width, canvas.Height);
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
            var g = Graphics.FromImage(canvas.Image);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(new SolidBrush(Color.White), canvas.ClientRectangle);
            if (canvasImg != null) {
                g.FillRectangle(new TextureBrush(canvasImg, canvas.ClientRectangle), canvas.ClientRectangle);
            }
            for (int i = 0; i < strokesList.Count; i++)
            {
                g.DrawLines(penList[i], strokesList[i].ToArray());
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
            if (currentStroke == null) canvas_MouseDown(sender, e); // If there was no mousedown event call it.
            currentStroke.Add(e.Location);                          // Adds second point for required line if mouse doesn't move
            this.Refresh();
        }

        private void brushSize_Scroll(object sender, ScrollEventArgs e)
        // Change the width of our pen to the value of the scroll
        {
            myPen = new Pen(color, brushSize.Value);
            myPen.Width = brushSize.Value;
            // debug information
            this.txtWidth.Text = brushSize.Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        // On clear empty list and clear canvas, then repaint
        {
            var g = Graphics.FromImage(canvas.Image);
            g.FillRectangle(new SolidBrush(Color.White), canvas.ClientRectangle);
            strokesList.Clear();
            penList.Clear();
            canvas.Refresh();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            setColor(Color.Red);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            setColor(Color.Blue);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            setColor(Color.Yellow);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            setColor(Color.Lime);
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            setColor(Color.Orange);
        }

        private void btnAqua_Click(object sender, EventArgs e)
        {
            setColor(Color.Aqua);
        }

        private void btnDarkGray_Click(object sender, EventArgs e)
        {
            setColor(Color.DarkGray);
        }

        private void btnLightGray_Click(object sender, EventArgs e)
        {
            setColor(Color.LightGray);
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            setColor(Color.Black);
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            setColor(Color.White);
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
            if (MyDialog.ShowDialog() == DialogResult.OK) color = MyDialog.Color;

            setColor(color);
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            // Set the brush size to the value of the text, max a 500.
            int value = 1;
            try {
                value = Int32.Parse(this.txtWidth.Text);
            } catch(FormatException E) { /*Do nothing on bad input, will be treated as 1*/ }
            if (value < 1) value = 1;
            else if (value > 50) value = 50;
            brushSize.Value = value;
            myPen = new Pen(color, brushSize.Value);
            myPen.Width = brushSize.Value;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                Image img = new Bitmap(openFileDialog1.FileName);
                canvasImg = new Bitmap(openFileDialog1.FileName); // This way there is not a shallow copy so canvasImg is not tired to canvas.Image
                canvas.Image = img;
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Image|*.png|JPeg Image|*.jpg|Gif Image|*.gif";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = canvas.Image;
                img.Save(saveFileDialog1.FileName);
            }
        }

        private void setColor(Color color) {
            myPen = new Pen(color, brushSize.Value);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (penList.Count > 0) penList.RemoveAt(penList.Count - 1);
            if (strokesList.Count > 0) strokesList.RemoveAt(strokesList.Count - 1);
            canvas.Refresh();
        }
    }
}
