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

namespace Formulario_Usabilidad
{
    /// <summary>
    /// Interaction logic for HelpSent.xaml
    /// </summary>
    public partial class HelpSent : Window
    {
        public HelpSent()
        {
            InitializeComponent();
        }

        private void mainPage_Button(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
    }
}
