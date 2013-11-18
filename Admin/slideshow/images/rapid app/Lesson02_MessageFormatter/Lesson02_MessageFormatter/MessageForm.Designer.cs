namespace Lesson02_MessageFormatter
{
    partial class MessageForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.BigPictureBox = new System.Windows.Forms.PictureBox();
            this.LittlePictureBox = new System.Windows.Forms.PictureBox();
            this.VisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.BlackRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LittlePictureBox)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(307, 325);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(73, 29);
            this.ExitButton.TabIndex = 24;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearButton.Location = new System.Drawing.Point(307, 290);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(73, 29);
            this.ClearButton.TabIndex = 23;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(307, 253);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(73, 29);
            this.DisplayButton.TabIndex = 22;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageLabel.Location = new System.Drawing.Point(192, 163);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(188, 70);
            this.MessageLabel.TabIndex = 21;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(66, 350);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 13);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "Click Picture";
            // 
            // BigPictureBox
            // 
            this.BigPictureBox.Image = global::Lesson02_MessageFormatter.Properties.Resources.MCj04326300000_1_;
            this.BigPictureBox.ImageLocation = "";
            this.BigPictureBox.Location = new System.Drawing.Point(45, 253);
            this.BigPictureBox.Name = "BigPictureBox";
            this.BigPictureBox.Padding = new System.Windows.Forms.Padding(3);
            this.BigPictureBox.Size = new System.Drawing.Size(104, 91);
            this.BigPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigPictureBox.TabIndex = 26;
            this.BigPictureBox.TabStop = false;
            this.BigPictureBox.Click += new System.EventHandler(this.BigPictureBox_Click);
            // 
            // LittlePictureBox
            // 
            this.LittlePictureBox.Image = global::Lesson02_MessageFormatter.Properties.Resources.MCj04326300000_1_;
            this.LittlePictureBox.Location = new System.Drawing.Point(56, 264);
            this.LittlePictureBox.Name = "LittlePictureBox";
            this.LittlePictureBox.Size = new System.Drawing.Size(65, 55);
            this.LittlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LittlePictureBox.TabIndex = 25;
            this.LittlePictureBox.TabStop = false;
            this.LittlePictureBox.Click += new System.EventHandler(this.LittlePictureBox_Click);
            // 
            // VisibleCheckBox
            // 
            this.VisibleCheckBox.AutoSize = true;
            this.VisibleCheckBox.Checked = true;
            this.VisibleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VisibleCheckBox.Location = new System.Drawing.Point(192, 127);
            this.VisibleCheckBox.Name = "VisibleCheckBox";
            this.VisibleCheckBox.Size = new System.Drawing.Size(102, 17);
            this.VisibleCheckBox.TabIndex = 20;
            this.VisibleCheckBox.Text = "Message &Visible";
            this.VisibleCheckBox.CheckedChanged += new System.EventHandler(this.VisibleCheckBox_CheckedChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.BlackRadioButton);
            this.GroupBox2.Controls.Add(this.BlueRadioButton);
            this.GroupBox2.Controls.Add(this.GreenRadioButton);
            this.GroupBox2.Controls.Add(this.RedRadioButton);
            this.GroupBox2.Location = new System.Drawing.Point(27, 107);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(141, 126);
            this.GroupBox2.TabIndex = 19;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Color";
            // 
            // BlackRadioButton
            // 
            this.BlackRadioButton.AutoSize = true;
            this.BlackRadioButton.Checked = true;
            this.BlackRadioButton.Location = new System.Drawing.Point(29, 94);
            this.BlackRadioButton.Name = "BlackRadioButton";
            this.BlackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.BlackRadioButton.TabIndex = 3;
            this.BlackRadioButton.TabStop = true;
            this.BlackRadioButton.Text = "B&lack";
            this.BlackRadioButton.CheckedChanged += new System.EventHandler(this.BlackRadioButton_CheckedChanged);
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Location = new System.Drawing.Point(29, 69);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.BlueRadioButton.TabIndex = 2;
            this.BlueRadioButton.Text = "&Blue";
            this.BlueRadioButton.CheckedChanged += new System.EventHandler(this.BlueRadioButton_CheckedChanged);
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.AutoSize = true;
            this.GreenRadioButton.Location = new System.Drawing.Point(29, 44);
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GreenRadioButton.TabIndex = 1;
            this.GreenRadioButton.Text = "&Green";
            this.GreenRadioButton.CheckedChanged += new System.EventHandler(this.GreenRadioButton_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(29, 19);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(45, 17);
            this.RedRadioButton.TabIndex = 0;
            this.RedRadioButton.Text = "&Red";
            this.RedRadioButton.CheckedChanged += new System.EventHandler(this.RedRadioButton_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.MessageTextBox);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.NameTextBox);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(27, 14);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(353, 87);
            this.GroupBox1.TabIndex = 18;
            this.GroupBox1.TabStop = false;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(83, 52);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(209, 20);
            this.MessageTextBox.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "&Message:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(83, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(209, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(26, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Name:";
            // 
            // MessageForm
            // 
            this.AcceptButton = this.DisplayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ClearButton;
            this.ClientSize = new System.Drawing.Size(406, 376);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BigPictureBox);
            this.Controls.Add(this.LittlePictureBox);
            this.Controls.Add(this.VisibleCheckBox);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Formatter";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LittlePictureBox)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ExitButton;
        internal System.Windows.Forms.Button ClearButton;
        internal System.Windows.Forms.Button DisplayButton;
        internal System.Windows.Forms.Label MessageLabel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox BigPictureBox;
        internal System.Windows.Forms.PictureBox LittlePictureBox;
        internal System.Windows.Forms.CheckBox VisibleCheckBox;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RadioButton BlackRadioButton;
        internal System.Windows.Forms.RadioButton BlueRadioButton;
        internal System.Windows.Forms.RadioButton GreenRadioButton;
        internal System.Windows.Forms.RadioButton RedRadioButton;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox MessageTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox NameTextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

