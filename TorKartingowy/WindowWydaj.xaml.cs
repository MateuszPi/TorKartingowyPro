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
        ComboFiller filler = new ComboFiller();
        string typKartu;
        string typBiletu;
        string kart;
        int kartId;

        public WindowWydaj()
        {
            InitializeComponent();
            filler.DajTypyKartow(TypKartu);
            filler.DajTypBiletu(TypBiletu);
            //filler.DajKart(Kart, 1);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //liczenie do zapłaty
            if (Czas.Text != "")
            {
                string czas = Czas.Text;
                decimal czasD = Convert.ToDecimal(czas);
                DoZaplaty.Text = Convert.ToString(czasD * 15);
            }
            
        }

        private void Button_WydajBilet(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "";
            if (typBiletu == null)
            {
                messageBoxText += "Nie wybrano typu biletu!";
                MessageBox.Show( messageBoxText, "Błąd");
                return;
            }
            if (typKartu == null)
            {
                messageBoxText += "Nie wybrano typu kartu!";
                MessageBox.Show(messageBoxText, "Błąd");
                return;
            }
            if (kart == null)
            {
                messageBoxText += "Nie wybrano wolnego kartu!";
                MessageBox.Show(messageBoxText, "Błąd");
                return;
            }

            if (NumerKartyKierowcy.Text != "")
            {
                messageBoxText += $"Numer KartyKierowcy: {NumerKartyKierowcy}\r\n";
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

        private void TypBiletu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            typBiletu = e.AddedItems[0].ToString();
        }

        private void TypKartu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            typKartu = e.AddedItems[0].ToString();
        }

        private void Kart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            kart = e.AddedItems[0].ToString();
        }
    }
}
