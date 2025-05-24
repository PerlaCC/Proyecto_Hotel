using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Hotel
{
    public partial class Gestion_de_Huespedes : Form
    {
        string cadena = "server=localhost; database=hotel; uid=root; pwd=;";
        MySqlConnection conexion;
        public Gestion_de_Huespedes()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmGestionHuespedes_Load);
            conexion = new MySqlConnection(cadena);
        }
        private void FrmGestionHuespedes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            { 
                using(MySqlConnection conn = new MySqlConnection(cadena))
                {
                    conn.Open();
                    string consulta = "SELECT Id_Cliente, Nombre, Apellidos, Identificacion, RFC, Telefono FROM cliente";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DgvClientes.DataSource = tabla;
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar huéspedes: " + ex.Message);
            }
        }
        
            
        private void TsbAgregar_Click(object sender, EventArgs e)
        {
             // Solicitar datos con InputBox (puedes cambiar a tu método preferido)
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre:", "Agregar Huésped");
            if (string.IsNullOrWhiteSpace(nombre)) return;

            string apellidos = Microsoft.VisualBasic.Interaction.InputBox("Apellidos:", "Agregar Huésped");
            if (string.IsNullOrWhiteSpace(apellidos)) return;

            string identificacion = Microsoft.VisualBasic.Interaction.InputBox("Identificación:", "Agregar Huésped");
            if (string.IsNullOrWhiteSpace(identificacion)) return;

            string rfc = Microsoft.VisualBasic.Interaction.InputBox("RFC:", "Agregar Huésped");
            if (string.IsNullOrWhiteSpace(rfc)) return;

            try
            {

                using (MySqlConnection conn = new MySqlConnection(cadena))
                {
                    conn.Open();

                    string consulta = "INSERT INTO cliente (Nombre, Apellidos, Identificacion, RFC, Telefono) VALUES (@Nombre, @Apellidos, @Identificacion, @RFC, @Telefono)";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellidos", apellidos);
                    comando.Parameters.AddWithValue("@Identificacion", identificacion);
                    comando.Parameters.AddWithValue("@RFC", rfc);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Huésped agregado correctamente.");
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar huésped: " + ex.Message);
            }
            
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un huésped para eliminar.");
                return;
            }

            int idCliente = Convert.ToInt32(DgvClientes.CurrentRow.Cells["Id_Cliente"].Value);

            var resultado = MessageBox.Show("¿Está seguro de eliminar el huésped seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(cadena))
                    {
                        conn.Open();
                        string consulta = "DELETE FROM cliente WHERE Id_Cliente = @Id_Cliente";
                        MySqlCommand comando = new MySqlCommand(consulta, conn);
                        {
                            comando.Parameters.AddWithValue("@Id_Cliente", idCliente);
                            comando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Huésped eliminado.");
                    CargarClientes();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar huésped: " + ex.Message);
                }
            }
        }

        private void TsbModificar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un huésped para modificar.");
                return;
            }

            int idCliente = Convert.ToInt32(DgvClientes.CurrentRow.Cells["Id_Cliente"].Value);

            
            string nombreActual = DgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            string apellidosActual = DgvClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
            string identificacionActual = DgvClientes.CurrentRow.Cells["Identificacion"].Value.ToString();
            string rfcActual = DgvClientes.CurrentRow.Cells["RFC"].Value.ToString();
            

            
            string nombreNuevo = Microsoft.VisualBasic.Interaction.InputBox("Nombre:", "Modificar Huésped", nombreActual);
            if (string.IsNullOrWhiteSpace(nombreNuevo)) nombreNuevo = nombreActual;

            string apellidosNuevo = Microsoft.VisualBasic.Interaction.InputBox("Apellidos:", "Modificar Huésped", apellidosActual);
            if (string.IsNullOrWhiteSpace(apellidosNuevo)) apellidosNuevo = apellidosActual;

            string identificacionNuevo = Microsoft.VisualBasic.Interaction.InputBox("Identificación:", "Modificar Huésped", identificacionActual);
            if (string.IsNullOrWhiteSpace(identificacionNuevo)) identificacionNuevo = identificacionActual;

            string rfcNuevo = Microsoft.VisualBasic.Interaction.InputBox("RFC:", "Modificar Huésped", rfcActual);
            if (string.IsNullOrWhiteSpace(rfcNuevo)) rfcNuevo = rfcActual;

           
            try
            { 
                using (MySqlConnection conn = new MySqlConnection(cadena))
                {
                    conn.Open();
                    string consulta = "UPDATE cliente SET Nombre = @Nombre, Apellidos = @Apellidos, Identificacion = @Identificacion, RFC = @RFC,  WHERE Id_Cliente = @Id_Cliente";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conn)){

                comando.Parameters.AddWithValue("@Nombre", nombreNuevo);
                comando.Parameters.AddWithValue("@Apellidos", apellidosNuevo);
                comando.Parameters.AddWithValue("@Identificacion", identificacionNuevo);
                comando.Parameters.AddWithValue("@RFC", rfcNuevo);
                comando.Parameters.AddWithValue("@Id_Cliente", idCliente);
                comando.ExecuteNonQuery();
                }
            }
                
                MessageBox.Show("Huésped modificado correctamente.");
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar huésped: " + ex.Message);
            }
            
        }
    }
}
