using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using static ProyectoFigma.Login;

namespace ProyectoFigma
{
    public partial class profile : Window
    {
        private Login.UserInfo currentUser;
        private DataGrid datagrid;

        public profile(UserInfo currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            // Inicializa el campo datagrid (asegúrate de que coincide con el nombre en tu XAML)
            datagrid = FindName("datagrid") as DataGrid;

            // Asigna currentUser correctamente
            datagrid.ItemsSource = new List<UserInfo> { currentUser };
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Button_MainMenu(object sender, RoutedEventArgs e)
        {
            MainPage2 AbrirVentanaMain2 = new MainPage2();
            this.Close();
            AbrirVentanaMain2.Show();
        }

        private void Button_favourite(object sender, RoutedEventArgs e)
        {
            // Lógica para el botón Favourite
        }

        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            Settings AbrirVentanaSettings = new Settings();
            this.Close();
            AbrirVentanaSettings.Show();
        }

        // Puedes agregar más eventos de botones según sea necesario

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Asegúrate de que hay elementos seleccionados y el DataGrid no está vacío
            if (datagrid.SelectedItems.Count > 0)
            {
                UserInfo selectedUser = (UserInfo)datagrid.SelectedItem;
                MessageBox.Show($"Nombre: {selectedUser.Nombre}\nEmail: {selectedUser.Email}", "Usuario seleccionado");
            }
        }

    }
}
