using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using launcher_master.View.Pages;

namespace launcher_master
{
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            MainView mainWindow = new MainView();
            mainWindow.Show();

            mainWindow.IsVisibleChanged += (s, ev) =>
            {
                if (mainWindow.IsVisible == false && mainWindow.IsLoaded)
                {
                }
            };
        }
    }
}
