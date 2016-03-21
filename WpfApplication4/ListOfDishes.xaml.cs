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
    /// Логика взаимодействия для ListOfDishes.xaml
    /// </summary>
    public partial class ListOfDishes : Window
    {
        Context context = new Context();
        public ListOfDishes()
        {
            InitializeComponent();

            List<Entities.Bludo> bludos = Requests.MethodsAdmininstrator.GetAllBludos(context);
            foreach (Entities.Bludo bludo in bludos)
            {
                dishes.Items.Add(bludo.BludoName);
            }
        }

        private void dishes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdatingDish ud = new UpdatingDish((dishes.SelectedItem).ToString());
            ud.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddingDish ad = new AddingDish();
            ad.Show();
            this.Close();
        }
    }
}
