using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace JIRA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SplashScreen splash = new SplashScreen("spacetrooper.png");
            splash.Show(true);
            Thread.Sleep(1500);
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(this.loginCheck())
            {
                MainToolsWindow mainToolsWindow = new MainToolsWindow();
                mainToolsWindow.Show();
                this.Close();
            }
            else
            {
                //TODO: Display Error On Screen
            }
            
            
        }

        private bool loginCheck()
        {
            string username = txtUsername.Text.ToLower();
            string password = txtPassword.Password.ToString();

            if (username == "admin" && password == "password")
            {
                return true;
            }
            else
            {
                return false;
            }  
        }
    }
}
