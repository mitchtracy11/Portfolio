namespace Lesson01HandsOn
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.BooksButton = new System.Windows.Forms.Button();
            this.MusicButton = new System.Windows.Forms.Button();
            this.PeriodicalsButton = new System.Windows.Forms.Button();
            this.CoffeeBarButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PromotionLabel = new System.Windows.Forms.Label();
            this.PromotionCodeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // BooksButton
            // 
            this.BooksButton.Location = new System.Drawing.Point(12, 46);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(75, 23);
            this.BooksButton.TabIndex = 0;
            this.BooksButton.Text = "Books";
            this.BooksButton.UseVisualStyleBackColor = true;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // MusicButton
            // 
            this.MusicButton.Location = new System.Drawing.Point(12, 76);
            this.MusicButton.Name = "MusicButton";
            this.MusicButton.Size = new System.Drawing.Size(75, 23);
            this.MusicButton.TabIndex = 1;
            this.MusicButton.Text = "Music";
            this.MusicButton.UseVisualStyleBackColor = true;
            this.MusicButton.Click += new System.EventHandler(this.MusicButton_Click);
            // 
            // PeriodicalsButton
            // 
            this.PeriodicalsButton.Location = new System.Drawing.Point(12, 106);
            this.PeriodicalsButton.Name = "PeriodicalsButton";
            this.PeriodicalsButton.Size = new System.Drawing.Size(75, 23);
            this.PeriodicalsButton.TabIndex = 2;
            this.PeriodicalsButton.Text = "Periodicals";
            this.PeriodicalsButton.UseVisualStyleBackColor = true;
            this.PeriodicalsButton.Click += new System.EventHandler(this.PeriodicalsButton_Click);
            // 
            // CoffeeBarButton
            // 
            this.CoffeeBarButton.Location = new System.Drawing.Point(12, 136);
            this.CoffeeBarButton.Name = "CoffeeBarButton";
            this.CoffeeBarButton.Size = new System.Drawing.Size(75, 23);
            this.CoffeeBarButton.TabIndex = 3;
            this.CoffeeBarButton.Text = "Coffee Bar";
            this.CoffeeBarButton.UseVisualStyleBackColor = true;
            this.CoffeeBarButton.Click += new System.EventHandler(this.CoffeeBarButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(12, 166);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 4;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 196);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Promotion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Promotion Code";
            // 
            // PromotionLabel
            // 
            this.PromotionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PromotionLabel.Location = new System.Drawing.Point(218, 76);
            this.PromotionLabel.Name = "PromotionLabel";
            this.PromotionLabel.Size = new System.Drawing.Size(253, 23);
            this.PromotionLabel.TabIndex = 8;
            this.PromotionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PromotionCodeLabel
            // 
            this.PromotionCodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PromotionCodeLabel.Location = new System.Drawing.Point(218, 106);
            this.PromotionCodeLabel.Name = "PromotionCodeLabel";
            this.PromotionCodeLabel.Size = new System.Drawing.Size(100, 23);
            this.PromotionCodeLabel.TabIndex = 9;
            this.PromotionCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Programmed by Tom Tsiliopoulos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 231);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PromotionCodeLabel);
            this.Controls.Add(this.PromotionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CoffeeBarButton);
            this.Controls.Add(this.PeriodicalsButton);
            this.Controls.Add(this.MusicButton);
            this.Controls.Add(this.BooksButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R -- for Reading and Refreshment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PromotionCodeLabel;
        private System.Windows.Forms.Label PromotionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button CoffeeBarButton;
        private System.Windows.Forms.Button PeriodicalsButton;
        private System.Windows.Forms.Button MusicButton;
        private System.Windows.Forms.Button BooksButton;
    }
}

