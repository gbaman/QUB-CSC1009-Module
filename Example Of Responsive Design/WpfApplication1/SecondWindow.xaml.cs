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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SecondWindow : Grid
    {
        public SecondWindow()
        {
            InitializeComponent();
            this.SizeChanged += OnWindowSizeChanged;
        }

        protected void OnWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            double newWindowHeight = e.NewSize.Height;
            double newWindowWidth = e.NewSize.Width;
            Console.WriteLine(newWindowHeight);
            if (newWindowWidth < 810)
            {
                changeStyle(false);
            }
            else if (newWindowWidth >= 810)
            {
                changeStyle(true);
            }
        }
        private void changeStyle(Boolean desktop)
        {
            Style style = new Style { TargetType = typeof(Label) };
            ResourceDictionary dict = new ResourceDictionary();

            if (desktop)
            {
                this.Resources.MergedDictionaries.Clear();
                Uri path = new Uri("DesktopStyles.xaml", UriKind.Relative);
                this.Resources.MergedDictionaries.Add(Application.LoadComponent(path) as ResourceDictionary);
            }
            else
            {
                // Load Mobile Styles
                this.Resources.MergedDictionaries.Clear();
                Uri mobilePath = new Uri("MobileStyles.xaml", UriKind.Relative);
                this.Resources.MergedDictionaries.Add(Application.LoadComponent(mobilePath) as ResourceDictionary);
            }
            Application.Current.Resources["MyStyle"] = style;
        }
    }
}

/**
 * Styles can also be set using this kind of statement
 * style.Setters.Add(new Setter(Label.BackgroundProperty, Brushes.Aqua));
 * 
*/
