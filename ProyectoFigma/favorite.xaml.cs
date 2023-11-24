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
    /// Interaction logic for favorite.xaml
    /// </summary>
    public partial class favorite : Window
    {
        public favorite()
        {
            InitializeComponent();
        }

        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainPage2 AbrirVentanaMain2 = new MainPage2();
            this.Close();
            AbrirVentanaMain2.Show();

        }

        private void Button_ContactUs(object sender, RoutedEventArgs e)
        {
            Contact_Us AbrirVentanaContact = new Contact_Us();
            this.Close();
            AbrirVentanaContact.Show();

        }

        private void Button_Profile(object sender, RoutedEventArgs e)
        {
            Profile AbrirVentanaProfile = new Profile();
            this.Close();
            AbrirVentanaProfile.Show();
        }
    }
}
