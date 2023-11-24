using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ProyectoFigma
{
    public partial class Profile : Window
    {
        public string comprobando;
        //private DataGrid datagrid;

        public Profile()
        {
            InitializeComponent();
            addData(Login.nom, Login.emia);
            addData(Sign_Up.name, Sign_Up.mail);
            //this.currentUser = currentUser;

            //// Inicializa el campo datagrid
            //datagrid = FindName("datagrid") as DataGrid;

            //// Crea una lista con el usuario actual y asígnala al datagrid
            //List<Login.UserInfo> userList = new List<Login.UserInfo> { currentUser };
            //datagrid.ItemsSource = userList;

        }

        public void addData(string nombre, string email)
        {
            UserInfo usuario = new UserInfo(nombre, email);
            datagrid.Items.Add(usuario);
           
        }

        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainPage2 AbrirVentanaMain2 = new MainPage2();
            this.Close();
            AbrirVentanaMain2.Show();
        }

        private void Button_favourite(object sender, RoutedEventArgs e)
        {
            favorite AbrirVentanaFavourite = new favorite();
            this.Close();
            AbrirVentanaFavourite.Show();
        }

        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            Settings AbrirVentanaSettings = new Settings();
            this.Close();
            AbrirVentanaSettings.Show();
        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Asegúrate de que hay elementos seleccionados y el DataGrid no está vacío
            if (datagrid.SelectedItems.Count > 0 && datagrid.SelectedItem is Login.UserInfo selectedUser)
            {
                MessageBox.Show($"Nombre: {selectedUser.Nombre}\nEmail: {selectedUser.Email}", "Usuario seleccionado");
            }
        }

        public class UserInfo
        {
            public string Nombre { get; set; }
            public string Email { get; set; }
            public UserInfo(string nombre,string email)
            {
                this.Nombre = nombre;
                this.Email = email;
            }
        }
    }
}