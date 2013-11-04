namespace Lesson02_HandsOn
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
            this.ImageVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.WelcomeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PromotionTextBox = new System.Windows.Forms.TextBox();
            this.CheckInGroupBox = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.MemberIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentPictureBox = new System.Windows.Forms.PictureBox();
            this.DepartmentGroupBox = new System.Windows.Forms.GroupBox();
            this.CoffeeBarRadioButton = new System.Windows.Forms.RadioButton();
            this.PeriodicalsRadioButton = new System.Windows.Forms.RadioButton();
            this.MusicRadioButton = new System.Windows.Forms.RadioButton();
            this.BooksRadioButton = new System.Windows.Forms.RadioButton();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.CheckInGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentPictureBox)).BeginInit();
            this.DepartmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageVisibleCheckBox
            // 
            this.ImageVisibleCheckBox.AutoSize = true;
            this.ImageVisibleCheckBox.Location = new System.Drawing.Point(198, 195);
            this.ImageVisibleCheckBox.Name = "ImageVisibleCheckBox";
            this.ImageVisibleCheckBox.Size = new System.Drawing.Size(88, 17);
            this.ImageVisibleCheckBox.TabIndex = 14;
            this.ImageVisibleCheckBox.Text = "Image &Visible";
            this.ImageVisibleCheckBox.UseVisualStyleBackColor = true;
            this.ImageVisibleCheckBox.Visible = false;
            this.ImageVisibleCheckBox.CheckedChanged += new System.EventHandler(this.ImageVisibleCheckBox_CheckedChanged);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(397, 189);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 10;
            this.PrintButton.Text = "&Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(397, 218);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(397, 160);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 23);
            this.SignInButton.TabIndex = 9;
            this.SignInButton.Text = "&Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // WelcomeRichTextBox
            // 
            this.WelcomeRichTextBox.Location = new System.Drawing.Point(245, 98);
            this.WelcomeRichTextBox.Name = "WelcomeRichTextBox";
            this.WelcomeRichTextBox.Size = new System.Drawing.Size(227, 46);
            this.WelcomeRichTextBox.TabIndex = 16;
            this.WelcomeRichTextBox.Text = "";
            this.WelcomeRichTextBox.Visible = false;
            // 
            // PromotionTextBox
            // 
            this.PromotionTextBox.Location = new System.Drawing.Point(12, 230);
            this.PromotionTextBox.Name = "PromotionTextBox";
            this.PromotionTextBox.Size = new System.Drawing.Size(274, 20);
            this.PromotionTextBox.TabIndex = 15;
            this.PromotionTextBox.Visible = false;
            // 
            // CheckInGroupBox
            // 
            this.CheckInGroupBox.Controls.Add(this.Label2);
            this.CheckInGroupBox.Controls.Add(this.MemberIDMaskedTextBox);
            this.CheckInGroupBox.Controls.Add(this.Label3);
            this.CheckInGroupBox.Controls.Add(this.NameTextBox);
            this.CheckInGroupBox.Location = new System.Drawing.Point(245, 10);
            this.CheckInGroupBox.Name = "CheckInGroupBox";
            this.CheckInGroupBox.Size = new System.Drawing.Size(227, 82);
            this.CheckInGroupBox.TabIndex = 8;
            this.CheckInGroupBox.TabStop = false;
            this.CheckInGroupBox.Text = "Elite Member Check In";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "&Name";
            // 
            // MemberIDMaskedTextBox
            // 
            this.MemberIDMaskedTextBox.Location = new System.Drawing.Point(74, 46);
            this.MemberIDMaskedTextBox.Mask = "00000";
            this.MemberIDMaskedTextBox.Name = "MemberIDMaskedTextBox";
            this.MemberIDMaskedTextBox.Size = new System.Drawing.Size(36, 20);
            this.MemberIDMaskedTextBox.TabIndex = 3;
            this.MemberIDMaskedTextBox.ValidatingType = typeof(int);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 49);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Member &ID";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(74, 20);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(144, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // DepartmentPictureBox
            // 
            this.DepartmentPictureBox.Location = new System.Drawing.Point(12, 131);
            this.DepartmentPictureBox.Name = "DepartmentPictureBox";
            this.DepartmentPictureBox.Size = new System.Drawing.Size(152, 93);
            this.DepartmentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DepartmentPictureBox.TabIndex = 12;
            this.DepartmentPictureBox.TabStop = false;
            this.DepartmentPictureBox.Visible = false;
            // 
            // DepartmentGroupBox
            // 
            this.DepartmentGroupBox.Controls.Add(this.CoffeeBarRadioButton);
            this.DepartmentGroupBox.Controls.Add(this.PeriodicalsRadioButton);
            this.DepartmentGroupBox.Controls.Add(this.MusicRadioButton);
            this.DepartmentGroupBox.Controls.Add(this.BooksRadioButton);
            this.DepartmentGroupBox.Enabled = false;
            this.DepartmentGroupBox.Location = new System.Drawing.Point(12, 10);
            this.DepartmentGroupBox.Name = "DepartmentGroupBox";
            this.DepartmentGroupBox.Size = new System.Drawing.Size(200, 115);
            this.DepartmentGroupBox.TabIndex = 13;
            this.DepartmentGroupBox.TabStop = false;
            this.DepartmentGroupBox.Text = "Department";
            // 
            // CoffeeBarRadioButton
            // 
            this.CoffeeBarRadioButton.AutoSize = true;
            this.CoffeeBarRadioButton.Location = new System.Drawing.Point(6, 88);
            this.CoffeeBarRadioButton.Name = "CoffeeBarRadioButton";
            this.CoffeeBarRadioButton.Size = new System.Drawing.Size(75, 17);
            this.CoffeeBarRadioButton.TabIndex = 3;
            this.CoffeeBarRadioButton.TabStop = true;
            this.CoffeeBarRadioButton.Text = "&Coffee Bar";
            this.CoffeeBarRadioButton.UseVisualStyleBackColor = true;
            this.CoffeeBarRadioButton.CheckedChanged += new System.EventHandler(this.CoffeeBarRadioButton_CheckedChanged);
            // 
            // PeriodicalsRadioButton
            // 
            this.PeriodicalsRadioButton.AutoSize = true;
            this.PeriodicalsRadioButton.Location = new System.Drawing.Point(6, 65);
            this.PeriodicalsRadioButton.Name = "PeriodicalsRadioButton";
            this.PeriodicalsRadioButton.Size = new System.Drawing.Size(76, 17);
            this.PeriodicalsRadioButton.TabIndex = 2;
            this.PeriodicalsRadioButton.TabStop = true;
            this.PeriodicalsRadioButton.Text = "Perio&dicals";
            this.PeriodicalsRadioButton.UseVisualStyleBackColor = true;
            this.PeriodicalsRadioButton.CheckedChanged += new System.EventHandler(this.PeriodicalsRadioButton_CheckedChanged);
            // 
            // MusicRadioButton
            // 
            this.MusicRadioButton.AutoSize = true;
            this.MusicRadioButton.Location = new System.Drawing.Point(6, 42);
            this.MusicRadioButton.Name = "MusicRadioButton";
            this.MusicRadioButton.Size = new System.Drawing.Size(53, 17);
            this.MusicRadioButton.TabIndex = 1;
            this.MusicRadioButton.TabStop = true;
            this.MusicRadioButton.Text = "&Music";
            this.MusicRadioButton.UseVisualStyleBackColor = true;
            this.MusicRadioButton.CheckedChanged += new System.EventHandler(this.MusicRadioButton_CheckedChanged);
            // 
            // BooksRadioButton
            // 
            this.BooksRadioButton.AutoSize = true;
            this.BooksRadioButton.Location = new System.Drawing.Point(6, 19);
            this.BooksRadioButton.Name = "BooksRadioButton";
            this.BooksRadioButton.Size = new System.Drawing.Size(55, 17);
            this.BooksRadioButton.TabIndex = 0;
            this.BooksRadioButton.TabStop = true;
            this.BooksRadioButton.Text = "&Books";
            this.BooksRadioButton.UseVisualStyleBackColor = true;
            this.BooksRadioButton.CheckedChanged += new System.EventHandler(this.BooksRadioButton_CheckedChanged);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // MainForm
            // 
            this.AcceptButton = this.SignInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(485, 260);
            this.Controls.Add(this.ImageVisibleCheckBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.WelcomeRichTextBox);
            this.Controls.Add(this.PromotionTextBox);
            this.Controls.Add(this.CheckInGroupBox);
            this.Controls.Add(this.DepartmentPictureBox);
            this.Controls.Add(this.DepartmentGroupBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R--For Reading and Refreshment";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CheckInGroupBox.ResumeLayout(false);
            this.CheckInGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentPictureBox)).EndInit();
            this.DepartmentGroupBox.ResumeLayout(false);
            this.DepartmentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox ImageVisibleCheckBox;
        internal System.Windows.Forms.Button PrintButton;
        internal System.Windows.Forms.Button ExitButton;
        internal System.Windows.Forms.Button SignInButton;
        internal System.Windows.Forms.RichTextBox WelcomeRichTextBox;
        internal System.Windows.Forms.TextBox PromotionTextBox;
        internal System.Windows.Forms.GroupBox CheckInGroupBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.MaskedTextBox MemberIDMaskedTextBox;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox NameTextBox;
        internal System.Windows.Forms.PictureBox DepartmentPictureBox;
        internal System.Windows.Forms.GroupBox DepartmentGroupBox;
        internal System.Windows.Forms.RadioButton CoffeeBarRadioButton;
        internal System.Windows.Forms.RadioButton PeriodicalsRadioButton;
        internal System.Windows.Forms.RadioButton MusicRadioButton;
        internal System.Windows.Forms.RadioButton BooksRadioButton;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

