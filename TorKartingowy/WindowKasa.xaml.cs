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
    /// Interaction logic for WindowKasa.xaml
    /// </summary>
    public partial class WindowKasa : Window
    {
        public WindowKasa()
        {
            InitializeComponent();
        }

        private void button_Wydaj(object sender, RoutedEventArgs e)
        {
            WindowWydaj window = new WindowWydaj();
            window.Show();
        }

        private void button_Kasuj(object sender, RoutedEventArgs e)
        {
            WindowKasuj window = new WindowKasuj();
            window.Show();
        }

        private void button_Rezerwacja(object sender, RoutedEventArgs e)
        {
            WindowRezerwacja window = new WindowRezerwacja();
            window.Show();
        }
    }
}
