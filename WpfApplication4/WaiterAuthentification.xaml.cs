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
    /// Логика взаимодействия для WaiterAuthentification.xaml
    /// </summary>
    public partial class WaiterAuthentification : Window
    {
        public WaiterAuthentification()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool check = Requests.MethodsAdmin.Check(new Context(), Login.Text, Password.Text);
            if (check == true)
            {

            }
            else { MessageBox.Show("Логин или пароль введены неверно."); }
        }
    }
}
