using System;
using System.Collections.Generic;
using System.Data;
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
    /// Logika interakcji dla klasy WindowBaza.xaml
    /// </summary>
    public partial class WindowBaza : Window
    {
        string id = "0";
        DatabaseInput dbIn = new DatabaseInput();

        public WindowBaza()
        {
            InitializeComponent();
            dbIn.DajListeKierowcow(ListaKierowcow);
        }


        private void Button_EdytujKierowce(object sender, RoutedEventArgs e)
        {
            WindowKierowca window = new WindowKierowca(true, id);
            window.Show();
        }

        private void Button_UsunKierowce(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "";
            messageBoxText += $"Jesteś pewnien, że chcesz usunąć tego kierowcę (//ID//)";
            string caption = "Usuń kierowcę";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    string messageBoxTextYes = "Usunięto kierowcę";
                    string captionYes = "Komunikat";
                    MessageBoxButton buttonYes = MessageBoxButton.OK;
                    MessageBoxImage iconYes = MessageBoxImage.Warning;
                    MessageBox.Show(messageBoxTextYes, captionYes, buttonYes, iconYes);
                    break;
            }
        }

        private void Button_DodajKierowce(object sender, RoutedEventArgs e)
        {
            WindowKierowca window = new WindowKierowca(true);
            window.Show();
        }

        private void Button_Szczegoly(object sender, RoutedEventArgs e)
        {
            WindowKierowca window = new WindowKierowca(false, id);
            window.Show();
        }



        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(e.AddedItems[0].ToString());
        }

        private void ListaKierowcow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            id = e.AddedItems[0].ToString();
        }
    }
}
