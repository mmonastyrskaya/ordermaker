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

            Entities.Bludo bludo= new Entities.Bludo();
            bludo.BludoName = name.Text;
            bludo.BludoPrice = System.Convert.ToDecimal(double.Parse(price.Text));
            bludo.BludoCategory = (category.SelectedItem).ToString();
            bludo.BludoWeight = double.Parse(weight.Text);

            Requests.MethodsAdmininstrator.InsertBludo(context,bludo);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AdministratorOptions ao = new AdministratorOptions();
            ao.Show();
        }
    }
}
