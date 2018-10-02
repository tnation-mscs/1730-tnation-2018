using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tnation2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal AmountCanada = Convert.ToDecimal(txtAmountCanada.Text);
            decimal RateCanada = Convert.ToDecimal(txtRateCanada.Text);
            decimal USDCanada = AmountCanada * RateCanada;
            txtUSDCanada.Text = USDCanada.ToString("0.00");

            decimal AmountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal RateEuro = Convert.ToDecimal(txtRateEuro.Text);
            decimal USDEuro = AmountEuro * RateEuro;
            txtUSDEuro.Text = USDEuro.ToString("0.00");

            decimal AmountSouthKorea = Convert.ToDecimal(txtAmountSouthKorea.Text);
            decimal RateSouthKorea = Convert.ToDecimal(txtRateSouthKorea.Text);
            decimal USDSouthKorea = AmountSouthKorea * RateSouthKorea;
            txtUSDSouthKorea.Text = USDSouthKorea.ToString("0.00");

            decimal AmountUAE = Convert.ToDecimal(txtAmountUAE.Text);
            decimal RateUAE = Convert.ToDecimal(txtRateUAE.Text);
            decimal USDUAE = AmountUAE * RateUAE;
            txtUSDUAE.Text = USDUAE.ToString("0.00");


            decimal totalUSD = USDCanada + USDEuro + USDSouthKorea + USDUAE;
            txtTotalUSD.Text = totalUSD.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
                txtAmountCanada.Text = "0.00";
                txtRateCanada.Text = "0.759098";

                txtAmountEuro.Text = "0.00";
                txtRateEuro.Text = "1.15515";

                txtAmountSouthKorea.Text = "0.00";
                txtRateSouthKorea.Text = "0.000886259";

                txtAmountUAE.Text = "0.00";
                txtRateUAE.Text = "0.272294";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
