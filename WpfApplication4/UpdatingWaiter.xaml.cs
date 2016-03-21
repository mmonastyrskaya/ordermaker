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
    /// Логика взаимодействия для UpdatingWaiter.xaml
    /// </summary>
    public partial class UpdatingWaiter : Window
    {
        Context context = new Context();
        string wsurname;
        string wname;
        Entities.Waiter w = new Entities.Waiter();
        public UpdatingWaiter(string input)
        {
            InitializeComponent();
            wname =(input.Split(' '))[0];
            wsurname = (input.Split(' '))[1];

            w = (from r in context.Waiters
                where (r.WaiterName==wname) &&(r.WaiterSurname==wsurname) 
                select r).First();

            name.Text = w.WaiterName;
            surname.Text = w.WaiterSurname;
            login.Text = w.WaiterLogin;
            pass.Text = w.WaiterPassword;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
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
            ListOfWaiters low = new ListOfWaiters();
            low.Show();
            this.Show();
        }
    }
}
