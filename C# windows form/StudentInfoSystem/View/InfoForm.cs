using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentInfoSystem
{
    public partial class InfoForm : Form
    {
        
        public InfoForm()
        {
            InitializeComponent();
            
        }
        public InfoForm(string text)
        {
            InitializeComponent();
            richTextBoxText.Text = text;
            MessageBox.Show(text);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if
                (richTextBoxText.SelectedText == "")
                {
                    richTextBoxText.Font = dialog.Font;
                }
                else
                {
                    richTextBoxText.SelectionFont = dialog.Font;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if
                (richTextBoxText.SelectedText == "")
                {
                    richTextBoxText.ForeColor = dialog.Color;
                }
                else
                {
                    richTextBoxText.SelectionColor = dialog.Color;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "*.rtf";
            saveFileDialog.Filter = "RTF Files|*.rtf";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK
            && (saveFileDialog.FileName.Length > 0))
            {
                try
                {
                    // Save the contents of the RichTextBox into the file.
                    richTextBoxText.SaveFile(saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Файлът не беше съхранен, поради грешка в записа!",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
