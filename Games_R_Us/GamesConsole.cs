using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Games_R_Us
{
    public class GamesConsole
    {

        private List<string> title = new List<string>();
        private List<string> id = new List<string>();
        private List<double> price = new List<double>();
        private List<string> typeConsole = new List<string>();


        public List<string> GetTitle()
        {
            return title;
        }

        public List<string> GetId()
        {
            return id;
        }

        public List<double> GetPrice()
        {
            return price;
        }

        public void SetTitle(string val)
        {
            title.Add(val);
        }

        public void SetId(string val)
        {
            id.Add(val);
        }

        public void SetPrice(double val)
        {
            price.Add(val);
        }

        public List<string> GetConsole()
        {
            return typeConsole;
        }

        public void SetConsole(string val)
        {
            typeConsole.Add(val);
        }

        // Load all the games into seperate array when starts the program
        public void LoadGame(string console)
        {
            // Read txt file and store in arrays
            FileStream inFile = new FileStream(console, FileMode.Open, FileAccess.Read); ;
            StreamReader reader = new StreamReader(inFile); ;
            int count = 0;

            // Only read file if the file is not empy and quit when reach the end of file
            while (console.Length != 0 && (reader.Peek() >= 0))
            {
                SetTitle(reader.ReadLine());
                SetId(reader.ReadLine());
                SetPrice(Convert.ToDouble(reader.ReadLine()));
                count++;
            }
            reader.Close();
            inFile.Close();
        }

        //Get the price of the selected games, and put it into Invoice and RentalHistory list 
        public void GetGameInfo(string a, ref double price, ref string id)
        {
            int position;
            position = GetGameIndex(a);
            price = GetPrice()[position];
            id = GetId()[position];
        }

        // Get the position of the selected game
        public int GetGameIndex(string a)
        {
            int index = -1;
            for (int i = 0; i < GetTitle().Count; i++)
            {
                if (a == GetTitle()[i])
                {
                    index = i;
                }
            }
            return index;
        }

        //Get game record
        public void GetGameRecord(string a, ref double price, ref string id, ref double subTotal)
        {
            GetGameInfo(a, ref price, ref id);
            GetSubTotal(price, ref subTotal);
            PrepareInvoice(a, price, id, ref subTotal);
        }

        //Get total purchases
        public void GetSubTotal(double price, ref double sub)
        {
            sub += price;
        }

        //Record all the purchases and prepare Invoice
        public void PrepareInvoice(string a, double price, string id, ref double subTotal)
        {
            SetTitle(a);
            SetId(id);
            SetPrice(price);
        }

        //Search the game
        public bool HaveGame(string key, ref int index)
        {
            bool valid;
            index = GetGameIndex(key);

            if (index > 0)
            {
                valid = true;
            }
            else
                valid = false;
            return valid;
        }


    }
}
