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
    /// Логика взаимодействия для Thanks.xaml
    /// </summary>
    public partial class Thanks : Window
    {
        int tabelid;
        Context context = new Context();        

        public Thanks(int id)
        {
            tabelid = id;
            InitializeComponent();
            double sum = Requests.MethodsOrder.GetSumByTableID(context, tabelid);
            Sum.Items.Add(sum);
        }
    }
}
