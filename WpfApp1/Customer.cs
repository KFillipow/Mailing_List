using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace WpfApp1
{
    class Customer
    {
        public string Title { get; set;}
        public string Salutation {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Address {get; set;}
        public string Address2 {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public string Zip {get;set;}
        public string Email {get;set;}
        public string HomePhone {get;set;}
        public string AltPhone {get;set;}
        public string WorkPhone {get;set;}
        public string Fax {get;set;}
        public string Company { get; set; }
        public string Web_Site { get; set; }
        public int ID { get; set; }
          
        public Customer(string title,string salutation,string firstname, string lastname, string address, string address2, string city, string state, string zip, string email, string homephone, string altphone, string workphone, string fax, string company, string web_site)
        {
            this.Title = title;
            this.Salutation = salutation;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Email = email;
            this.HomePhone = homephone;
            this.AltPhone = altphone;
            this.WorkPhone = workphone;
            this.Fax = fax;
            this.Company = company;
            this.Web_Site = web_site;
        }
        public Customer(string title, string salutation, string firstname, string lastname, string address, string address2, string city, string state, string zip, string email, string homephone, string altphone, string workphone, string fax, string company, string web_site,int id)
        {
            this.Title = title;
            this.Salutation = salutation;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Email = email;
            this.HomePhone = homephone;
            this.AltPhone = altphone;
            this.WorkPhone = workphone;
            this.Fax = fax;
            this.Company = company;
            this.Web_Site = web_site;
            this.ID = id;
        }
        public void AddCustomer()
        {
            /*
            //Customer o_customer = new Customer(name, address, city, state, zip, phone, email);
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=C:\\sqlite3\\testCustomer.db;Version=3;");
            m_dbConnection.Open();
            //string sql_temp = $"{name}, {address}, {city}, {state}, {zip}, {email}, {phone}";
            string sql = $"insert into CustomerInfo (name, address, city, state, zip, phone, email) values ('{Name}', '{Address}', '{City}', '{State}', '{Zip}', '{Email}', '{Phone}')";
            //MessageBox.Show(sql);
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            */

        }
        public static List<Customer> ViewAllCustomers()
        {
            var reader = new StreamReader(File.OpenRead(@"..\..\modified_customers.csv"));
            int RowIndex = 0;
            List<Customer> AllCustomers = new List<Customer>();
            int tempID = 0;
            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();
                var values = line.Split(',');
                Customer tempCust = new Customer(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10], values[11], values[12], values[13], values[14],values[15],tempID);
                if(tempID > 0)
                    AllCustomers.Add(tempCust);
                tempID++;

            }

            return AllCustomers;
        }
    }
}
