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

namespace Task_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void InitButton_Click(object sender, RoutedEventArgs e)
        {

            await Task.Run(() =>
             {
                 using (TestDB_Task_2Context db = new TestDB_Task_2Context())
                 {

                     List<Products> products = db.Products.ToList();


                     Dispatcher.Invoke(() =>
                     {
                         DataProd.ItemsSource = products;

                     });
                     



                 }


             });


        }

        private void CltarButton_Click(object sender, RoutedEventArgs e)
        {
            DataProd.ItemsSource = null;
        }
    }
}
