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
    /// Логика взаимодействия для ListOfTables.xaml
    /// </summary>
    public partial class ListOfTables : Window
    {
        Context context = new Context();

        public ListOfTables()
        {
            InitializeComponent();
            List<Entities.Table> tables = Requests.MethodsAdmininstrator.GetAllTabless(context);
            foreach (Entities.Table table in tables)
            {
                tabels.Items.Add(table.TableLabel);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tabels.SelectedItem == null) { MessageBox.Show("Выберете стол."); }
            else
            {
                UpdatingTables ut = new UpdatingTables(int.Parse((tabels.SelectedItem).ToString()));
                ut.Show();
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddingTable at = new AddingTable();
            at.Show();
            this.Close();
        }
    }
}
