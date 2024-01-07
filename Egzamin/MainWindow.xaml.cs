using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Egzamin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void pocztowka_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (pocztowka.IsChecked == true)
            {
                cena_produktu.Content = "1 zł";
                zdjecie.Source = new BitmapImage(new Uri("pocztowka.png", UriKind.Relative));

            }
            else if (list.IsChecked == true)
            {
                cena_produktu.Content = "1,5 zł";
                zdjecie.Source = new BitmapImage(new Uri("list.png", UriKind.Relative));

            }
            else
            {
                cena_produktu.Content = "10zł";
                zdjecie.Source = new BitmapImage(new Uri("paczka.png", UriKind.Relative));
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int parsedVal;

            if (!int.TryParse(kod.Text, out parsedVal))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else if (kod.Text.Length == 5)
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
            else if (kod.Text.Length > 5 || kod.Text.Length < 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
        }
    }
}