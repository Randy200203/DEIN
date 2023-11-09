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
        private IEnumerable employees;

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
                Employee nuevoEmpleado = new Employee(nombreTextBox.Text, apellidosTextBox.Text, emailTextBox.Text, telefonoTextBox.Text);
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
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }

            public Employee(string nombre, string apellidos, string email, string telefono)
            {
                this.Nombre = nombre;
                this.Apellidos = apellidos;
                this.Email = email;
                this.Telefono = telefono;
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
                if (String.IsNullOrWhiteSpace(textbox.Text))
                {
                    if (textbox.Name == "box_direccion")
                    {
                        textbox.Text = "Dirección";
                    }
                    else if (textbox.Name == "box_ciudad")
                    {
                        textbox.Text = "Ciudad";
                    }
                    else if (textbox.Name == "box_provincia")
                    {
                        textbox.Text = "Provincia";
                    }
                    else if (textbox.Name == "box_codigo")
                    {
                        textbox.Text = "Código Postal";
                    }
                    else if (textbox.Name == "box_pais")
                    {
                        textbox.Text = "País";
                    }
                }
            }
        }
    }
}
