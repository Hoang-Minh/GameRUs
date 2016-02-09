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
    public partial class frmCreateAccount : Form
    {
        const int LENGTH_OF_PASSWORD = 4;
        Customer Buyer = new Customer();
        int count = 0;
        const string CUSTOMERLOGIN = "CreateAccount.txt";
        const string RECORDS = "Records.txt";

        //Set the windows @ max size @ the beginning
        public frmCreateAccount()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        //Load the customers info when the program runs
        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            Buyer.LoadInfo(RECORDS);
            //Buyer.LoadInfo(CUSTOMERLOGIN);
        }



        //Write to CreateAccount and Records files
        public void WriteInfo()
        {
            //Buyer.WriteToAFile(CUSTOMERLOGIN);
            Buyer.GetName = txtUsername.Text;
            Buyer.GetPass = txtPassword.Text;
            Buyer.WriteToAFile(RECORDS);
        }

        //Check if both username and password are valid
        public bool ReadNamePassword(string a, string b)
        {
            bool valid;

            if (IsEmpty(a) && IsEmpty(b))
            {
                MessageBox.Show("Both userame and password are empty. Try again",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else if (IsEmpty(a))
            {
                MessageBox.Show("Username is empty. Try again",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else if (IsEmpty(b))
            {
                MessageBox.Show("Password is empty. Try again",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else
                valid = true;

            return valid;
        }

        //Check if the string is empty
        public bool IsEmpty(string a)
        {
            bool valid;
            if (a == "")
                valid = true;
            else
                valid = false;
            return valid;
        }

        // Create account
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            bool valid = false;
            string a = txtUsername.Text;
            string b = txtPassword.Text;


            valid = ReadNamePassword(a, b);


            if (valid)
            {
                if (count == 0 || (!IsDuplicate(a) && IsLong(b)))
                {
                    WriteInfo();
                    // Go to next form
                    frmSelectGames secondForm = new frmSelectGames();
                    secondForm.GetLoginUserName = txtUsername.Text;
                    secondForm.Show();
                    this.Hide();
                }
            }
        }

        //Check if the username is duplicate or not.
        public bool IsDuplicate(string a)
        {
            bool valid = false;

            for (int i = 0; i < count; i++)
            {
                if (a == Buyer.GetCustomerName()[i])
                {
                    MessageBox.Show("Username duplicated. Choose another one",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = true;
                }
            }
            return valid;
        }

        //Check if username orr password is long enough
        public bool IsLong(string b)
        {
            bool valid = false;
            if (b.Length < LENGTH_OF_PASSWORD)
            {
                MessageBox.Show("Password must be at least 4 characters",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                valid = false;
            }
            else
                valid = true;
            return valid;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool found = false, valid;

            string a = txtUsername.Text;
            string b = txtPassword.Text;

            valid = ReadNamePassword(a, b);

            if (valid)
            {
                if (IsLong(b))
                {
                    for (int i = 0; i < Buyer.GetNumberOfCustomers(); i++)
                    {
                        if (a == Buyer.GetCustomerName()[i] && b == Buyer.GetCustomerPassword()[i])
                            found = true;
                    }

                    if (found)
                    {
                        // Go to next form
                        frmSelectGames secondForm = new frmSelectGames();
                        secondForm.GetLoginUserName = txtUsername.Text;
                        secondForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username/password. Try again",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
