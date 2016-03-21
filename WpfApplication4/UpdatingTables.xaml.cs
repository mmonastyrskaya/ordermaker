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
    /// Логика взаимодействия для UpdatingTables.xaml
    /// </summary>
    public partial class UpdatingTables : Window
    {
        int tablel;

        Context context = new Context();
        Entities.Table table = new Entities.Table();
        public UpdatingTables(int label)
        {
            InitializeComponent();

            tablel = label;
            InitializeComponent();

            table = Requests.MethodsOrder.GetTableByLabel(context, tablel);

            id.Text = (table.TableID).ToString();
            location.Text = (table.TableLocation).ToString();
            places.Text = (table.TablePlaces).ToString();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ListOfTables lot = new ListOfTables();
            lot.Show();
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Context context = new Context();

            Entities.Table table = new Entities.Table();
            table.TableLabel = int.Parse(id.Text);
            table.TableLocation = location.Text;
            table.TablePlaces = int.Parse(places.Text);

            Requests.MethodsAdmininstrator.InsertTable(context, table);

            id.Text = "";
            location.Text = "";
            places.Text = "";
        }
    }
}
