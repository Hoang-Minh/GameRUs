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
    public partial class frmSelectGames : Form
    {
        private const string XBOX360 = "XBox360.txt";
        private const string PS3 = "PS3.txt";
        private const string WII = "Wii.txt";
        const string RENTAL_HISTORY = "Rental History.txt";
        GamesConsole Xbox360 = new GamesConsole();
        GamesConsole Ps3 = new GamesConsole();
        GamesConsole Wii = new GamesConsole();
        GamesConsole Invoice = new GamesConsole();
        GamesConsole Results = new GamesConsole();
        string userName;

        //const string GAMES = "Games.txt";

        const double TAX_RATE = 0.08;

        public frmSelectGames()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        //Get the value of username back from form 1
        public string GetLoginUserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public void GetSubTotal(double price, ref double sub)
        {
            sub += price;
        }

        // Proceed to checkout
        private void btnCart_Click(object sender, EventArgs e)
        {
            double subTotal = 0, price = 0;
            string id = "";
            string xboxType = "Xbox360";
            string ps3Type = "PS3";
            string wiiType = "Wii";

            if (cbCODX.Checked)
            {
                Xbox360.GetGameRecord(lblCODX.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblCODX.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(xboxType);
            }

            if (cbHalo.Checked)
            {
                Xbox360.GetGameRecord(lblHalo.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblHalo.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(xboxType);
            }

            if (cbNBA.Checked)
            {
                Xbox360.GetGameRecord(lblNBA.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblNBA.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(xboxType);
            }

            if (cbFIFA.Checked)
            {
                Xbox360.GetGameRecord(lblFIFA.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblFIFA.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(xboxType);
            }

            if (cbGTA.Checked)
            {
                Xbox360.GetGameRecord(lblGTA.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblGTA.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(xboxType);
            }

            if (cbGodOfWar.Checked)
            {
                Ps3.GetGameRecord(lblGodOfWar.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblGodOfWar.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(ps3Type);
            }

            if (cbResidentEvil.Checked)
            {
                Ps3.GetGameRecord(lblResidentEvil.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblResidentEvil.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(ps3Type);
            }

            if (cbAssassinsCreed.Checked)
            {
                Ps3.GetGameRecord(lblAssassinsCreed.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblAssassinsCreed.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(ps3Type);
            }

            if (cbCODP.Checked)
            {
                Ps3.GetGameRecord(lblCODP.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblCODP.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(ps3Type);
            }

            if (cbMaxPayne.Checked)
            {
                Ps3.GetGameRecord(lblMaxPayne.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblMaxPayne.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(ps3Type);
            }

            if (cbSuperMario.Checked)
            {
                Wii.GetGameRecord(lblSuperMario.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblSuperMario.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(wiiType);
            }

            if (cbZelda.Checked)
            {
                Wii.GetGameRecord(lblZelda.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblZelda.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(wiiType);
            }

            if (cbMadagascar.Checked)
            {
                Wii.GetGameRecord(lblMadagascar.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblMadagascar.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(wiiType);
            }

            if (cbSpiderman.Checked)
            {
                Wii.GetGameRecord(lblSpiderman.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblSpiderman.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(wiiType);
            }

            if (cbJustDance.Checked)
            {
                Wii.GetGameRecord(lblJustDance.Text, ref price, ref id, ref subTotal);
                Invoice.SetTitle(lblJustDance.Text);
                Invoice.SetId(id);
                Invoice.SetPrice(price);
                Invoice.SetConsole(wiiType);
            }

            frmYourCart thirdForm = new frmYourCart();
            thirdForm.GetInvoice = Invoice;
            thirdForm.GetSubTotal = subTotal;
            thirdForm.GetUserName = userName;
            thirdForm.GetCount = Invoice.GetTitle().Count;

            //Send to review order form
            frmReviewOrder fifthForm = new frmReviewOrder();
            fifthForm.GetTotalCost = subTotal;
            fifthForm.GetUserName = userName;

            thirdForm.Show();
            this.Hide();
        }

        //Load the program from the beginning
        private void frmSelectGames_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello, " + userName;
            Xbox360.LoadGame(XBOX360);
            Ps3.LoadGame(PS3);
            Wii.LoadGame(WII);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int indexResult = 0;
            string consoleType = "", title, id;
            double price;
            string a = txtSearch.Text;

            if (!chbXbox360.Checked && !chbPs3.Checked && !chbWii.Checked)
                MessageBox.Show("Please select your console", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (chbXbox360.Checked)
                {
                    if (Xbox360.HaveGame(a, ref indexResult))
                    {
                        consoleType = "Xbox360";
                        title = Xbox360.GetTitle()[indexResult];
                        Results.SetTitle(title);
                        id = Xbox360.GetId()[indexResult];
                        Results.SetId(id);
                        price = Xbox360.GetPrice()[indexResult];
                        Results.SetPrice(price);
                    }
                }

                if (chbPs3.Checked)
                {
                    if (Ps3.HaveGame(a, ref indexResult))
                    {
                        consoleType = "PS3";
                        title = Ps3.GetTitle()[indexResult];
                        Results.SetTitle(title);
                        id = Ps3.GetId()[indexResult];
                        Results.SetId(id);
                        price = Ps3.GetPrice()[indexResult];
                        Results.SetPrice(price);
                    }
                }

                if (chbWii.Checked)
                {
                    if (Wii.HaveGame(a, ref indexResult))
                    {
                        consoleType = "Wii";
                        title = Wii.GetTitle()[indexResult];
                        Results.SetTitle(title);
                        id = Wii.GetId()[indexResult];
                        Results.SetId(id);
                        price = Wii.GetPrice()[indexResult];
                        Results.SetPrice(price);
                    }
                }

                if (Results.GetTitle().Count > 0)
                {
                    //page 215
                    for (int i = 0; i < Results.GetTitle().Count; i++)
                    {
                        lblConsole.Visible = true;
                        lblTitle.Visible = true;
                        lblPrice.Visible = true;
                        Label resultLabel = new Label();
                        resultLabel.AutoSize = true;
                        resultLabel.Location = new Point(233, 350);
                        resultLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                        resultLabel.Text = String.Format("{0} {1, 50} {2, 50}", consoleType, Results.GetTitle()[i], Results.GetPrice()[i]);
                        this.tabConsole.TabPages[3].Controls.Add(resultLabel);
                    }
                }
                else
                    MessageBox.Show("Found no game", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
