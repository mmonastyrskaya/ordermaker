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
    /// Логика взаимодействия для Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Call_Click(object sender, RoutedEventArgs e)
        {            
            Context context = new Context();
            bool check = Requests.MethodsOrder.CheckLabel(context,int.Parse(LabelTable.Text));            
            
            if (check == true)
            {
                YourOrder yo = new YourOrder();
                yo.Show();
                this.Close();
            }
            else { MessageBox.Show("Стола с таким номером не существует."); }
        }
    }
}
