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
    public partial class frmThankYou : Form
    {

        public frmThankYou()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }

        private void frmThankYou_Load(object sender, EventArgs e)
        {
            FileStream inFile = new FileStream("result.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            double finalPrice;
            string fName, lName;

            Random rand = new Random((int)DateTime.Now.Ticks);
            int RandomNumber;
            RandomNumber = rand.Next(100000, 999999);

            finalPrice = Convert.ToDouble(reader.ReadLine());
            fName = reader.ReadLine();
            lName = reader.ReadLine();

            lblConfirmation.Text = String.Format("Thank you {0} {1} for the payment of {2},", fName, lName, finalPrice.ToString("C2"));
            lblConfirmation.Text += String.Format("\nyour conformation number is {0}.\nThank you for shopping at Games R Us!", RandomNumber); 
            finalPrice = Convert.ToDouble(reader.ReadLine());

            reader.Close();
            inFile.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
