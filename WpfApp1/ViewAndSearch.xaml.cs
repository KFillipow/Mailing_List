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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ViewAndSearch.xaml
    /// </summary>
    public partial class ViewAndSearch : Window
    {
        public ViewAndSearch()
        {
            InitializeComponent();
            List<Customer> AllCustomers = new List<Customer>();
            AllCustomers = Customer.ViewAllCustomers();
            customerData.ItemsSource = AllCustomers;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
           // StreamReader 
        }

        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            // ... Get the TextBox that was edited.
            var element = e.EditingElement as TextBox;
            var text = element.Text;
            var filter = e.Column.Header; //gets the filter

            DataGridColumn col1 = e.Column;
            DataGridRow row1 = e.Row;
            int row_index = ((DataGrid)sender).ItemContainerGenerator.IndexFromContainer(row1);
            int col_index = col1.DisplayIndex;


            // ... See if the text edit should be canceled.
            //     We cancel if the user typed a question mark.
            if (text == "?")
            {
                // ... Cancel the edit.
                this.Title = "Invalid";
                e.Cancel = true;
            }
            else
            {
                // ... Show the cell value in the title.
                this.Title = "You typed: " + text;
            }

            //
        }
    }
}
