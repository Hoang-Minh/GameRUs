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
    public partial class frmReviewOrder : Form
    {
         private double sub;
        private string userName;
        const string FILENAME = "CustomersShippingAndPaymentInfo.txt";

        public frmReviewOrder ()
        {
            InitializeComponent();            
        }

        public string GetUserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public double GetTotalCost
        {
            get { return sub; }
            set { sub = value; }
        }


        private void btnPurchase_Click(object sender, EventArgs e)
        {
            frmThankYou sixthForm = new frmThankYou();
            sixthForm.Show();
            this.Hide();
        }

        private void frmReviewOrder_Load(object sender, EventArgs e)
        {
            FileStream inFile5 = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader5 = new StreamReader(inFile5);
           
            string fName, mName, lName, address, city, state;
            int zip;

            double cardNumber;
            string cardName;

            string month;
            string year;

            lblReviewOrder.Text = String.Format("~CUSTOMER INFORMATION~\n");
            fName = reader5.ReadLine();
            while (fName != null)
            {
                mName = reader5.ReadLine();
                lName = reader5.ReadLine();
                address = reader5.ReadLine();
                city = reader5.ReadLine();
                state = reader5.ReadLine();
                zip = Convert.ToInt32(reader5.ReadLine());

                cardNumber = Convert.ToDouble(reader5.ReadLine());
                cardName = reader5.ReadLine();
                month = reader5.ReadLine();
                year = reader5.ReadLine();

                lblReviewOrder.Text += String.Format("\nFirst Name:          {0}\nM.I:                       {1}\nLast Name:          {2}\nAddress:              {3}\nCity:                     {4}\nState:                   {5}\nZip:                      {6}", fName, mName, lName, address, city, state, zip);
                lblReviewOrder.Text += String.Format("\nCard Number:      {0}\nCard Name:         {1}\nMonth:                 {2}\nYear:                   {3}", cardNumber.ToString("################"), cardName, month, year);
                fName = reader5.ReadLine();
            }
            reader5.Close();
            inFile5.Close();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCheckout fourthForm = new frmCheckout();
            fourthForm.Show();
            this.Hide();
        }
    }
}
