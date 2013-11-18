// Project:       Lesson01HandsOn
// Programmer:    Tom Tsiliopoulos
// Date:          September 2013
// Description:   This project displays current promotions for each department.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson01HandsOn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            // Display the current promotion.
            PromotionLabel.Text = "Buy two and get the second one for half price";
            PromotionCodeLabel.Text = "B608";
        }

        private void MusicButton_Click(object sender, EventArgs e)
        {
            // Display the current promotion.
            PromotionLabel.Text = "Get a free MP3 download with purchase of a CD";
            PromotionCodeLabel.Text = "M608";
        }

        private void PeriodicalsButton_Click(object sender, EventArgs e)
        {
            // Display the current promotion.
            PromotionLabel.Text = "Elite members get 10% off every purchase";
            PromotionCodeLabel.Text = "P608";
        }

        private void CoffeeBarButton_Click(object sender, EventArgs e)
        {
            // Display the current promotion.
            PromotionLabel.Text = "Celebrate the season with 20% off specialty drinks";
            PromotionCodeLabel.Text = "C608";
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Print the form
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the program
            this.Close();
        }
    }
}
