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
            table.TableID = 11;
            table.TableLabel = 100;
            table.TableLocation = "test";
            table.TablePlaces = 4;
            //bool check = Requests.MethodsAuth.Check(new Context(),"ivanov", "1234");
            Requests.MethodsAuth.Insert(cont, table);
            //cont.SubmitChanges();
            cont.SaveChanges();
        }
    }
}
