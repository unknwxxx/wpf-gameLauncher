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

namespace launcher_master.View.Pages
{
    public partial class SignInPage : Page
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void Setting_OnClick(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow != null)
            {
                ((MainView)Application.Current.MainWindow).MainFrame.Navigate(new Uri("View\\Pages\\SettingsPage.xaml", UriKind.RelativeOrAbsolute));
            }
        }
        private void TypeOfSignIn_OnClick(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow != null)
            {
                ((MainView)Application.Current.MainWindow).MainFrame.Navigate(new Uri("View\\Pages\\LoadingPage.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}
