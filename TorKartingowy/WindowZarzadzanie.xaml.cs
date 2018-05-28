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
    /// Logika interakcji dla klasy WindowZarzadzanie.xaml
    /// </summary>
    public partial class WindowZarzadzanie : Window
    {
        TextBoxFillers textBoxFiller = new TextBoxFillers();
        DatabaseInput dbInput = new DatabaseInput();

        public WindowZarzadzanie()
        {
            InitializeComponent();
            textBoxFiller.FillTextBox(CenaZaPrzejazdN, "PriceList", "Price", "WHERE ID_Price = 0");
            textBoxFiller.FillTextBox(CenaZaPrzejazdU, "PriceList", "Price", "WHERE ID_Price = 1");
            textBoxFiller.FillTextBox(CenaZaPrzejazdNP, "PriceList", "Price", "WHERE ID_Price = 2");
            textBoxFiller.FillTextBox(CenaZaPrzejazdUP, "PriceList", "Price", "WHERE ID_Price = 3");
            textBoxFiller.FillTextBox(CenaZaPrzejazdRH, "PriceList", "Price", "WHERE ID_Price = 4");
            textBoxFiller.FillTextBox(CenaZaPrzejazdRK, "PriceList", "Price", "WHERE ID_Price = 5");
            LayoutString.Layout = "1";

        }

        private void button_PotwierdzZmiany(object sender, RoutedEventArgs e)
        {
            dbInput.ZmianyZarzadzanie("10", "10", "10", "10", "10", "10", 3);
        }
    }
}
