// Programmer: [Your Name goes here]
// Date: [Fill in the current date]
// Description: This program will display "hello world" 
//              message using a label and button controls


using System;
using System.Collections.Generic; //there you go
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void HelloForm_Load(object sender, EventArgs e)
        {

        }

        private void PushButton_Click(object sender, EventArgs e)
        {
            // Display the "Hello World!" Message
            MessageLabel.Text = "Hello World!";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the Program
            this.Close();
        }

        private void SpanishButton_Click(object sender, EventArgs e)
        {
            // Display the "Hello World" message in Spanish
            MessageLabel.Text = "Hola Mundo!";
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Print the form on the printer
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();

        }
    }
}
