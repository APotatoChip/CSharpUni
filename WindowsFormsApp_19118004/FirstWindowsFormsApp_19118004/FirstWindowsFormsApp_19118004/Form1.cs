using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApp_19118004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChangecolor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                switch (listBox.SelectedIndex)
                {
                    case 0:this.BackColor = colorDialog1.Color; break;
                    case 1:btnChangecolor.BackColor = colorDialog1.Color;break;
                    case 2:btnChangecolor.ForeColor = colorDialog1.Color;break;
                }
            }
        }
    }
}
