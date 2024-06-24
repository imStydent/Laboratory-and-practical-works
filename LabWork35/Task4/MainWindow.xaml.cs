﻿using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "Растровые изображения|*.png;*.jpg;*.jpeg;*.bmp",
                InitialDirectory = Environment.CurrentDirectory,
                Multiselect = true,
            };
            if (dialog.ShowDialog() != true)
                return;
            outputListView.ItemsSource = dialog.FileNames;
        }
    }
}