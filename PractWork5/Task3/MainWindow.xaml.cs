﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserShopingCart cart = new UserShopingCart();
            cart.ValueChanged += new RoutedEventHandler(UserShoppingCart_ButtonClick);
        }

        private void UserShoppingCart_ButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}