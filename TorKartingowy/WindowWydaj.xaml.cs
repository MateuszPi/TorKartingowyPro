using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TorKartingowy
{
    /// <summary>
    /// Logika interakcji dla klasy WindowWydaj.xaml
    /// </summary>
    public partial class WindowWydaj : Window
    {
        public WindowWydaj()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_WydajBilet(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "";
            if (NumerNazwyKierowcy.Text != "")
            {
                messageBoxText += $"Numer KartyKierowcy: {NumerNazwyKierowcy}\r\n";
            }
            messageBoxText += $"Typ biletu: {TypBiletu.Text}\r\nTyp Kartu {TypKartu.Text}\r\nOpłacony czas: {Czas.Text}\r\nCzy Wydać bilet";
            string caption = "Wydawanie biletu";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    
                    string messageBoxTextYes = "Wydano bilet";
                    string captionYes = "Komunikat";
                    MessageBoxButton buttonYes = MessageBoxButton.OK;
                    MessageBoxImage iconYes = MessageBoxImage.Warning;
                    MessageBox.Show(messageBoxTextYes, captionYes, buttonYes, iconYes);
                    break;
            }
        }
    }
}
