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

namespace JIRA
{
    /// <summary>
    /// Interaction logic for MainToolsWindow.xaml
    /// </summary>
    public partial class MainToolsWindow : Window
    {
        public MainToolsWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void CustomMenu_Loaded(object sender, RoutedEventArgs e)
        {
       
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomMenu.Show();
        }

        private void MenuButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CustomMenu.Hide();
        }
    }
}
