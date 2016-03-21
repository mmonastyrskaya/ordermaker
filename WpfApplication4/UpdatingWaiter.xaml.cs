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
    /// Логика взаимодействия для AddingWaiter.xaml
    /// </summary>
    public partial class AddingWaiter : Window
    {
        public AddingWaiter()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Context context = new Context();

            Entities.Waiter w = new Entities.Waiter();
            w.WaiterName = name.Text;
            w.WaiterSurname = surname.Text;
            w.WaiterLogin = login.Text;
            w.WaiterPassword = pass.Text;

            Requests.MethodsAdmininstrator.InsertWaiter(context, w);

            name.Text = "";
            surname.Text = "";
            login.Text = "";
            pass.Text = "";

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            AdministratorOptions ao = new AdministratorOptions();
            ao.Show();
            this.Close();
        }
    }
}
