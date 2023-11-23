﻿using System;
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
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainWindow AbrirVentanaMain = new MainWindow();
            this.Close();
            AbrirVentanaMain.Show();

        }

        private void Button_SignUp(object sender, RoutedEventArgs e)
        {
            MainPage2 AbrirVentanaMain2 = new MainPage2();
            this.Close();
            AbrirVentanaMain2.Show();

        }


        private void Button_ContactUs(object sender, RoutedEventArgs e)
        {
            Conatct_Us AbrirVentanaLogin = new Conatct_Us();
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
