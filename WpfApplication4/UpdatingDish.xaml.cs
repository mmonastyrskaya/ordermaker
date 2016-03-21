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
    /// Логика взаимодействия для UpdatingDish.xaml
    /// </summary>
    public partial class UpdatingDish : Window
    {
        string bludon;

        Context context = new Context();
        Entities.Bludo bludo = new Entities.Bludo();

        public UpdatingDish(string bludoname)
        {            
            bludon = bludoname;
            InitializeComponent();

            bludo = Requests.MethodsOrder.GetBludoByName(context, bludon);

            name.Text = bludo.BludoName;
            price.Text = (bludo.BludoPrice).ToString();
            foreach (var c in category.Items)
            { 
                if (bludo.BludoCategory == c.ToString())
                category.SelectedItem = c;
            }                
            weight.Text = (bludo.BludoWeight).ToString();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ListOfDishes lod = new ListOfDishes();
            lod.Show();
            this.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
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
            }
            catch (Exception ex) { MessageBox.Show("Проверьте правильность ввода данных."); }
        }
    }
}
