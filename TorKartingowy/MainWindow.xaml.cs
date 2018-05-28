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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TorKartingowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public static class LayoutString
    {
        public static string Layout { get; set; }
        public static string LayoutId { get; set; }
    }

    public static class ExtensionMethods
    {
        private static Action EmptyDelegate = delegate () { };

        public static void Refresh(this UIElement uiElement)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        }
    }

    public partial class MainWindow : Window
    {
        TextBoxFillers textBoxFiller = new TextBoxFillers();

        public MainWindow()
        {

            InitializeComponent();
            textBoxFiller.FillTextBlock(blockLayout, "Layout", "LayoutName", "WHERE IsActive = 1");
            textBoxFiller.GetOnTrack(blockNaTorze);
        }

        private void button_Kasa(object sender, RoutedEventArgs e)
        {
            WindowKasa window = new WindowKasa();
            window.Show();
        }

        private void button1_Ligi(object sender, RoutedEventArgs e)
        {
            WindowLigi window = new WindowLigi();
            window.Show();
        }

        private void button_Baza(object sender, RoutedEventArgs e)
        {
            WindowBaza window = new WindowBaza();
            window.Show();
        }

        private void button_Archiwum(object sender, RoutedEventArgs e)
        {
            WindowArchiwum window = new WindowArchiwum();
            window.Show();
        }

        private void button_Zarzadzanie(object sender, RoutedEventArgs e)
        {
            WindowZarzadzanie window = new WindowZarzadzanie();
            window.Show();
        }
        private void button_Terminarz(object sender, RoutedEventArgs e)
        {
            WindowTerminarz window = new WindowTerminarz();
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            blockLayout.Text = LayoutString.Layout;
        }
    }
}



