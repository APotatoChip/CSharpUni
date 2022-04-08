using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CurrencyConverter
{
    public partial class CurrencyConverterForm : Form
    {
        public CurrencyConverterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_result_Enter(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
         
            int currencyOption = comboBox_currency.SelectedIndex;

                double amount = double.Parse(txt_amount.Text);
              
            switch (currencyOption)
            {
                case 0:
                    txt_BGN.Text = (amount * 1.000).ToString();
                    txt_EUR.Text= (amount * 0.511).ToString();
                    txt_USD.Text= (amount * 0.563).ToString();
                    txt_GBR.Text = (amount * 0.428).ToString();
                    break;
                case 1:
                    txt_BGN.Text = (amount * 1.956).ToString();
                    txt_EUR.Text = (amount * 1.000).ToString();
                    txt_USD.Text = (amount * 1.097).ToString();
                    txt_GBR.Text = (amount * 0.834).ToString();
                    break;
                case 2:
                    txt_BGN.Text = (amount * 1.758).ToString();
                    txt_EUR.Text = (amount * 0.833).ToString();
                    txt_USD.Text = (amount * 1.000).ToString();
                    txt_GBR.Text = (amount * 0.739).ToString();
                    break;
                case 3:
                    txt_BGN.Text = (amount * 2.313).ToString();
                    txt_EUR.Text = (amount * 1.160).ToString();
                    txt_USD.Text = (amount * 1.278).ToString();
                    txt_GBR.Text = (amount * 1.000).ToString();
                    break;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_amount.Text = "";
            txt_BGN.Text = "";
            txt_EUR.Text = "";
            txt_USD.Text = "";
            txt_GBR.Text = "";
            comboBox_currency.SelectedIndex = -1;
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
