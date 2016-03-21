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
    /// Логика взаимодействия для AddingDish.xaml
    /// </summary>
    public partial class AddingDish : Window
    {
        public AddingDish()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Context context = new Context();

            try
            {
                Entities.Bludo bludo = new Entities.Bludo();
                bludo.BludoName = name.Text;
                bludo.BludoPrice = System.Convert.ToDecimal(double.Parse(price.Text));
                bludo.BludoCategory = (category.SelectedItem).ToString();
                bludo.BludoWeight = double.Parse(weight.Text);
                bludo.BludoTime = DateTime.Parse("2000-12-12 10:00");

                Requests.MethodsAdmininstrator.InsertBludo(context, bludo);

                name.Text = "";
                price.Text = "";
                category.SelectedItem = null;
                weight.Text = "";
                time.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте правильность ввода данных.");
            }
           

            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {            
            AdministratorOptions ao = new AdministratorOptions();
            ao.Show();
            this.Close();
        }
    }
}
