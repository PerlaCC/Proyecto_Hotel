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
    public partial class ConsultarHabitaciones : Form
    {
        public ConsultarHabitaciones()
        {
            InitializeComponent();
            this.Load += ConsultarHabitaciones_Load;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblTotalDeHabitacionesLibres_Click(object sender, EventArgs e)
        {

        }
        private void ConsultarHabitaciones_Load(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }
        private void CargarHabitaciones()
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    string query = @"SELECT 
                                        h.numero AS 'Número de Habitación',
                                        h.tipo AS 'Tipo',
                                        h.estado AS 'Estado',
                                        CONCAT(IFNULL(c.nombre, ''), ' ', IFNULL(c.apellidos, '')) AS 'Cliente'
                                     FROM habitacion h
                                     LEFT JOIN reserva r ON h.Id_habitacion = r.Id_habitacion
                                     LEFT JOIN cliente c ON r.Id_Cliente = c.Id_Cliente;";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DgvHabitaciones.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar habitaciones: " + ex.Message);
            }
        }
        private void TsbAgregar_Click(object sender, EventArgs e)
        {
        }
            
            
           




        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            
        }


        private void TsbModificar_Click(object sender, EventArgs e)
        {
        }
            

        private void DgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            }
        }
    }




   
