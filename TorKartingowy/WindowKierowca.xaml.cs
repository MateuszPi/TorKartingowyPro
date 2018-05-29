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
    /// Logika interakcji dla klasy WindowKierowca.xaml
    /// </summary>
    public partial class WindowKierowca : Window
    {
        string NKK;
        string imie;
        string nazwisko;
        string dataUrodzenia;
        //string typ;
        bool nowy = false;
        bool aktywnaLiga = false;
        bool aktywnyProfil = false;
        TextBoxFillers filler = new TextBoxFillers();
        DatabaseInput dbIn = new DatabaseInput();


        public WindowKierowca(bool edycja, string nkk = "0")
        {
            NKK = nkk;
            InitializeComponent();
            Id.IsEnabled = false;

            if (NKK == "0")
            {
                nowy = false;
                return;
            }
            filler.FillTextBox(Id, "Customer", "ID_Customer", $"WHERE ID_Customer = {NKK}");
            filler.FillTextBox(Imie, "Customer", "FirstName", $"WHERE ID_Customer = {NKK}");
            filler.FillTextBox(Nazwisko, "Customer", "LastName", $"WHERE ID_Customer = {NKK}");
            Data.DisplayDate = Convert.ToDateTime(dbIn.GetValue("Customer", "Birthday", $"WHERE ID_Customer = {NKK}"));
            if (Convert.ToInt32(dbIn.GetValue("Customer", "ActiveInLeague", $"WHERE ID_Customer = {NKK}")) == 1)
            {
                LigaBool.IsChecked = true;
                aktywnaLiga = true;
            }
            if (Convert.ToInt32(dbIn.GetValue("Customer", "ActiveCustomerCard", $"WHERE ID_Customer = {NKK}")) == 1)
            {
                ProfilBool.IsChecked = true;
                aktywnyProfil = true;
            }
            if (edycja == false)
            {
                Id.IsEnabled = false;
                Imie.IsEnabled = false;
                Nazwisko.IsEnabled = false;
                Data.IsEnabled = false;
                LigaBool.IsEnabled = false;
                ProfilBool.IsEnabled = false;
                Zapisz.IsEnabled = false;
            }
        }


        private void Button_Zapisz(object sender, RoutedEventArgs e)
        {
            imie = Imie.Text;
            nazwisko = Nazwisko.Text;
            dataUrodzenia = Data.ToString();
            if (nowy == true)
            {
                dbIn.DodajKierowce(imie, nazwisko, dataUrodzenia, aktywnaLiga, aktywnyProfil);
            }
            else
            {
                dbIn.EdytujKierowce(imie, nazwisko, dataUrodzenia, aktywnaLiga, aktywnyProfil, NKK);
            }
            MessageBox.Show("Wprowadzono zmiany.", "Sukces");
            this.Close();
        }

        private void LigaBool_Checked(object sender, RoutedEventArgs e)
        {
            aktywnaLiga = true;
        }
        private void LigaBool_Unchecked(object sender, RoutedEventArgs e)
        {
            aktywnaLiga = false;
        }

        private void ProfilBool_Checked(object sender, RoutedEventArgs e)
        {
            aktywnyProfil = true;
        }
        private void ProfilBool_Unchecked(object sender, RoutedEventArgs e)
        {
            aktywnyProfil = false;
        }

        private void Button_Cofnij(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Imie_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
