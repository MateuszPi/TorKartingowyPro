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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Kasa(object sender, RoutedEventArgs e)
        {
            WindowKasa window = new WindowKasa();
            window.Show();
        }

        private void button1_Ligi(object sender, RoutedEventArgs e)
        {
            WindowKasa window = new WindowKasa();
            window.Show();
        }

        private void button2_Baza(object sender, RoutedEventArgs e)
        {
            WindowKasa window = new WindowKasa();
            window.Show();
        }

        private void button3_Archiwum(object sender, RoutedEventArgs e)
        {
            WindowKasa window = new WindowKasa();
            window.Show();
        }

        private void button_Zarzadzanie(object sender, RoutedEventArgs e)
        {
            WindowKasa window = new WindowKasa();
            window.Show();
        }
        private void button_Terminarz(object sender, RoutedEventArgs e)
        {
            WindowKasa window = new WindowKasa();
            window.Show();
        }
    }
}



