namespace Basic_Paint
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.brushSize = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnAqua = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.canvas_anyColor = new System.Windows.Forms.PictureBox();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnDarkGray = new System.Windows.Forms.Button();
            this.btnLightGray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas_anyColor)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(86, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(534, 322);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brushSize
            // 
            this.brushSize.LargeChange = 5;
            this.brushSize.Location = new System.Drawing.Point(53, 220);
            this.brushSize.Maximum = 20;
            this.brushSize.Minimum = 1;
            this.brushSize.Name = "brushSize";
            this.brushSize.Size = new System.Drawing.Size(17, 80);
            this.brushSize.TabIndex = 5;
            this.brushSize.Value = 1;
            this.brushSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.brushSize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "1";
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRed.Location = new System.Drawing.Point(15, 12);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(20, 20);
            this.btnRed.TabIndex = 8;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlue.Location = new System.Drawing.Point(41, 12);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(20, 20);
            this.btnBlue.TabIndex = 9;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYellow.Location = new System.Drawing.Point(15, 38);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(20, 20);
            this.btnYellow.TabIndex = 10;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Lime;
            this.btnGreen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreen.Location = new System.Drawing.Point(41, 38);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(20, 20);
            this.btnGreen.TabIndex = 11;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrange.Location = new System.Drawing.Point(15, 64);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(20, 20);
            this.btnOrange.TabIndex = 12;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnAqua
            // 
            this.btnAqua.BackColor = System.Drawing.Color.Aqua;
            this.btnAqua.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAqua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAqua.Location = new System.Drawing.Point(41, 64);
            this.btnAqua.Name = "btnAqua";
            this.btnAqua.Size = new System.Drawing.Size(20, 20);
            this.btnAqua.TabIndex = 13;
            this.btnAqua.UseVisualStyleBackColor = false;
            this.btnAqua.Click += new System.EventHandler(this.btnAqua_Click);
            // 
            // canvas_anyColor
            // 
            this.canvas_anyColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas_anyColor.Location = new System.Drawing.Point(15, 146);
            this.canvas_anyColor.Name = "canvas_anyColor";
            this.canvas_anyColor.Size = new System.Drawing.Size(46, 18);
            this.canvas_anyColor.TabIndex = 15;
            this.canvas_anyColor.TabStop = false;
            this.canvas_anyColor.Click += new System.EventHandler(this.canvas_anyColor_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlack.Location = new System.Drawing.Point(15, 90);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(20, 20);
            this.btnBlack.TabIndex = 16;
            this.btnBlack.UseVisualStyleBackColor = false;
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWhite.Location = new System.Drawing.Point(41, 90);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(20, 20);
            this.btnWhite.TabIndex = 17;
            this.btnWhite.UseVisualStyleBackColor = false;
            // 
            // btnDarkGray
            // 
            this.btnDarkGray.BackColor = System.Drawing.Color.DarkGray;
            this.btnDarkGray.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDarkGray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDarkGray.Location = new System.Drawing.Point(15, 116);
            this.btnDarkGray.Name = "btnDarkGray";
            this.btnDarkGray.Size = new System.Drawing.Size(20, 20);
            this.btnDarkGray.TabIndex = 18;
            this.btnDarkGray.UseVisualStyleBackColor = false;
            this.btnDarkGray.Click += new System.EventHandler(this.btnDarkGray_Click);
            // 
            // btnLightGray
            // 
            this.btnLightGray.BackColor = System.Drawing.Color.LightGray;
            this.btnLightGray.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLightGray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLightGray.Location = new System.Drawing.Point(41, 116);
            this.btnLightGray.Name = "btnLightGray";
            this.btnLightGray.Size = new System.Drawing.Size(20, 20);
            this.btnLightGray.TabIndex = 19;
            this.btnLightGray.UseVisualStyleBackColor = false;
            this.btnLightGray.Click += new System.EventHandler(this.btnLightGray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 342);
            this.Controls.Add(this.btnLightGray);
            this.Controls.Add(this.btnDarkGray);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.canvas_anyColor);
            this.Controls.Add(this.btnAqua);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brushSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Basic Paint";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas_anyColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar brushSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnAqua;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox canvas_anyColor;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnDarkGray;
        private System.Windows.Forms.Button btnLightGray;
    }
}

