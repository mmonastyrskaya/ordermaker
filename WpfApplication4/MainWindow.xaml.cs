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
            Context cont = new Context();
            Entities.Table table = new Entities.Table();
            Entities.Bludo bludo = new Entities.Bludo();


            table.TableID = 11;
            table.TableLabel = 100;
            table.TableLocation = "test";
            table.TablePlaces = 4;


            bludo.BludoID=1;
            bludo.BludoCategory = "Soup";
            bludo.BludoName = "Gaspacho";
            bludo.BludoPrice = 10.0m;
            bludo.BludoWeight = 300.0;
            bludo.BludoTime = DateTime.Parse("1900-01-01 00:00:00");

            //bool check = Requests.MethodsAuth.Check(new Context(),"ivanov", "1234");
            Requests.MethodsAdmin.InsertTable(cont, table);
            Requests.MethodsAdmin.InsertBludo(cont, bludo);

            //cont.SubmitChanges();
            cont.SaveChanges();
        }
    }
}
