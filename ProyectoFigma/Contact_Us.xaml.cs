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
    /// Lógica de interacción para Contact_Us.xaml
    /// </summary>
    public partial class Contact_Us : Window
    {
        public Contact_Us()
        {
            InitializeComponent();
        }

        private void Button_favourite(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Profile(object sender, RoutedEventArgs e)
        {
            Profile AbrirVentanaProfile = new Profile();
            this.Close();
            AbrirVentanaProfile.Show();

        }

        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainPage2 AbrirVentanaMain2 = new MainPage2();
            this.Close();
            AbrirVentanaMain2.Show();

        }

        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            Settings AbrirVentanaSettings = new Settings();
            this.Close();
            AbrirVentanaSettings.Show();

        }
    }
}
