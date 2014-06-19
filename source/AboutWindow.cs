using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirSpeciesProperties
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReferencesButton_Click(object sender, EventArgs e)
        {
            ReferencesWindow rw = new ReferencesWindow();
            rw.Show();
        }
    }
}
