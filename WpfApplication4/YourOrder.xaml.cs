﻿using System;
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
    /// Логика взаимодействия для YourOrder.xaml
    /// </summary>
    public partial class YourOrder : Window
    {
        int tabelid;
        Context context = new Context();
        public YourOrder(int id)
        {
            tabelid = id;
            InitializeComponent();
            this.IsEnabled = false;

            //List<Entities.Bludo> bluda = Requests.MethodsOrder.GetBludosTableID(context, tabelid);
            //foreach (Entities.Bludo item in bluda)
            //{
            //    OrderList.Items.Add(item); 
            //}
                
        }

        private void Count_Copy_Click(object sender, RoutedEventArgs e)
        {
            List<Entities.Bludo> bluda = Requests.MethodsOrder.GetBludosTableID(context, tabelid);
            foreach (Entities.Bludo item in bluda)
            {
                OrderList.Items.Add(item.BludoName);
            }
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            Thanks th = new Thanks(tabelid);
            th.Show();
            App.Current.Windows[0].Close();
            this.Close();
        }

        public void EnableButton()
        {
            Count_Copy.IsEnabled = true;
        }
    }
}
