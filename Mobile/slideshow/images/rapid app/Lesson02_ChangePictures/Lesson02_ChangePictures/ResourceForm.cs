// Project:           Change Pictures
// Programmer:        Tom Tsiliopoulos
// Date:              September 2013
// Description:       Allow the user to change the displayed graphic image by
//                    selecting a radio button. Demonstrates changing a picture
//                    at run time.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson02_ChangePictures
{
    public partial class ResourceForm : Form
    {
        public ResourceForm()
        {
            InitializeComponent();
        }

        private void ResourceForm_Load(object sender, EventArgs e)
        {

        }

        private void SunsetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        // Display the Sunset picture from the project's resources.

        SamplePictureBox.Image = Properties.Resources.Sunset;
        }

        private void WaterLiliesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Display the Water Lily picture from the project's resources.

            SamplePictureBox.Image = Properties.Resources.Water_lilies;
        }

        private void WinterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Display the Winter picture from the project's resources.

            SamplePictureBox.Image = Properties.Resources.Winter;
        }
    }
}
