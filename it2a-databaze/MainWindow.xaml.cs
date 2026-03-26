using System.Collections.ObjectModel;
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

namespace it2a_databaze
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Kopacky> ModelyKopacek { get; set; } = new ObservableCollection<Kopacky>();
        public MainWindow()
        {
            InitializeComponent();

            ModelyKopacek.Add(new Kopacky { Znacka = "Nike", Model = "Mercurial", Barva = "Žlutá", Cena = 2700, AktualnePouzivam = true });
            ModelyKopacek.Add(new Kopacky { Znacka = "Nike", Model = "Phantom", Barva = "Černá + bílá", Cena = 3200, AktualnePouzivam = false });
            ModelyKopacek.Add(new Kopacky { Znacka = "New Balance", Model = "Furon", Barva = "Tmavě modrá", Cena = 5600, AktualnePouzivam = false });
            ModelyKopacek.Add(new Kopacky { Znacka = "Nike", Model = "Mercurial", Barva = "Oranžová", Cena = 2700, AktualnePouzivam = false });
            ModelyKopacek.Add(new Kopacky { Znacka = "Adidas", Model = "Predator", Barva = "Černá", Cena = 2900, AktualnePouzivam = false });

            DataContext = this;
        }

        private void dgKopacky_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void tbZnacka_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbModel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbBarva_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbCena_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbPouzivam_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_PridatKopacky(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_NacistDoFormulare(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_UpravitVybrane(object sender, RoutedEventArgs e)
        {

        }

        private void Button_SmazatVybrane(object sender, RoutedEventArgs e)
        {

        }

        private void Button_VycistitFormular(object sender, RoutedEventArgs e)
        {

        }
    }
}