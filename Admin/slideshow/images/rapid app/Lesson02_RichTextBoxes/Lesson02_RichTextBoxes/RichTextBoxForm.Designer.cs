namespace Lesson02_RichTextBoxes
{
    partial class RichTextBoxForm
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
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.UrlRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TitleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SampleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(13, 267);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(298, 20);
            this.UrlTextBox.TabIndex = 7;
            this.UrlTextBox.Text = "http://msdn.microsoft.com";
            // 
            // UrlRichTextBox
            // 
            this.UrlRichTextBox.Location = new System.Drawing.Point(13, 225);
            this.UrlRichTextBox.Name = "UrlRichTextBox";
            this.UrlRichTextBox.Size = new System.Drawing.Size(298, 28);
            this.UrlRichTextBox.TabIndex = 6;
            this.UrlRichTextBox.Text = "http://msdn.microsoft.com";
            // 
            // TitleRichTextBox
            // 
            this.TitleRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRichTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.TitleRichTextBox.Location = new System.Drawing.Point(13, 12);
            this.TitleRichTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.TitleRichTextBox.Name = "TitleRichTextBox";
            this.TitleRichTextBox.Size = new System.Drawing.Size(298, 63);
            this.TitleRichTextBox.TabIndex = 5;
            this.TitleRichTextBox.Text = "";
            // 
            // SampleRichTextBox
            // 
            this.SampleRichTextBox.Location = new System.Drawing.Point(13, 81);
            this.SampleRichTextBox.Name = "SampleRichTextBox";
            this.SampleRichTextBox.Size = new System.Drawing.Size(298, 135);
            this.SampleRichTextBox.TabIndex = 4;
            this.SampleRichTextBox.Text = "";
            // 
            // RichTextBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 301);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.UrlRichTextBox);
            this.Controls.Add(this.TitleRichTextBox);
            this.Controls.Add(this.SampleRichTextBox);
            this.Name = "RichTextBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rich Text Boxes";
            this.Load += new System.EventHandler(this.RichTextBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox UrlTextBox;
        internal System.Windows.Forms.RichTextBox UrlRichTextBox;
        internal System.Windows.Forms.RichTextBox TitleRichTextBox;
        internal System.Windows.Forms.RichTextBox SampleRichTextBox;
    }
}

