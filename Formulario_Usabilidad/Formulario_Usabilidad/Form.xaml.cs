using Microsoft.Win32;
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

namespace Formulario_Usabilidad
{
    /// <summary>
    /// Interaction logic for Form.xaml
    /// </summary>
    public partial class Form : Window
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            if (nombreTextBox.Text == "")
            {
                MessageBox.Show("The Name field cannot be empty", "Error");
            }
            else if (apellidosTextBox.Text == "")
            {
                MessageBox.Show("The Last Name field cannot be empty", "Error");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("The Email field cannot be empty", "Error");
            }
            else if (telefonoTextBox.Text == "")
            {
                MessageBox.Show("The Phone field cannot be empty", "Error");
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

        private void Send_Click(object sender, RoutedEventArgs e)
        {

            if (nombreTextBox.Text == "")
            {
                MessageBox.Show("The Name field cannot be empty", "Error");
            }
            else if (apellidosTextBox.Text == "")
            {
                MessageBox.Show("The Last Name field cannot be empty", "Error");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("The Email field cannot be empty", "Error");
            }
            else if (telefonoTextBox.Text == "")
            {
                MessageBox.Show("The Phone field cannot be empty", "Error");
            }
            else
            {
                Sent sentForm = new Sent();
                this.Close();
                sentForm.Show();

            }
           
        }
    }
}
