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
    /// Logika interakcji dla klasy WindowLigi.xaml
    /// </summary>
    public partial class WindowLigi : Window
    {
        public WindowLigi()
        {
            InitializeComponent();
        }

        private void Button_KlasyfikacjaMain(object sender, RoutedEventArgs e)
        {
            FrameLiga.Content = new PageKlasyfikacjaSzczegolowa();
        }

        private void Button_Terminarz(object sender, RoutedEventArgs e)
        {
            FrameLiga.Content = new PageKlasyfikacjaSzczegolowa();
        }
    }
}
