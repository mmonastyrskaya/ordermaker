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
    /// Логика взаимодействия для MakingOrder.xaml
    /// </summary>
    public partial class MakingOrder : Window
    {
        
        Context context = new Context();
        int waiterid;

        public MakingOrder(int id)
        {
            

            waiterid = id;
            InitializeComponent();

            Status.Items.Add("заказ передан");
            Status.Items.Add("готовится");
            Status.Items.Add("готово");

            List<Entities.Table> tables = Requests.MethodsAdmininstrator.GetAllTabless(context);
            List<Entities.Bludo> bludos = Requests.MethodsAdmininstrator.GetAllBludos(context);

            foreach (Entities.Table table in tables)
            {
                ChooseT.Items.Add(table.TableLabel);
            }

            foreach (Entities.Bludo bludo in bludos)
            {
                ChooseB.Items.Add(bludo.BludoName);
            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChooseB.SelectedItem = ChooseB.SelectedItem;
        }

        private void AddBIO_Click(object sender, RoutedEventArgs e)
        {
            Entities.OrderInTime order = new Entities.OrderInTime();
            order.WaiterID = waiterid;
            order.TableID = 1;

            order = Requests.MethodsWaiter.InsertOrderInTime(context, order);

            //Context contextnew = new Context();
            
            Entities.BludoInOrder bio = new Entities.BludoInOrder();
            bio.BludoAmount = int.Parse(AmountB.Text);
            bio.BludoStatus = (Status.SelectedItem).ToString();
            bio.OrderID = order.OrderID;

            var bludo = Requests.MethodsOrder.GetBludoByName(context, (ChooseB.SelectedItem).ToString());
            bio.BludoID = bludo.BludoID;
            bio.OrderTime = DateTime.Now;

            Requests.MethodsWaiter.InsertBludoInOrder(context, bio);

            ChooseT.SelectedItem = null;
            Status.SelectedItem = null;
            AmountB.Text = ""; 

        }
    }
}
