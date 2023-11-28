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

namespace GestionEmpleados2023
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

        private void Button_Lista(object sender, RoutedEventArgs e)
        {
            ListaEmpleados AbrirVentanaLista = new ListaEmpleados();
            this.Close();
            AbrirVentanaLista.Show();
        }

        private void Button_Agregar(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Buscar(object sender, RoutedEventArgs e)
        {

        }
    }
}
