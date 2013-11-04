namespace Lesson3_BookSale
{
    partial class BookSaleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSaleForm));
            this.PrintButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.DiscountedPriceTextBox = new System.Windows.Forms.TextBox();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.ExtendedPriceTextBox = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(22, 264);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(93, 25);
            this.PrintButton.TabIndex = 13;
            this.PrintButton.Text = "Print &Form";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(307, 264);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(71, 25);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(207, 264);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 25);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear &Sale";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(121, 264);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(80, 25);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.DiscountedPriceTextBox);
            this.GroupBox2.Controls.Add(this.DiscountTextBox);
            this.GroupBox2.Controls.Add(this.ExtendedPriceTextBox);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Location = new System.Drawing.Point(22, 147);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(355, 104);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            // 
            // DiscountedPriceTextBox
            // 
            this.DiscountedPriceTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DiscountedPriceTextBox.Location = new System.Drawing.Point(257, 71);
            this.DiscountedPriceTextBox.Name = "DiscountedPriceTextBox";
            this.DiscountedPriceTextBox.ReadOnly = true;
            this.DiscountedPriceTextBox.Size = new System.Drawing.Size(86, 20);
            this.DiscountedPriceTextBox.TabIndex = 5;
            this.DiscountedPriceTextBox.TabStop = false;
            this.DiscountedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DiscountTextBox.Location = new System.Drawing.Point(257, 45);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.ReadOnly = true;
            this.DiscountTextBox.Size = new System.Drawing.Size(86, 20);
            this.DiscountTextBox.TabIndex = 3;
            this.DiscountTextBox.TabStop = false;
            this.DiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ExtendedPriceTextBox
            // 
            this.ExtendedPriceTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ExtendedPriceTextBox.Location = new System.Drawing.Point(257, 19);
            this.ExtendedPriceTextBox.Name = "ExtendedPriceTextBox";
            this.ExtendedPriceTextBox.ReadOnly = true;
            this.ExtendedPriceTextBox.Size = new System.Drawing.Size(86, 20);
            this.ExtendedPriceTextBox.TabIndex = 1;
            this.ExtendedPriceTextBox.TabStop = false;
            this.ExtendedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ExtendedPriceTextBox.TextChanged += new System.EventHandler(this.ExtendedPriceTextBox_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(155, 75);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 13);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Discounted Price";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(155, 47);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 13);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "15% Discount";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(155, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 13);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Extended Price";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.QuantityTextBox);
            this.GroupBox1.Controls.Add(this.TitleTextBox);
            this.GroupBox1.Controls.Add(this.PriceTextBox);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(22, 43);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(355, 98);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(16, 21);
            this.Label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(46, 13);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "&Quantity";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(90, 17);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(67, 20);
            this.QuantityTextBox.TabIndex = 1;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(90, 42);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(253, 20);
            this.TitleTextBox.TabIndex = 3;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(90, 67);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(67, 20);
            this.PriceTextBox.TabIndex = 5;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 70);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(31, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "&Price";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(27, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "&Title";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(145, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 20);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Book Sales";
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // BookSaleForm
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(400, 304);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Name = "BookSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R for Reading \'n Refreshment";
            this.Load += new System.EventHandler(this.BookSaleForm_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button PrintButton;
        internal System.Windows.Forms.Button ExitButton;
        internal System.Windows.Forms.Button clearButton;
        internal System.Windows.Forms.Button CalculateButton;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox DiscountedPriceTextBox;
        internal System.Windows.Forms.TextBox DiscountTextBox;
        internal System.Windows.Forms.TextBox ExtendedPriceTextBox;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox QuantityTextBox;
        internal System.Windows.Forms.TextBox TitleTextBox;
        internal System.Windows.Forms.TextBox PriceTextBox;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

