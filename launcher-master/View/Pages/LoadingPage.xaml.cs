using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace launcher_master.View.Pages
{
    public partial class LoadingPage : Page
    {
        private readonly DispatcherTimer _dispatcherTimer = new DispatcherTimer();
        private readonly Uri _view = new Uri("View\\Pages\\SignInPage.xaml", UriKind.RelativeOrAbsolute);

        public LoadingPage(Uri view)
        {
            _view = view;
            InitializeComponent();
            _dispatcherTimer.Tick += _dispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            _dispatcherTimer.Start();

        }

        public LoadingPage()
        {
            InitializeComponent();
            _dispatcherTimer.Tick += _dispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            _dispatcherTimer.Start();

        }

        private void _dispatcherTimer_Tick(object sender, EventArgs e)
        {
            MainGrid.Height += 50;
            ProgressBar.Visibility = Visibility.Visible;

            _dispatcherTimer.Tick += _dispatcherTimer_Tick1;
            _dispatcherTimer.Stop();

            _dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            _dispatcherTimer.Start();
        }

        private void _dispatcherTimer_Tick1(object sender, EventArgs e)
        {
            if (Application.Current.MainWindow != null)
            {
                ((MainView)Application.Current.MainWindow).MainFrame.Navigate(_view, UriKind.RelativeOrAbsolute);
            }
            _dispatcherTimer.Stop();

        }
    }
}
