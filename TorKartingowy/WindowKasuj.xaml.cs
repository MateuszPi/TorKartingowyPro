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
        TextBoxFillers filler = new TextBoxFillers();
        DatabaseInput dbIn = new DatabaseInput();



        public WindowKasuj()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_WydajBilet(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "";
            if (IDBilet.Text == "")
            {
                messageBoxText += "Brak ID biletu!";
                MessageBox.Show(messageBoxText, "Błąd");
                return;
            }


            messageBoxText += $"Skasować bilet {IDBilet.Text}?";
            string caption = "Wydawanie biletu";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            filler.FillTextBlock(CzasOplacony, "Ride", "PrePaid", $"WHERE ID_Ride = {IDBilet.Text}");
            string timeStringInMinutes = dbIn.WypelnijPrzejazd(IDBilet.Text);
            decimal godziny = Convert.ToDecimal(timeStringInMinutes) / 60;
            string cenaZaGodzineString = dbIn.GetValue("Ride", "PricePH", $"WHERE ID_Ride = {IDBilet.Text}");
            decimal cenaZaGodzine = Convert.ToDecimal(cenaZaGodzineString); 
            string zaplaconoString = dbIn.GetValue("Ride", "PrePaid", $"WHERE ID_Ride = {IDBilet.Text}");
            decimal zaplacono = Convert.ToDecimal(zaplaconoString);
            decimal cena = godziny * cenaZaGodzine;
            decimal doZaplaty = cena - zaplacono;
            decimal czasOplaconyD = zaplacono / cenaZaGodzine;
            CzasOplacony.Text = czasOplaconyD.ToString();
            CzasPrzejechany.Text = godziny.ToString();
            Roznica.Text = Convert.ToString(godziny - czasOplaconyD);
            DoZaplaty.Text = doZaplaty.ToString();
        }
    }
}
