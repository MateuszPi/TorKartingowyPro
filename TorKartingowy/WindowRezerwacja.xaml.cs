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
    /// Logika interakcji dla klasy WindowRezerwacja.xaml
    /// </summary>
    public partial class WindowRezerwacja : Window
    {
        public WindowRezerwacja()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Rezerwuj(object sender, RoutedEventArgs e)
        {
             string messageBoxText = "";
            if (NumerKartyKierowcy.Text != "")
            {
                messageBoxText += $"Numer KartyKierowcy: {NumerKartyKierowcy}\r\n";
            }
            messageBoxText += $"REZERWACJA:\r\nDnia {DataRezerwacji.Text}\r\nNa Klienta: {NumerKartyKierowcy.Text}\r\nTyp {TypKartow.Text}\r\nIlość: {LiczbaKartow.Text}";
            string caption = "Rezerwacja";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    
                    string messageBoxTextYes = "Zarezerwowano";
                    string captionYes = "Komunikat";
                    MessageBoxButton buttonYes = MessageBoxButton.OK;
                    MessageBoxImage iconYes = MessageBoxImage.Warning;
                    MessageBox.Show(messageBoxTextYes, captionYes, buttonYes, iconYes);
                    break;
            }
        }
    }
}
