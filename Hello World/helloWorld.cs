using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// By Spencer Wieczorek

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent(); // Create our form.
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
             txtBox.Focus(); // Set curser on text box.
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            sayHello(txtBox.Text);
        }

        private void txtBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) 
        {
            lblSubmit.Text = "...";
            Console.Write("...");
        }

        public void sayHello(string name)
        // Say Hello
        {
            lblSubmit.Text = "Hello, " + name;
        }

    }
}
