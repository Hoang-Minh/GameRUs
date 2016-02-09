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
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //declare variables for shipping adress
            string firstName, middleName, lastName, stAdress, city, state, zipCode;

            //declare variables for billing information
            string creditCardType, monthExpDate, yearExpDate, creditCardNumber, securityCode;
            const string blank = "";
            bool itemMissing = false;
            const int CREDITCARDLENGTH= 16;


            firstName = txtFirstName.Text;
            middleName = txtMiddleName.Text;
            lastName = txtLastName.Text;
            stAdress = txtAddress.Text;
            city = txtCity.Text;
            state = txtState.Text;
            zipCode = txtZipCode.Text;

            creditCardNumber = txtCreditCardNumber.Text;
            creditCardType = cbCardType.Text;
            securityCode = txtSecurityCode.Text;
            monthExpDate = cbMonth.Text;
            yearExpDate = cbYear.Text;

            if (firstName == blank)
            {
                MessageBox.Show("Please enter your first name");
                itemMissing = false;
                txtFirstName.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtFirstName.BackColor = Color.White;
            }
            
            if (middleName == blank)
            {
                MessageBox.Show("Please enter your middle initial");
                itemMissing = false;
                txtMiddleName.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtMiddleName.BackColor = Color.White;
            }
            if (lastName == blank)
            {
                MessageBox.Show("Please enter your last name");
                itemMissing = false;
                txtLastName.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtLastName.BackColor = Color.White;
            }
            if (stAdress == blank)
            {
                MessageBox.Show("Please enter your Street adress");
                itemMissing = false;
                txtAddress.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtAddress.BackColor = Color.White;
            }
            if (city == blank)
            {
                MessageBox.Show("Please enter your city");
                itemMissing = false;
                txtCity.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtCity.BackColor = Color.White;
            }
            if (state == blank)
            {
                MessageBox.Show("Please enter your state");
                itemMissing = false;
                txtState.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtState.BackColor = Color.White;
            }
            if (zipCode == blank)
            {
                MessageBox.Show("Please enter your zip code");
                itemMissing = false;
                txtZipCode.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtZipCode.BackColor = Color.White;
            }
            if (cbCardType.SelectedIndex == -1)
            {
                MessageBox.Show("Your credit card type is blank. Please select a valid credit card");
                itemMissing = false;
                cbCardType.BackColor = Color.PaleVioletRed;
            }
            else
            {
                cbCardType.BackColor = Color.White;
            }
            if (creditCardNumber.Length < CREDITCARDLENGTH)
            {
                MessageBox.Show("Your credit card number must be 16 digits. Please enter a valid credit card number");
                itemMissing = false;
                txtCreditCardNumber.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtCreditCardNumber.BackColor = Color.White;
            }
            if (cbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Your credit card month is blank. Please select a month");
                itemMissing = false;
                cbMonth.BackColor = Color.PaleVioletRed;
            }
            else
            {
                cbMonth.BackColor = Color.White;
            }
            if (cbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Your credit card year is blank. Please select a year");
                itemMissing = false;
                cbYear.BackColor = Color.PaleVioletRed;
            }
            else
            {
                cbYear.BackColor = Color.White;
            }
            if (securityCode == blank)
            {
                MessageBox.Show("Your credit card security code is blank. Please enter your credit cards security code");
                itemMissing = false;
                txtSecurityCode.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtSecurityCode.BackColor = Color.White;
            }
            while (itemMissing)
                {
                    MessageBox.Show("One or more fields are missing.");
                }
               
            if (firstName != blank && middleName != blank && lastName != blank && stAdress != blank && city != blank && state != blank && zipCode != blank && creditCardNumber != blank && creditCardType != blank && securityCode != blank && monthExpDate != blank && yearExpDate != blank)
                {
                    itemMissing = true;
                    if (itemMissing)
                    {

                        FileStream outfile4 = new FileStream("CustomersShippingAndPaymentInfo.txt", FileMode.Create, FileAccess.Write);
                        StreamWriter writer4 = new StreamWriter(outfile4);
                        FileStream outFile = new FileStream("result.txt", FileMode.Append, FileAccess.Write);
                        StreamWriter writer = new StreamWriter(outFile);

                        writer4.WriteLine(firstName);
                        writer4.WriteLine(middleName);
                        writer4.WriteLine(lastName);
                        writer4.WriteLine(stAdress);
                        writer4.WriteLine(city);
                        writer4.WriteLine(state);
                        writer4.WriteLine(Convert.ToString(zipCode));

                        writer4.WriteLine(Convert.ToString(creditCardNumber));
                        writer4.WriteLine(creditCardType);
                        writer4.WriteLine(monthExpDate);
                        writer4.WriteLine(Convert.ToString(yearExpDate));

                        writer.WriteLine(firstName);
                        writer.WriteLine(lastName);

                        writer4.Close();
                        outfile4.Close();
                        writer.Close();
                        outFile.Close();

                        frmReviewOrder fifthForm = new frmReviewOrder();
                        fifthForm.Show();
                        this.Hide();
                    }
                }
            }
        }
    }


