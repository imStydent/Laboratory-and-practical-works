﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace Task3.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            // Manager.MainFrame.Navigate(new RegistrationPage());
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AuthorizationPage());
        }
    }
}