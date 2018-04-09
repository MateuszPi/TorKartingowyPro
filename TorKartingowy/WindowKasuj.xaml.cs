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
    /// Logika interakcji dla klasy WindowKasuj.xaml
    /// </summary>
    public partial class WindowKasuj : Window
    {
        public WindowKasuj()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_WydajBilet(object sender, RoutedEventArgs e)
        {
            string messageBoxText = $"Skasowano bilet {IDBilet.Text}";
            string caption = "Wydawanie biletu";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
        }
    }
}
