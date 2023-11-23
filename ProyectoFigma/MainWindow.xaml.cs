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

namespace ProyectoFigma
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

 
        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainWindow AbrirVentanaMain = new MainWindow();
            this.Close();
            AbrirVentanaMain.Show();
        }

        private void Button_Sign(object sender, RoutedEventArgs e)
        {
            Sign_Up AbrirVentanaSignUp = new Sign_Up();
            this.Close();
            AbrirVentanaSignUp.Show();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            Login AbrirVentanaLogin = new Login();
            this.Close();
            AbrirVentanaLogin.Show();
        }

        private void Button_ContactUs(object sender, RoutedEventArgs e)
        {
            Contact_Us AbrirVentanaLogin = new Contact_Us();
            this.Close();
            AbrirVentanaLogin.Show();

        }

        private void Button_tractors(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Watering(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Transportation(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            Settings AbrirVentanaSettings = new Settings();
            this.Close();
            AbrirVentanaSettings.Show();

        }
    }
}
