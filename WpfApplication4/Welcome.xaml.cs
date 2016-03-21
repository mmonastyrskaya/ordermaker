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
        Context context = new Context();
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
                Entities.Table t = Requests.MethodsOrder.GetTableByLabel(context, int.Parse(LabelTable.Text));               
                YourOrder yo = new YourOrder(t.TableID);
                yo.Show();
                this.Close();
            }
            else { MessageBox.Show("Стола с таким номером не существует."); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Context context = new Context();
            try
            {
                bool check = Requests.MethodsOrder.CheckLabel(context, int.Parse(LabelTable.Text));
                if (check == true)
                {
                    try
                    {
                        Entities.Table t = Requests.MethodsOrder.GetTableByLabel(context, int.Parse(LabelTable.Text));
                        YourOrder yo = new YourOrder(t.TableID);
                        yo.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Проверьте правильность ввода номера.");
                    }

                }
                else { MessageBox.Show("Стола с таким номером не существует."); }
            }
            catch (Exception ex) { MessageBox.Show("Введите данные."); }

           
        }
    }
}
