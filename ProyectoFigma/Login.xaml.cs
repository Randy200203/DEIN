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
        public static string nom;
        public static string emia;
        public Login()
        {
            InitializeComponent();

            // Asigna los controles del XAML a las variables
            nameTextBox = FindName("nameTextBox") as TextBox;
            mailTextBox = FindName("mailTextBox") as TextBox;
        }

        public void Button_Login(object sender, RoutedEventArgs e)
        {
            try
            {
                // Obtén los valores de nombre y correo electrónico
                string nombre = nameTextBox.Text;
                string email = mailTextBox.Text;
                string password = passwordText.Password;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("The fields Name, E-mail, and Password cannot be empty", "Error");
                    return;
                }
                
                nom = nameTextBox.Text;
                emia = mailTextBox.Text;


                MainPage2 main2 = new MainPage2();
                this.Close();
                main2.Show();

                // Resto del código para crear UserInfo y abrir la ventana de perfil
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }


        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainWindow AbrirVentanaMain = new MainWindow();
            this.Close();
            AbrirVentanaMain.Show();
        }



        private void Button_ContactUs(object sender, RoutedEventArgs e)
        {
            Contact_Us AbrirVentanaLogin = new Contact_Us();
            this.Close();
            AbrirVentanaLogin.Show();

        }

        private void Button_Sign(object sender, RoutedEventArgs e)
        {
            Sign_Up AbrirVentanaSign = new Sign_Up();
            this.Close();
            AbrirVentanaSign.Show();
        }
        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            Settings AbrirVentanaSettings = new Settings();
            this.Close();
            AbrirVentanaSettings.Show();
        }

        internal class UserInfo
        {
            public object Nombre { get; internal set; }
            public object Email { get; internal set; }
        }
    }
}
