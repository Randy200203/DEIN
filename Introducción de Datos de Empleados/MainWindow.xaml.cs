using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Introducción_de_Datos_de_Empleados
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

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            if (nombreTextBox.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacío", "Error");
            }
            else if (apellidosTextBox.Text == "")
            {
                MessageBox.Show("El campo Apellidos no puede estar vacío", "Error");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("El campo E-mail no puede estar vacío", "Error");
            }
            else if (telefonoTextBox.Text == "")
            {
                MessageBox.Show("El campo Teléfono no puede estar vacío", "Error");
            }
            else
            {
                // Obtener los datos ingresados en el formulario
                string nombre = nombreTextBox.Text;
                string apellidos = apellidosTextBox.Text;
                string email = emailTextBox.Text;
                string telefono = telefonoTextBox.Text;
                // Otros campos...

                // Crear un nuevo objeto Empleado con los datos
                Employee nuevoEmpleado = new Employee(nombre, apellidos, email, telefono);
                // Agregar el nuevo empleado al DataGrid
                datagrid.Items.Add(nuevoEmpleado);

            }
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            this.Close();
            newWindow.Show();
        }

        private void Cargar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string rutaImagen = openFileDialog.FileName;

                // Cargar la imagen seleccionada en el control Image
                BitmapImage imagenBitmap = new BitmapImage(new Uri(rutaImagen));
                imagenPrevia.Source = imagenBitmap;
            }
        }

        public class Employee
        {
            public string nombre { get; set; }
            public string apellidos { get; set; }
            public string email { get; set; }
            public string telefono { get; set; }

            public Employee(string nom, string ap, string em, string tel)
            {
                nombre = nom;
                apellidos = ap;
                email = em;
                telefono = tel;
                // Inicializar otros campos
            }
        }

        private void gotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textbox)
            {
                if (!String.IsNullOrWhiteSpace(textbox.Text))
                {
                    textbox.Text = "";
                }
            }
        }

        private void Txt_lostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textbox)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    if (textbox.Name == "txtDireccion")
                        textbox.Text = "Dirección";
                    else if (textbox.Name == "txtCiudad")
                        textbox.Text = "Ciudad";
                    else if (textbox.Name == "txtProvincia")
                        textbox.Text = "Provincia";
                    else if (textbox.Name == "txtCodigoPostal")
                        textbox.Text = "Código Postal";
                    else if (textbox.Name == "txtPais")
                        textbox.Text = "País";
                }
            }
        }
    }
}