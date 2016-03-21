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

namespace WpfApplication4
{
    /// <summary>
    /// Логика взаимодействия для AdministratorOptions.xaml
    /// </summary>
    public partial class AdministratorOptions : Window
    {
        public AdministratorOptions()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddingDish ad = new AddingDish();
            ad.Show();
            this.Close();
        }

        private void table_Click(object sender, RoutedEventArgs e)
        {
            AddingTable at = new AddingTable();
            at.Show();
            this.Close();
        }

        private void waiter_Click(object sender, RoutedEventArgs e)
        {
            AddingWaiter aw = new AddingWaiter();
            aw.Show();
            this.Close();
        }

        private void dish_Click(object sender, RoutedEventArgs e)
        {
            ListOfDishes lod = new ListOfDishes();
            lod.Show();
            this.Close();
        }

        private void tablechange_Click(object sender, RoutedEventArgs e)
        {
            ListOfTables lot = new ListOfTables();
            lot.Show();
            this.Close();
        }

        private void waiterchange_Click(object sender, RoutedEventArgs e)
        {
            ListOfWaiters low = new ListOfWaiters();
            low.Show();
            this.Close();
        }
    }
}
