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
    public partial class SalidadeHuespedes : Form
    {
        public SalidadeHuespedes()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.SalidadeHuespedes_Load);
            CmbNumHabitacion.SelectedIndexChanged += CmbNumHabitacion_SelectedIndexChanged;
            DtpFechaSalida.ValueChanged += DtpFechaSalida_ValueChanged;

        }
        private void SalidadeHuespedes_Load(object sender, EventArgs e)
        {
           try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    string query = "SELECT numero FROM habitacion WHERE estado = 'Ocupada'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    CmbNumHabitacion.Items.Clear();
                    while (reader.Read())
                    {
                        CmbNumHabitacion.Items.Add(reader["numero"].ToString());
                    }
                    reader.Close();
                }

                CmbPago.Items.Clear();
                CmbPago.Items.AddRange(new string[] { "SI", "NO" });
                CmbEntregoLlaves.Items.Clear();
                CmbEntregoLlaves.Items.AddRange(new string[] { "SI", "NO" });

                if (CmbPago.Items.Count > 0) CmbPago.SelectedIndex = 0;
                if (CmbEntregoLlaves.Items.Count > 0) CmbEntregoLlaves.SelectedIndex = 0;

                TxtDias.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }



       private void CmbNumHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularDiasEstancia();
        }



       private void DtpFechaSalida_ValueChanged(object sender, EventArgs e)
       {
           CalcularDiasEstancia();
       }
        private void CalcularDiasEstancia()
        {
            if (string.IsNullOrEmpty(CmbNumHabitacion.Text))
    {
        TxtDias.Text = "0";
        return;
    }

    try
    {
        using (var conn = ConexionBD.ObtenerConexion())
        {
            string query = @"
                SELECT r.Fecha_ingreso 
                FROM reserva r
                INNER JOIN habitacion h ON r.Id_habitacion = h.Id_habitacion
                WHERE h.numero = @numero
                ORDER BY r.Id_reserva DESC
                LIMIT 1";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@numero", CmbNumHabitacion.Text);

            object fechaIngresoObj = cmd.ExecuteScalar(); // <-- esta línea obtiene la fecha

            
            DateTime fechaIngreso;
            if (fechaIngresoObj != null && DateTime.TryParse(fechaIngresoObj.ToString(), out fechaIngreso))
            {
                DateTime fechaSalida = DtpFechaSalida.Value.Date;

                int diasEstancia = (fechaSalida - fechaIngreso).Days;
                if (diasEstancia < 1) diasEstancia = 1;

                TxtDias.Text = diasEstancia.ToString();
            }
            else
            {
                TxtDias.Text = "0";
                MessageBox.Show("No se encontró la fecha de ingreso en la reserva.");
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al calcular días de estancia: " + ex.Message);
    }
}


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnConfirmarSalida_Click(object sender, EventArgs e)
        {
            if (CmbPago.Text != "SI" || CmbEntregoLlaves.Text != "SI")
            {
                MessageBox.Show("No se puede confirmar la salida. Verifique que el huésped haya pagado y entregado las llaves.");
                return;
            }

            if (string.IsNullOrEmpty(CmbNumHabitacion.Text))
            {
                MessageBox.Show("Seleccione una habitación.");
                return;
            }

            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    // Cambiar estado de habitación a Disponible
                    string update = "UPDATE habitacion SET estado = 'Disponible' WHERE numero = @numero";
                    MySqlCommand cmd = new MySqlCommand(update, conn);
                    cmd.Parameters.AddWithValue("@numero", CmbNumHabitacion.Text);
                    cmd.ExecuteNonQuery();

                    // Opcional: también actualizar la reserva para indicar fecha de salida o estado final

                    MessageBox.Show("Salida confirmada. La habitación ahora está disponible.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al confirmar salida: " + ex.Message);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
