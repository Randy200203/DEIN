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

namespace ProyectoFigma
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainWindow AbrirVentanaMain = new MainWindow();
            this.Close();
            AbrirVentanaMain.Show();

        }

        private void Button_favourite(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Profile(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ContactUs(object sender, RoutedEventArgs e)
        {
            Conatct_Us AbrirVentanaContact = new Conatct_Us();
            this.Close();
            AbrirVentanaContact.Show();
        }

        private void Button_LogOut(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
