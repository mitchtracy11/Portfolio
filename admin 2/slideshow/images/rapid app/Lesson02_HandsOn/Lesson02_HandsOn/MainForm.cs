// Program:       Lesson 02 Hands On Practice
// Programmer:    Tom Tsiliopoulos
// Date:          September 2013
// Description:   Allow the user to sign in and display current sales promotion.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson02_HandsOn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BooksRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        // Display the image and promotion for the Books department.
        DepartmentPictureBox.Image = Properties.Resources.Book;
        PromotionTextBox.Text = "Buy two, get the second one for half price.";
        }

        private void MusicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        // Display the image and promotion for the Music department.
        DepartmentPictureBox.Image = Properties.Resources.Music;
        PromotionTextBox.Text = "Get a free MP3 download with purchase of a CD.";
        }

        private void PeriodicalsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        // Display the image and promotion for the Periodicals department.
        DepartmentPictureBox.Image = Properties.Resources.Periodicals;
        PromotionTextBox.Text = "Elite members receive 10% off every purchase.";
        }

        private void CoffeeBarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        // Display the image and promotion for the Music department.
        DepartmentPictureBox.Image = Properties.Resources.Music;
        PromotionTextBox.Text = "Get a free MP3 download with purchase of a CD.";
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
        // Set up the screen to display the department promotions and the 
        //  welcome message. Hide the sign-in controls.

        // Hide and disable the sign-in controls.
        CheckInGroupBox.Visible = false;
        SignInButton.Enabled = false;

        // Enable the group of radio buttons.        
        DepartmentGroupBox.Enabled = true;

        // Show the promotions controls.
        PromotionTextBox.Visible = true;
        ImageVisibleCheckBox.Visible = true;
        WelcomeRichTextBox.Visible = true;

        // Display the welcome message.
        WelcomeRichTextBox.Text = "Welcome Member #" + MemberIDMaskedTextBox.Text
          + Environment.NewLine + NameTextBox.Text;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
        // Print the form in the Print Preview window.

            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
        // End the program.
            this.Close();
        }

        private void ImageVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DepartmentPictureBox.Visible = ImageVisibleCheckBox.Checked;
        }
    }
}
