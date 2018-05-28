using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// 
    public partial class WindowRezerwacja : Window
    {
        string typKartow;
        ComboFiller filler = new ComboFiller();
        



        public WindowRezerwacja()
        {
            InitializeComponent();
            filler.DajTypyKartow(TypKartow);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Rezerwuj(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "";
            if (GodzinaOd.Text == "")
            {
                messageBoxText += "Nie wybrano godziny początku rezerwacji!";
                MessageBox.Show(messageBoxText, "Błąd");
                return;
            }
            if (GodzinaDo.Text == "")
            {
                messageBoxText += "Nie wybrano godziny końca rezerwacji!";
                MessageBox.Show(messageBoxText, "Błąd");
                return;
            }
            if (typKartow == null)
            {
                messageBoxText += "Nie wybrano typu kartu!";
                MessageBox.Show(messageBoxText, "Błąd");
                return;
            }
            if (LiczbaKartow.Text == "")
            {
                messageBoxText += "Nie wybrano ilości kartów!";
                MessageBox.Show(messageBoxText, "Błąd");
                return;
            }


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
        private void TypKartu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            typKartow = e.AddedItems[0].ToString();
        }

        private void GodzinaOd_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (GodzinaOd.Text.Length == 0)
            {
                Regex regex = new Regex(@"[0-2]");
                e.Handled = !regex.IsMatch(e.Text);
            }
            if (GodzinaOd.Text.Length == 1)
            {
                Regex regex = new Regex(@"[0-9]");
                e.Handled = !regex.IsMatch(e.Text);
            }
            if (GodzinaOd.Text.Length == 2)
            {
                Regex regex = new Regex(@":");
                e.Handled = !regex.IsMatch(e.Text);
            }
            if (GodzinaOd.Text.Length == 3)
            {
                Regex regex = new Regex(@"[0-5]");
                e.Handled = !regex.IsMatch(e.Text);
            }
            if (GodzinaOd.Text.Length == 4)
            {
                Regex regex = new Regex(@"[0-9]");
                e.Handled = !regex.IsMatch(e.Text);
            }
            if (GodzinaOd.Text.Length > 4)
            {
                Regex regex = new Regex(@"");
                e.Handled = !regex.IsMatch(e.Text);
            }
        }

        public void BindComboBox(ComboBox comboBoxName)
        {

        }

        private void TypKartow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
