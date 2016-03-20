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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Linq;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Context cont = new Context();

            //OrderService s = new OrderService();
            //List<Entities.BludoInOrder> bludosio = s.GetAllBludosInOrder();

            //MainWindow mw1 = new MainWindow();
            //mw1.Show();

            //MainWindow mw2 = new MainWindow();
            //mw2.Show();

            //Entities.Table table = new Entities.Table();
            //Entities.Bludo bludo = new Entities.Bludo();
            //Entities.Waiter waiter = new Entities.Waiter();


            //table.TableID = 11;
            //table.TableLabel = 100;
            //table.TableLocation = "Update";
            //table.TablePlaces = 4;


            //bludo.BludoID=44;
            //bludo.BludoCategory = "Soup";
            //bludo.BludoName = "Update";
            //bludo.BludoPrice = 10.0m;
            //bludo.BludoWeight = 300.0;
            //bludo.BludoTime = DateTime.Parse("1900-01-01 00:00:00");

            //waiter.WaiterID = 1;
            //waiter.WaiterName = "Update";
            //waiter.WaiterSurname = "Surname";
            //waiter.WaiterLogin = "login";
            //waiter.WaiterPassword = "pass";


            ////bool check = Requests.MethodsAdmin.Check(new Context(),"ivanov", "1234");
            ////Requests.MethodsAdmin.UpdateTable(cont, table);
            ////Requests.MethodsAdmin.UpdateBludo(cont, bludo);
            ////Requests.MethodsAdmin.UpdateWaiter(cont, waiter);

            //Requests.MethodsAdmin.DeleteTable(cont, table);
            //Requests.MethodsAdmin.DeleteBludo(cont, bludo);
            //Requests.MethodsAdmin.DeleteWaiter(cont, waiter);
                        
            //cont.SaveChanges();

            //foreach (Entities.BludoInOrder bio in bludosio)
            //{
            //    foreach (var b in cont.Bludos.Where(b => b.BludoID == bio.BludoID))
            //    {
            //        var bID = b.BludoID;

            //        foreach (var o in cont.OrdersInTime.Where(o => o.OrderID == bio.OrderID))
            //        {
            //            var oID = o.OrderID;

            //            cont.BludosInOrder.Add(new Entities.BludoInOrder { BludoID = bID, BludoAmount = bio.BludoAmount, BludoStatus = bio.BludoStatus, OrderID = oID, OrderTime = DateTime.Parse((bio.OrderTime).ToString()) }
            //        );
            //        }
            //    }
            //}
            //List<Entities.Bludo> bludos = Requests.MethodsOrder.GetBludosTableID(cont, 10);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WaiterAuthentification wa = new WaiterAuthentification();
            wa.Show();
            this.Close();
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            Welcome w = new Welcome();
            w.Show();
            this.Close();
        }
    }
}
