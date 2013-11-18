// Project:           RichTextBoxes
// Programmer:        Tom Tsiliopoulos
// Date:              September 2013
// Description:       Demonstrate some of the capabilities of a Rich Text Box.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson02_RichTextBoxes
{
    public partial class RichTextBoxForm : Form
    {
        public RichTextBoxForm()
        {
            InitializeComponent();
        }

        private void RichTextBoxForm_Load(object sender, EventArgs e)
        {
        TitleRichTextBox.Text = "        Pamper Yourself" + Environment.NewLine
          + "    All Your Favorite Books";
        SampleRichTextBox.LoadFile("Rich Text Boxes.rtf");
        }
    }
}
