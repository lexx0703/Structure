using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
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
using System.ComponentModel;
using Structure.Models;
using System.Windows.Markup;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Threading;
using System.Web;
using System.IO;
using System.Data;



namespace Structure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<Product> _ProductData;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _ProductData = new BindingList<Product>()
            {
                new Product(){Name = "Название", Amount = 1, Capacity = 1, Price = 1, Number = 123, Weight = 1}
            };
            Products.ItemsSource = _ProductData;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Products.CancelEdit();
            Products.Items.Refresh();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int i;
            int rowCount = Products.Items.Count;
            StreamWriter swExtLogFile = new StreamWriter("C:\\log.txt", true);
            DataTable dt = new DataTable();
            //Adding data To DataTable
            dt.Columns.Add("Номер");
            dt.Columns.Add("Название");
            dt.Columns.Add("Количество");
            dt.Columns.Add("Вес");
            dt.Columns.Add("Цена");
            dt.Columns.Add("Грузоподъёмность");
            dt.Columns.Add("Допустимое количество");
            dt.Columns.Add("Максимальная цена");

            dt.Rows.Add("Столбцы: Номер", "Название", "Количество", "Вес", "Цена", "Грузоподъёмность", "Допустимое Количество", "Максимальная цена");
            for (i = 0; i < rowCount-1; i++)
            {
                dt.Rows.Add(_ProductData[i].Number.ToString(), _ProductData[i].Name.ToString(), _ProductData[i].Amount.ToString(), _ProductData[i].Weight.ToString(), _ProductData[i].Price.ToString(), _ProductData[i].Capacity.ToString(), _ProductData[i].AmountAllowed.ToString(), _ProductData[i].MaxPrice.ToString());
            }
            //dt.Rows.Add(1, "test");



            swExtLogFile.Write(Environment.NewLine);
            foreach (DataRow row in dt.Rows)
            {
                object[] array = row.ItemArray;
                for (i = 0; i < array.Length - 1; i++)
                {
                    swExtLogFile.Write(array[i].ToString() + " ");
                }
                swExtLogFile.WriteLine(array[i].ToString());
            }
            swExtLogFile.Write("*****END OF DATA****" + DateTime.Now.ToString());
            swExtLogFile.Flush();
            swExtLogFile.Close();
        }
    }
}
