using System.Security;
using System.Windows;
using System.Windows.Controls;

namespace launcher_master.СustomControls
{
    public partial class BindablePasswordBox : UserControl
    {
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(SecureString), typeof(BindablePasswordBox));


        public SecureString Password
        {
            get
            {
                return (SecureString)GetValue(PasswordProperty);
            }

            set
            {
                SetValue(PasswordProperty, value);
            }
        }
        public BindablePasswordBox()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChanged += OnPasswordChanged;
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = PasswordTextBox.SecurePassword;
        }
    }
}
