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
using System.Windows.Shapes;

namespace TorKartingowy
{
    /// <summary>
    /// Logika interakcji dla klasy WindowArchiwum.xaml
    /// </summary>
    public partial class WindowArchiwum : Window
    {
        public WindowArchiwum()
        {
            InitializeComponent();
        }

        private void Button_Archiwum(object sender, RoutedEventArgs e)
        {
            FrameArchiwum.Content = new PageArchiwum();
        }

        private void Button_Rekordy(object sender, RoutedEventArgs e)
        {
            FrameArchiwum.Content = new PageRekordy();

        }
    }
}
