// Project:       Message Formatter
// Programmer:    Tom Tsiliopoulos
// Date:          September 2013
// Description:   This project uses labels, text boxes, radio buttons,
// 	              a check box, images in picture boxes, and buttons 
//  			  to change the display.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson02_MessageFormatter
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            // Display the text in the message area.

            MessageLabel.Text = NameTextBox.Text + ":  " + MessageTextBox.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
         // Clear the text controls.

        var NTB = NameTextBox;
            // Clear the text box.
            NTB.Clear();
            // Reset the insertion point.
            NTB.Focus();

        MessageTextBox.Clear();
        MessageLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit program
            this.Close();
        }

        private void BlackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Make the label black.

            MessageLabel.ForeColor = Color.Black;
        }

        private void BlueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Make the label blue.

            MessageLabel.ForeColor = Color.Blue;
        }

        private void GreenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Make the label Green.

            MessageLabel.ForeColor = Color.Green;
        }

        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Make the label Red.

            MessageLabel.ForeColor = Color.Red;
        }

        private void BigPictureBox_Click(object sender, EventArgs e)
        {
        // Switch the icon.

        BigPictureBox.Visible = false;
        LittlePictureBox.Visible = true;
        }

        private void LittlePictureBox_Click(object sender, EventArgs e)
        {
            // Switch the icon.

        LittlePictureBox.Visible = false;
        BigPictureBox.Visible = true;
        }

        private void VisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility for messageLabel.

            MessageLabel.Visible = VisibleCheckBox.Checked;
        }
    }
}
