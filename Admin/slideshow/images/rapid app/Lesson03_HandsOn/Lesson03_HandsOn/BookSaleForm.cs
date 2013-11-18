// Project:		Lesson 3 HandsOn
// Date:		September 2013
// Programmer:  Tom Tsiliopoulos
// Description:	This project inputs sales information for books.
// 				It calculates the extended price and discount for
// 				a sale and maintains summary information for all
// 				sales.
// 				Uses variables, constants, calculations, error
// 				handling, and a message box to the user.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson03_HandsOn
{
    public partial class BookSaleForm : Form
    {
        // Declare module-level variables and constants.
        private int QuantitySumInteger, SaleCountInteger;
        private decimal DiscountSumDecimal, DiscountedPriceSumDecimal;
        const decimal DISCOUNT_RATE_Decimal = 0.15m;

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
                DiscountedPriceDecimal, AverageDiscountDecimal;

            try
            {
                // Convert quantity to numeric variable.
                QuantityInteger = int.Parse(QuantityTextBox.Text);

                try
                {
                    // Convert price if quantity was successful.
                    PriceDecimal = decimal.Parse(PriceTextBox.Text);
                    // Calculate values for sale.
                    ExtendedPriceDecimal = QuantityInteger * PriceDecimal;
                    DiscountDecimal = decimal.Round(
                        (ExtendedPriceDecimal * DISCOUNT_RATE_Decimal), 2);
                    DiscountedPriceDecimal = ExtendedPriceDecimal - DiscountDecimal;

                    // Calculate summary values.
                    QuantitySumInteger += QuantityInteger;
                    DiscountSumDecimal += DiscountDecimal;
                    DiscountedPriceSumDecimal += DiscountedPriceDecimal;
                    SaleCountInteger += 1;
                    AverageDiscountDecimal = DiscountSumDecimal / SaleCountInteger;

                    // Format and display answers for the sale.
                    ExtendedPriceTextBox.Text = ExtendedPriceDecimal.ToString("C");
                    DiscountTextBox.Text = DiscountDecimal.ToString("N");
                    DiscountedPriceTextBox.Text = DiscountedPriceDecimal.ToString("C");

                    // Format and display summary values.
                    QuantitySumTextBox.Text = QuantitySumInteger.ToString();
                    DiscountSumTextBox.Text = DiscountSumDecimal.ToString("C");
                    DiscountAmountSumTextBox.Text = DiscountedPriceSumDecimal.ToString("C");
                    AverageDiscountTextBox.Text = AverageDiscountDecimal.ToString("C");
                } // end inner try
                catch (FormatException PriceException)
                {
                    // Handle a price exception.
                    MessageBox.Show("Price must be numeric.", "Data Entry Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PriceTextBox.Focus();
                    PriceTextBox.SelectAll();
                } // end inner catch
            } // end outer try
            catch (FormatException QuantityException)
            {
                // Handle a quantity exception.
                MessageBox.Show("Quantity must be numeric.", "Data Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                QuantityTextBox.Focus();
                QuantityTextBox.SelectAll();
            }
            catch (Exception TheException)
            {
                // Handle any other exception.
                MessageBox.Show("Error: " + TheException.Message);
            } // end outer catch
              
        } // end calculate button

        private void ClearButton_Click(object sender, EventArgs e)
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the Project.
            this.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Print the form
            
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void ExtendedPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiscountedPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        } 
    }
}
