using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace launcher_master
{
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            MainView mainWindow = new MainView();
            mainWindow.Show();

            //mainWindow.IsVisibleChanged += (s, ev) =>
            //{
            //    if (mainWindow.IsVisible == false && mainWindow.IsLoaded)
            //    {
            //        ((MainView)Current.MainWindow).MainFrame.Navigate(new Uri("View\\Pages\\StorePage.xaml", UriKind.RelativeOrAbsolute));
            //    }
            //};
        }
    }
}
