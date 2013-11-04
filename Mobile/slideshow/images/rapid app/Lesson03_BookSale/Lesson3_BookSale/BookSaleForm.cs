// Project:		BookSale
// Date:		September 2013
// Programmer:	Tom Tsiliopoulos
// Description:	This project inputs sales information for books.
// 				It calculates the extended price and discount for
// 				a sale.
// 				Uses variables, constants, and calculations.
// 				Note that no error trapping is included in this version
// 				of the program.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3_BookSale
{
    
    public partial class BookSaleForm : Form
    {
        // Declare the constant
        const decimal DISCOUNT_RATE_DECIMAL = 0.15m;
        private int Quantity = 0;

        public BookSaleForm()
        {
            InitializeComponent();
        }

        

        private void BookSaleForm_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
        // Calculate the price and discount.
        int QuantityInteger;
        decimal PriceDecimal, ExtendedPriceDecimal, DiscountDecimal,
           DiscountedPriceDecimal;

        try
        {
            // Convert input values to numeric variables.
            QuantityInteger = int.Parse(QuantityTextBox.Text);
            PriceDecimal = decimal.Parse(PriceTextBox.Text);

            // Calculate values.
            ExtendedPriceDecimal = QuantityInteger * PriceDecimal;
            DiscountDecimal = decimal.Round((ExtendedPriceDecimal * DISCOUNT_RATE_DECIMAL), 2);
            DiscountedPriceDecimal = ExtendedPriceDecimal - DiscountDecimal;

            // Format and display answers.
            ExtendedPriceTextBox.Text = ExtendedPriceDecimal.ToString("C");
            DiscountTextBox.Text = DiscountDecimal.ToString("N");
            DiscountedPriceTextBox.Text = DiscountedPriceDecimal.ToString("C");
        }
        catch (Exception TheException)
        {
            MessageBox.Show(TheException.Message);
        }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
        // Clear previous amounts from the form.

        TitleTextBox.Clear();
        PriceTextBox.Clear();
        ExtendedPriceTextBox.Clear();
        DiscountTextBox.Clear();
        DiscountedPriceTextBox.Clear();
        QuantityTextBox.Clear();
        QuantityTextBox.Focus();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
        // Print the form

            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
        // Exit the Project

            this.Close();
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Quantity = int.Parse(QuantityTextBox.Text);
            }
            catch (Exception theException)
            {
                MessageBox.Show(theException.Message);
            }
        }

        private void ExtendedPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
