using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Games_R_Us
{
    public partial class frmYourCart : Form
    {
        GamesConsole InvoiceRental = new GamesConsole();
        const double SALES_TAX = 0.08;
        private double sub;
        private string userName;
        private int count;

        public frmYourCart()
        {
            InitializeComponent();                        
            cbbShipping.Items.Add("Standard 5 - 10 days");
            cbbShipping.Items.Add("Express 3 - 5 days");
            cbbShipping.Items.Add("Over night 1 day");
        }

        public int GetCount
        {
            get { return count; }
            set { count = value; }
        }

        public GamesConsole GetInvoice
        {
            get { return InvoiceRental; }
            set { InvoiceRental = value; }
        }

        public string GetUserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public double GetSubTotal
        {
            get { return sub; }
            set { sub = value; }
        }

        private double GetTax(double sub)
        {
            return (sub * SALES_TAX);
        }

        private double GetTotal(double sub, double rate)
        {
            double total;
            total = SALES_TAX * sub + sub + rate;
            return total;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout fourthForm = new frmCheckout();
            fourthForm.Show();
            this.Hide();
        }

        private void frmYourCart_Load(object sender, EventArgs e)
        {
            double salesTax;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    lblTitle.Text += String.Format("{0}\n", InvoiceRental.GetTitle()[i]);
                    lblPrice.Text += String.Format("{0}\n", InvoiceRental.GetPrice()[i].ToString("C2"));
                    lblType.Text += String.Format("{0}\n", InvoiceRental.GetConsole()[i]);
                }
                lblSubTotal.Text = String.Format("{0}", sub.ToString("C2"));
                salesTax = GetTax(sub);
                lblTax.Text = salesTax.ToString("C2");                
            }
            else
                MessageBox.Show("Your cart is empty", "Review Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbbShipping_SelectedIndexChanged(object sender, EventArgs e)
        {
            double rate, total;

            if (cbbShipping.SelectedIndex == 0)
            {
                rate = 1.99;
                lblShipRate.Text = rate.ToString("C2");
                total = GetTotal(sub, rate);
                lblTotal.Text = String.Format("{0}", total.ToString("C2"));

            }
            else if (cbbShipping.SelectedIndex == 1)
            {
                rate = 2.99;
                lblShipRate.Text = rate.ToString("C2");
                total = GetTotal(sub, rate);
                lblTotal.Text = String.Format("{0}", total.ToString("C2"));
            }
            else
            {
                rate = 3.99;
                lblShipRate.Text = rate.ToString("C2");
                total = GetTotal(sub, rate);
                lblTotal.Text = String.Format("{0}", total.ToString("C2"));
            }
        }
    }
}

