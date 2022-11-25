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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace launcher_master.View.Pages
{
    public partial class TypeOfSignIn : Page
    {
        public TypeOfSignIn()
        {
            InitializeComponent();
        }

        private void SignInDragGames_OnClick(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow != null)
                ((MainView)Application.Current.MainWindow).MainFrame.Navigate(new Uri("View\\Pages\\SignInPage.xaml",
                    UriKind.RelativeOrAbsolute));
        }

        private void SignInLater_OnClick(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow != null)
                ((MainView)Application.Current.MainWindow).MainFrame.Navigate(new Uri("View\\Pages\\PreparingToLaunch.xaml", 
                    UriKind.RelativeOrAbsolute));
        }
    }
}