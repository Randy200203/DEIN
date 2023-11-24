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
    /// Lógica de interacción para Sign_Up.xaml
    /// </summary>
    
    public partial class Sign_Up : Window
    {
        public static string name;
        public static string mail;
        
        public Sign_Up()
        {
            InitializeComponent();
            nameTextBox = FindName("nameTextBox") as TextBox;
            mailTextBox = FindName("mailTextBox") as TextBox;
            
            
        }

        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainWindow AbrirVentanaMain = new MainWindow();
            this.Close();
            AbrirVentanaMain.Show();

        }

        private void Button_SignUp(object sender, RoutedEventArgs e)
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

                name = nameTextBox.Text;
                mail = mailTextBox.Text;


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


        private void Button_ContactUs(object sender, RoutedEventArgs e)
        {
            Contact_Us AbrirVentanaLogin = new Contact_Us();
            this.Close();
            AbrirVentanaLogin.Show();

        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            Login AbrirVentanaLogin = new Login();
            this.Close();
            AbrirVentanaLogin.Show();
        }

       

        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            Settings AbrirVentanaSettings = new Settings();
            this.Close();
            AbrirVentanaSettings.Show();

        }
    }
  

  
}
