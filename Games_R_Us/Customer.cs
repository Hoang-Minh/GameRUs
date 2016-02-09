using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Games_R_Us
{
    class Customer
    {

        private string username;
        private string password;
        private List<string> custName = new List<string>();
        private List<string> custPassword = new List<string>();
        int numOfCustomer = 0;

        //Get username from form1
        public string GetName
        {
            get { return username; }
            set { username = value; }
        }

        //Get pass from form1
        public string GetPass
        {
            get { return password; }
            set { password = value; }
        }

        //Get Number Of Customers
        public int GetNumberOfCustomers()
        {
            return numOfCustomer;
        }

        // Add to list
        public void AddToList(List<string> list, string val)
        {
            list.Add(val);
        }

        // Read login record file and load it when the program runs
        public void LoadInfo(string console)
        {
            FileStream inFile = new FileStream(console, FileMode.Open, FileAccess.Read); ;
            StreamReader reader = new StreamReader(inFile); ;

            // Only read file if the file is not empy and quit when reach the end of file
            while (console.Length != 0 && (reader.Peek() >= 0))
            {
                AddToList(custName, reader.ReadLine());
                AddToList(custPassword, reader.ReadLine());
                numOfCustomer++;
            }
            reader.Close();
            inFile.Close();
        }

        public void WriteToAFile(string fileWrite)
        {
            FileStream outFile;
            StreamWriter writer;

            if (File.Exists(fileWrite))
                outFile = new FileStream(fileWrite, FileMode.Append, FileAccess.Write);
            else
                outFile = new FileStream(fileWrite, FileMode.CreateNew, FileAccess.Write);

            writer = new StreamWriter(outFile);
            writer.WriteLine(username);
            writer.WriteLine(password);

            writer.Close();
            outFile.Close();
        }

        public List<string> GetCustomerName()
        {
            return custName;
        }

        public List<string> GetCustomerPassword()
        {
            return custPassword;
        }
    }


}
