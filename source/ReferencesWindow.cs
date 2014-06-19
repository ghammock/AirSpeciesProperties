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
    public partial class ReferencesWindow : Form
    {
        public ReferencesWindow()
        {
            InitializeComponent();
            UnderlineBooks();
            ItalicizeArticles();
        }

        private void UnderlineBooks()
        {
            Font standardStyle = ReferencesTextBox.Font;
            Font bookStyle = new Font(standardStyle.FontFamily.Name,
                                      standardStyle.Size,
                                      FontStyle.Underline);

            ReferencesTextBox.Find("NIST-JANAF Thermochemical Tables");
            ReferencesTextBox.SelectionFont = bookStyle;

            ReferencesTextBox.Find("Hypersonic and High-Temperature Gas Dynamics");
            ReferencesTextBox.SelectionFont = bookStyle;

            ReferencesTextBox.Find("Transport Phenomena");
            ReferencesTextBox.SelectionFont = bookStyle;

            ReferencesTextBox.Select(ReferencesTextBox.TextLength, 0);
        }

        private void ItalicizeArticles()
        {
            Font standardStyle = ReferencesTextBox.Font;
            Font artStyle = new Font(standardStyle.FontFamily.Name,
                                      standardStyle.Size,
                                      FontStyle.Italic);

            ReferencesTextBox.Find("Journal of Physical and Chemical Reference Data");
            ReferencesTextBox.SelectionFont = artStyle;

            ReferencesTextBox.Select(ReferencesTextBox.TextLength, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
