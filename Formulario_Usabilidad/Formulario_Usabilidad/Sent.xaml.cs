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
    /// Interaction logic for Sent.xaml
    /// </summary>
    public partial class Sent : Window
    {
        public Sent()
        {
            InitializeComponent();
        }

        private void logOut_Button(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
