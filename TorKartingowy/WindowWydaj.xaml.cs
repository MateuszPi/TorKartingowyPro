using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        DatabaseInput dbIn = new DatabaseInput();
        string NKK = "0";
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
                string valueString  = TypBiletu.SelectedValue.ToString();
                decimal cena = Convert.ToDecimal(valueString);
                decimal czasD = Convert.ToDecimal(czas);
                DoZaplaty.Text = Convert.ToString(czasD * cena);
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
            //if (kart == null)
            //{
            //    messageBoxText += "Nie wybrano wolnego kartu!";
            //    MessageBox.Show(messageBoxText, "Błąd");
            //    return;
            //}

            if (NumerKartyKierowcy.Text != "")
            {
                messageBoxText += $"Numer KartyKierowcy: {NumerKartyKierowcy.Text}\r\n";
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
                    int idBilet = 0;
                    if (NumerKartyKierowcy.Text != "")
                    {
                        dbIn.WydajBilet(TypBiletu.SelectedValue.ToString(), DoZaplaty.Text, NumerKartyKierowcy.Text);
                        idBilet = dbIn.DajIdBiletu();
                    }
                    else
                    {
                        dbIn.WydajBilet(TypBiletu.SelectedValue.ToString(), DoZaplaty.Text);
                        idBilet = dbIn.DajIdBiletu();
                    }
                    string captionYes = "Komunikat";
                    PdfDocument bilet = new PdfDocument();
                    PdfPage strona = bilet.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(strona);
                    XFont font = new XFont("Verdana", 16, XFontStyle.Bold);
                    XTextFormatter tf = new XTextFormatter(gfx);
                    XRect rect = new XRect(40, 100, 25, 220);
                    gfx.DrawRectangle(XBrushes.SeaShell, rect);
                    gfx.DrawString($"Id Biletu: {idBilet}\r\n Typ kartu: {TypKartu.Text} \r\nOpłacono: {DoZaplaty.Text}", font, XBrushes.Black, rect, XStringFormats.TopLeft);
                    bilet.Save("bilet.pdf");
                    Process.Start("bilet.pdf");
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

        private void Button_SprawdzNkk(object sender, RoutedEventArgs e)
        {
            bool NKKcheck = dbIn.SprawdzNkk(NumerKartyKierowcy.Text);
            if (NKKcheck == false)
            {
                NumerKartyKierowcy.Background = Brushes.Red;
            }
            else
            {
                NumerKartyKierowcy.Background = Brushes.Green;
            }
        }
    }
}
