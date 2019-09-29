using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SQLite;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for NewCustomer.xaml
    /// </summary>
    public partial class NewCustomer : Window
    {
        public NewCustomer()
        {
            InitializeComponent();
        }
        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Address_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void City_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void State_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Zip_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string address = AddressTextBox.Text;
            string city = CityTextBox.Text;
            string state = StateTextBox.Text;
            string zip = ZipTextBox.Text;
            string email = EmailTextBox.Text;
            string phone = PhoneTextBox.Text;



            //Customer o_customer = new Customer(name, address, city, state, zip, phone, email);
            //o_customer.AddCustomer();





            /*
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=C:\\sqlite3\\testCustomer.db;Version=3;");
            m_dbConnection.Open();
            //string sql_temp = $"{name}, {address}, {city}, {state}, {zip}, {email}, {phone}";
            string sql = $"insert into CustomerInfo (name, address, city, state, zip, phone, email) values ('{name}', '{address}', '{city}', '{state}', '{zip}', '{email}', '{phone}')";
            MessageBox.Show(sql);
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            */
            this.Close();
        }
    }
}
