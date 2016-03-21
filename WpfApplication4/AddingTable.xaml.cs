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
    /// Логика взаимодействия для AddingTable.xaml
    /// </summary>
    public partial class AddingTable : Window
    {
        public AddingTable()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Context context = new Context();

            Entities.Table table = new Entities.Table();
            try
            {
                table.TableLabel = int.Parse(id.Text);
                table.TableLocation = location.Text;
                table.TablePlaces = int.Parse(places.Text);

                Requests.MethodsAdmininstrator.InsertTable(context, table);

                id.Text = "";
                location.Text = "";
                places.Text = "";
            }
            catch (Exception ex){ MessageBox.Show("Проверьте правильность ввода данных."); }
            
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            AdministratorOptions ao = new AdministratorOptions();
            ao.Show();
            this.Close();
        }
    }
}
