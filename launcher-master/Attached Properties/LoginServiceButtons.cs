using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace launcher_master.Attached_Properties
{
    class LoginServiceButtons : Button
    {
        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public ImageSource ImageIcon
        {
            get => (ImageSource)GetValue(ImageIconProperty);
            set => SetValue(ImageIconProperty, value);
        }

        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        public double IconHeight
        {
            get => (double)GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }

        public Brush IconFill
        {
            get { return (Brush)GetValue(IconFillProperty); }
            set { SetValue(IconFillProperty, value); }
        }

        public Brush IconFillOnHover
        {
            get { return (Brush)GetValue(IconFillOnHoverProperty); }
            set { SetValue(IconFillOnHoverProperty, value); }
        }
        public Brush IconBackground
        {
            get { return (Brush)GetValue(IconBackgroundProperty); }
            set { SetValue(IconBackgroundProperty, value); }
        }
        public Brush IconBackgroundHover
        {
            get { return (Brush)GetValue(IconBackgroundHoverProperty); }
            set { SetValue(IconBackgroundHoverProperty, value); }
        }

        public static readonly DependencyProperty IconFillOnHoverProperty =
            DependencyProperty.Register("IconFillOnHover", typeof(Brush), typeof(LoginServiceButtons));

        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register("IconBackground", typeof(Brush), typeof(LoginServiceButtons));

        public static readonly DependencyProperty IconBackgroundHoverProperty =
            DependencyProperty.Register("IconBackgroundHover", typeof(Brush), typeof(LoginServiceButtons));

        public static readonly DependencyProperty IconFillProperty =
            DependencyProperty.Register("IconFill", typeof(Brush), typeof(LoginServiceButtons));

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PathGeometry), typeof(LoginServiceButtons));

        public static readonly DependencyProperty ImageIconProperty =
            DependencyProperty.Register("ImageIcon", typeof(ImageSource), typeof(LoginServiceButtons));

        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(LoginServiceButtons));

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(LoginServiceButtons));

    }
}
