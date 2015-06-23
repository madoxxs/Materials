using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnHello_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 2)
            {
                MessageBox.Show("Здрасти " + txtName.Text + "!!! \nТова е твоята първа програма на Visual Studio 2008!");
            }
            else
            {
                MessageBox.Show("molq vavedete ime s daljina poveche ot 2 simvola");
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int sum = 1; //0!=1
            for (int i = n ; i > 1; i--)
            {
                sum = i * sum;
            }
            MessageBox.Show(n + "!=" + sum);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
