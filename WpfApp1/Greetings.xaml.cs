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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Add.");
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.Show();
        }
        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ex.");
        }
        private void EditCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("edit.");
        }
        private void ViewCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("view");
            ViewAndSearch searchCustomer = new ViewAndSearch();
            searchCustomer.Show();
        }
       
    }
}
