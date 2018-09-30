using System;
using System.Windows.Forms;

namespace tnation1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int hotDogs = Convert.ToInt32(txtHotDogs.Text);
            decimal hotDogPrice = 4.0m;
            decimal hotDogSubtotal = hotDogs * hotDogPrice;
            txtHotDogsSubtotal.Text = hotDogSubtotal.ToString("0.00");

            int hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal hamburgerPrice = 5.0m;
            decimal hamburgerSubtotal = hamburgers * hamburgerPrice;
            txtHamburgersSubtotal.Text = hamburgerSubtotal.ToString("0.00");

            decimal pretaxTotal = hotDogSubtotal + hamburgerSubtotal;
            txtPretaxTotal.Text = pretaxTotal.ToString("0.00");

            decimal tax = 6.875m * pretaxTotal / 100;
            txtTaxTotal.Text = tax.ToString("0.00");

            decimal total = pretaxTotal + tax;
            txtTotal.Text = total.ToString("0.00");

            btnClear.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTaxTotal.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }

    }
}