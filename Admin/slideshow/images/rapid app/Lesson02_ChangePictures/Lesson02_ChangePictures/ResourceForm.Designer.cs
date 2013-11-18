namespace Lesson02_ChangePictures
{
    partial class ResourceForm
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.WaterLiliesRadioButton = new System.Windows.Forms.RadioButton();
            this.WinterRadioButton = new System.Windows.Forms.RadioButton();
            this.SunsetRadioButton = new System.Windows.Forms.RadioButton();
            this.SamplePictureBox = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.WaterLiliesRadioButton);
            this.GroupBox1.Controls.Add(this.WinterRadioButton);
            this.GroupBox1.Controls.Add(this.SunsetRadioButton);
            this.GroupBox1.Location = new System.Drawing.Point(35, 211);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(322, 48);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Select Picture to Display";
            // 
            // WaterLiliesRadioButton
            // 
            this.WaterLiliesRadioButton.AutoSize = true;
            this.WaterLiliesRadioButton.Location = new System.Drawing.Point(109, 19);
            this.WaterLiliesRadioButton.Name = "WaterLiliesRadioButton";
            this.WaterLiliesRadioButton.Size = new System.Drawing.Size(80, 17);
            this.WaterLiliesRadioButton.TabIndex = 2;
            this.WaterLiliesRadioButton.TabStop = true;
            this.WaterLiliesRadioButton.Text = "Water &Lilies";
            this.WaterLiliesRadioButton.UseVisualStyleBackColor = true;
            this.WaterLiliesRadioButton.CheckedChanged += new System.EventHandler(this.WaterLiliesRadioButton_CheckedChanged);
            // 
            // WinterRadioButton
            // 
            this.WinterRadioButton.AutoSize = true;
            this.WinterRadioButton.Location = new System.Drawing.Point(205, 19);
            this.WinterRadioButton.Name = "WinterRadioButton";
            this.WinterRadioButton.Size = new System.Drawing.Size(90, 17);
            this.WinterRadioButton.TabIndex = 3;
            this.WinterRadioButton.TabStop = true;
            this.WinterRadioButton.Text = "&Winter Scene";
            this.WinterRadioButton.UseVisualStyleBackColor = true;
            this.WinterRadioButton.CheckedChanged += new System.EventHandler(this.WinterRadioButton_CheckedChanged);
            // 
            // SunsetRadioButton
            // 
            this.SunsetRadioButton.AutoSize = true;
            this.SunsetRadioButton.Location = new System.Drawing.Point(13, 19);
            this.SunsetRadioButton.Name = "SunsetRadioButton";
            this.SunsetRadioButton.Size = new System.Drawing.Size(58, 17);
            this.SunsetRadioButton.TabIndex = 1;
            this.SunsetRadioButton.TabStop = true;
            this.SunsetRadioButton.Text = "&Sunset";
            this.SunsetRadioButton.UseVisualStyleBackColor = true;
            this.SunsetRadioButton.CheckedChanged += new System.EventHandler(this.SunsetRadioButton_CheckedChanged);
            // 
            // SamplePictureBox
            // 
            this.SamplePictureBox.Location = new System.Drawing.Point(61, 19);
            this.SamplePictureBox.Name = "SamplePictureBox";
            this.SamplePictureBox.Size = new System.Drawing.Size(256, 171);
            this.SamplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SamplePictureBox.TabIndex = 5;
            this.SamplePictureBox.TabStop = false;
            // 
            // ResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 278);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.SamplePictureBox);
            this.Name = "ResourceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Pictures";
            this.Load += new System.EventHandler(this.ResourceForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton WaterLiliesRadioButton;
        internal System.Windows.Forms.RadioButton WinterRadioButton;
        internal System.Windows.Forms.RadioButton SunsetRadioButton;
        internal System.Windows.Forms.PictureBox SamplePictureBox;
    }
}

