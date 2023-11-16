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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace conexion__a_Base_de_Datos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;
        public MainWindow()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["conexion__a_Base_de_Datos.Properties.Settings.GestorEmpleadoConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            miConexionSql.Open();
            MuestraArticulos();
        }

        public void MuestraArticulos()
        {
            string consulta = "select * from articulos";
            SqlDataAdapter miAdapter = new SqlDataAdapter(consulta,miConexionSql);
            using (miAdapter)
            {
                DataTable articulosTabla = new DataTable();
                miAdapter.Fill(articulosTabla);
                listaGrid.ItemsSource = articulosTabla.DefaultView;
            }

        }
    }
}
