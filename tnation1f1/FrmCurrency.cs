using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tnation1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnKorea.BackgroundImage = picKoreaDim.Image;
            btnUAE.BackgroundImage = picUAEDim.Image;
            lblCurrency.Text = btnCanada.Text + ": ";
            txtRate.Text = "0.759098";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnKorea.BackgroundImage = picKoreaDim.Image;
            btnUAE.BackgroundImage = picUAEDim.Image;
            lblCurrency.Text = btnCanada.Text + ": ";
            txtRate.Text = "0.759098";
            txtUSDollars.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnEU_Click(object sender, EventArgs e)
        {
            btnEU.BackgroundImage = picEU.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnKorea.BackgroundImage = picKoreaDim.Image;
            btnUAE.BackgroundImage = picUAEDim.Image;
            lblCurrency.Text = btnEU.Text + ": ";
            txtRate.Text = "1.15515";
            txtUSDollars.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnKorea_Click(object sender, EventArgs e)
        {
            btnKorea.BackgroundImage = picKorea.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnUAE.BackgroundImage = picUAEDim.Image;
            lblCurrency.Text = btnKorea.Text + ": ";
            txtRate.Text = "0.000886259";
            txtUSDollars.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnUAE_Click(object sender, EventArgs e)
        {
            btnUAE.BackgroundImage = picUAE.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnKorea.BackgroundImage = picKoreaDim.Image;
            lblCurrency.Text = btnUAE.Text + ": ";
            txtRate.Text = "0.272294";
            txtUSDollars.Text = "0.00";
            txtCurrency.Focus();
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDollars.Text)
                + Convert.ToDecimal(txtTotalUSD.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
                Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnKorea.BackgroundImage = picKoreaDim.Image;
            btnUAE.BackgroundImage = picUAEDim.Image;
            lblCurrency.Text = btnCanada.Text + ": ";
            txtRate.Text = "0.759098";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Text = "0.00";
            lblEquation.Text = "";
            txtCurrency.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
