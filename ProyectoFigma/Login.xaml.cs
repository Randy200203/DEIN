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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainWindow AbrirVentanaMain = new MainWindow();
            this.Close();
            AbrirVentanaMain.Show();
        }



        private void Button_ContactUs(object sender, RoutedEventArgs e)
        {
            Conatct_Us AbrirVentanaLogin = new Conatct_Us();
            this.Close();
            AbrirVentanaLogin.Show();

        }

        private void Button_Sign(object sender, RoutedEventArgs e)
        {
            Sign_Up AbrirVentanaSign = new Sign_Up();
            this.Close();
            AbrirVentanaSign.Show();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            MainPage2 AbrirVentanMain2 = new MainPage2();
            this.Close();
            AbrirVentanMain2.Show();


        }


        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            Settings AbrirVentanaSettings = new Settings();
            this.Close();
            AbrirVentanaSettings.Show();
        }
    }
}
