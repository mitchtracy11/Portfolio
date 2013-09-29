namespace Lesson02_Colors
{
    partial class ColorsForm
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.WhiteRadioButton = new System.Windows.Forms.RadioButton();
            this.BlackRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GrayRadioButton = new System.Windows.Forms.RadioButton();
            this.YellowRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.BeigeRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.WhiteRadioButton);
            this.GroupBox2.Controls.Add(this.BlackRadioButton);
            this.GroupBox2.Location = new System.Drawing.Point(12, 153);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(145, 65);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Select Text Color";
            // 
            // WhiteRadioButton
            // 
            this.WhiteRadioButton.AutoSize = true;
            this.WhiteRadioButton.Location = new System.Drawing.Point(6, 39);
            this.WhiteRadioButton.Name = "WhiteRadioButton";
            this.WhiteRadioButton.Size = new System.Drawing.Size(53, 17);
            this.WhiteRadioButton.TabIndex = 1;
            this.WhiteRadioButton.Text = "&White";
            this.WhiteRadioButton.UseVisualStyleBackColor = true;
            this.WhiteRadioButton.CheckedChanged += new System.EventHandler(this.WhiteRadioButton_CheckedChanged);
            // 
            // BlackRadioButton
            // 
            this.BlackRadioButton.AutoSize = true;
            this.BlackRadioButton.Checked = true;
            this.BlackRadioButton.Location = new System.Drawing.Point(6, 16);
            this.BlackRadioButton.Name = "BlackRadioButton";
            this.BlackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.BlackRadioButton.TabIndex = 0;
            this.BlackRadioButton.TabStop = true;
            this.BlackRadioButton.Text = "Blac&k";
            this.BlackRadioButton.UseVisualStyleBackColor = true;
            this.BlackRadioButton.CheckedChanged += new System.EventHandler(this.BlackRadioButton_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GrayRadioButton);
            this.GroupBox1.Controls.Add(this.YellowRadioButton);
            this.GroupBox1.Controls.Add(this.BlueRadioButton);
            this.GroupBox1.Controls.Add(this.BeigeRadioButton);
            this.GroupBox1.Location = new System.Drawing.Point(12, 35);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(145, 112);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Select  Form Color";
            // 
            // GrayRadioButton
            // 
            this.GrayRadioButton.AutoSize = true;
            this.GrayRadioButton.Location = new System.Drawing.Point(6, 85);
            this.GrayRadioButton.Name = "GrayRadioButton";
            this.GrayRadioButton.Size = new System.Drawing.Size(47, 17);
            this.GrayRadioButton.TabIndex = 3;
            this.GrayRadioButton.Text = "&Gray";
            this.GrayRadioButton.UseVisualStyleBackColor = true;
            this.GrayRadioButton.CheckedChanged += new System.EventHandler(this.GrayRadioButton_CheckedChanged);
            // 
            // YellowRadioButton
            // 
            this.YellowRadioButton.AutoSize = true;
            this.YellowRadioButton.Location = new System.Drawing.Point(6, 62);
            this.YellowRadioButton.Name = "YellowRadioButton";
            this.YellowRadioButton.Size = new System.Drawing.Size(56, 17);
            this.YellowRadioButton.TabIndex = 2;
            this.YellowRadioButton.Text = "&Yellow";
            this.YellowRadioButton.UseVisualStyleBackColor = true;
            this.YellowRadioButton.CheckedChanged += new System.EventHandler(this.YellowRadioButton_CheckedChanged);
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Location = new System.Drawing.Point(6, 39);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.BlueRadioButton.TabIndex = 1;
            this.BlueRadioButton.Text = "B&lue";
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            this.BlueRadioButton.CheckedChanged += new System.EventHandler(this.BlueRadioButton_CheckedChanged);
            // 
            // BeigeRadioButton
            // 
            this.BeigeRadioButton.AutoSize = true;
            this.BeigeRadioButton.Checked = true;
            this.BeigeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.BeigeRadioButton.Name = "BeigeRadioButton";
            this.BeigeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.BeigeRadioButton.TabIndex = 0;
            this.BeigeRadioButton.TabStop = true;
            this.BeigeRadioButton.Text = "&Beige";
            this.BeigeRadioButton.UseVisualStyleBackColor = true;
            this.BeigeRadioButton.CheckedChanged += new System.EventHandler(this.BeigeRadioButton_CheckedChanged);
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 274);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "ColorsForm";
            this.Text = "Change Colors";
            this.Load += new System.EventHandler(this.ColorsForm_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RadioButton WhiteRadioButton;
        internal System.Windows.Forms.RadioButton BlackRadioButton;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton GrayRadioButton;
        internal System.Windows.Forms.RadioButton YellowRadioButton;
        internal System.Windows.Forms.RadioButton BlueRadioButton;
        internal System.Windows.Forms.RadioButton BeigeRadioButton;
    }
}

