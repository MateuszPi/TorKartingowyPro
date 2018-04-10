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

namespace TorKartingowy
{
    /// <summary>
    /// Logika interakcji dla klasy PageKlasyfikacjaMain.xaml
    /// </summary>
    public partial class PageKlasyfikacjaMain : Page
    {
        public PageKlasyfikacjaMain()
        {
            InitializeComponent();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_KlasyfikacjaSzczegolowa(object sender, RoutedEventArgs e)
        {
            KlasyfikacjaPage.Content = new PageKlasyfikacjaSzczegolowa();
        }
        private void Button_Punktacja(object sender, RoutedEventArgs e)
        {
            KlasyfikacjaPage.Content = new PagePunktacja();
        }
    }
}
