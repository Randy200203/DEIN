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
    /// Lógica de interacción para MainPage2.xaml
    /// </summary>
    public partial class MainPage2 : Window
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainPage2 AbrirVentanaMain2 = new MainPage2();
            this.Close();
            AbrirVentanaMain2.Show();

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



        private void Button_LocateUs(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Profile(object sender, RoutedEventArgs e)
        {

        }

        private void Button_favourite(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ContactUs(object sender, RoutedEventArgs e)
        {

        }

        private void Button_LogOut(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
