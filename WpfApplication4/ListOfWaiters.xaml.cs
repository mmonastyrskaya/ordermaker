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
    /// Логика взаимодействия для ListOfWaiters.xaml
    /// </summary>
    public partial class ListOfWaiters : Window
    {
        Context context = new Context();
              

        public ListOfWaiters()
        {
            InitializeComponent();

            List<Entities.Waiter> waiters = Requests.MethodsAdmininstrator.GetAllWaiters(context);
            foreach (Entities.Waiter waiter in waiters)
            {
                waitersl.Items.Add(waiter.WaiterName+" "+waiter.WaiterSurname);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdatingWaiter uw = new UpdatingWaiter((waitersl.SelectedItem).ToString());
            uw.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddingWaiter aw = new AddingWaiter();
            aw.Show();
            this.Close();
        }
    }
}
