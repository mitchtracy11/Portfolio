// Project:       Colors
// Programmer:    Tom Tsiliopoulos
// Date:          September 2013
// Description:   Demonstrate changing a form's background and foreground
//                colors using two groups of radio buttons.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson02_Colors
{
    public partial class ColorsForm : Form
    {
        public ColorsForm()
        {
            InitializeComponent();
        }

        private void ColorsForm_Load(object sender, EventArgs e)
        {

        }

        private void BeigeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        // Set the form color to beige.

            this.BackColor = Color.Beige;
        }

        private void BlueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set the form color to blue.

            this.BackColor = Color.Blue;
        }

        private void YellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set the form color to yellow.

            this.BackColor = Color.Yellow;
        }

        private void GrayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set the form color to Gray.

            this.BackColor = Color.Gray;
        }

        private void BlackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        // Set the text color to black.

            this.ForeColor = Color.Black;
        }

        private void WhiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set the text color to white.

            this.ForeColor = Color.White;
        }
    }
}
