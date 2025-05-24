using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Hotel
{
    public partial class RegistrodeHabitaciones : Form
    {
        public RegistrodeHabitaciones()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblEstado_Click(object sender, EventArgs e)
        {

        }

        private void RegistrodeHabitaciones_Load(object sender, EventArgs e)
        {
            CmbTipoHabitacion.Items.AddRange(new string[] { "Sencilla", "Doble", "Suite" });
            CmbEstado.Items.AddRange(new string[] { "Disponible", "Ocupada" });

            CmbIdentificacion.Items.AddRange(new string[] {
        "INE",
        "Pasaporte",
        "Licencia de Conducir",
        "Cartilla Militar",
        "Cédula Profesional"
    });


            if (CmbIdentificacion.Items.Count > 0)
                CmbIdentificacion.SelectedIndex = 0;


            CmbTipoHabitacion.SelectedIndexChanged += CmbTipoHabitacion_SelectedIndexChanged;
            NumDiashospedarse.ValueChanged += NumDiashospedarse_ValueChanged;


            CmbNumerodeHabitacion.Items.AddRange(new string[] { "101", "102", "103", "104", "105" });
        }
        private void CmbTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbTipoHabitacion.SelectedItem.ToString())
            {
                case "Sencilla":
                    TxtTarifaporNoche.Text = "500";
                    break;
                case "Doble":
                    TxtTarifaporNoche.Text = "1000";
                    break;
                case "Suite":
                    TxtTarifaporNoche.Text = "1500";
                    break;
            }

            CalcularTotales(); // Agregado para recalcular al cambiar tipo
        }
        private void NumDiashospedarse_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }
        private void CalcularTotales()
        {
            decimal tarifa;
            if (!string.IsNullOrWhiteSpace(TxtTarifaporNoche.Text) &&
                decimal.TryParse(TxtTarifaporNoche.Text, out tarifa))
            {
                int dias = (int)NumDiashospedarse.Value;
                decimal subtotal = tarifa * dias;
                decimal iva = subtotal * 0.16m;
                decimal total = subtotal + iva;

                TxtSubtotal.Text = subtotal.ToString("F2");
                TxtIVA.Text = iva.ToString("F2");
                TxtTotal.Text = total.ToString("F2");
            }
            else
            {
                TxtSubtotal.Text = TxtIVA.Text = TxtTotal.Text = "0.00";
            }
        }

        private void BtnRegistrarHabitacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CmbNumerodeHabitacion.Text) ||
        string.IsNullOrEmpty(CmbTipoHabitacion.Text) ||
        string.IsNullOrEmpty(CmbEstado.Text) ||
        string.IsNullOrEmpty(TxtNombreCliente.Text) ||
        string.IsNullOrEmpty(TxtApellidos.Text) ||
        string.IsNullOrEmpty(CmbIdentificacion.Text) ||
        string.IsNullOrEmpty(TxtRFC.Text) ||
        string.IsNullOrEmpty(TxtTarifaporNoche.Text))
                
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            decimal tarifa;
            if (!decimal.TryParse(TxtTarifaporNoche.Text, out tarifa))
            {
                MessageBox.Show("La tarifa por noche no es válida.");
                return;
            }

            int adultos = (int)NumAdultos.Value;
            int niños = (int)NumNiños.Value;
            int dias = (int)NumDiashospedarse.Value;
            DateTime fechaIngreso = DtpFechaIngreso.Value;

            decimal subtotal = tarifa * dias;
            decimal iva = subtotal * 0.16m;
            decimal total = subtotal + iva;

            TxtSubtotal.Text = subtotal.ToString("F2");
            TxtIVA.Text = iva.ToString("F2");
            TxtTotal.Text = total.ToString("F2");

            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    // Insertar Cliente
                    string queryCliente = @"INSERT INTO cliente (nombre, apellidos, identificacion, rfc)
                                   VALUES (@nombre, @apellidos, @identificacion, @rfc)";
                    MySqlCommand cmdCliente = new MySqlCommand(queryCliente, conn);
                    cmdCliente.Parameters.AddWithValue("@nombre", TxtNombreCliente.Text);
                    cmdCliente.Parameters.AddWithValue("@apellidos", TxtApellidos.Text);
                    cmdCliente.Parameters.AddWithValue("@identificacion", CmbIdentificacion.Text);
                    cmdCliente.Parameters.AddWithValue("@rfc", TxtRFC.Text);
                    cmdCliente.ExecuteNonQuery();
                    int Id_Cliente = (int)cmdCliente.LastInsertedId;

                    // Obtener ID de habitación
                    string queryHabitacion = "SELECT Id_habitacion FROM habitacion WHERE numero = @numero";
                    MySqlCommand cmdHabitacion = new MySqlCommand(queryHabitacion, conn);
                    cmdHabitacion.Parameters.AddWithValue("@numero", CmbNumerodeHabitacion.Text);
                    object result = cmdHabitacion.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("La habitación seleccionada no existe en la base de datos.");
                        return;
                    }

                    int Id_habitacion = Convert.ToInt32(result);

                    // Insertar reserva
                    string queryReserva = @"INSERT INTO reserva 
                (Id_Cliente, Id_habitacion, Fecha_ingreso, dias, adultos, niños, subtotal, iva, total) 
                VALUES 
                (@Id_Cliente, @Id_habitacion, @fechaIngreso, @dias, @adultos, @ninos, @subtotal, @iva, @total)";
                    MySqlCommand cmdReserva = new MySqlCommand(queryReserva, conn);
                    cmdReserva.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
                    cmdReserva.Parameters.AddWithValue("@Id_habitacion", Id_habitacion);
                    cmdReserva.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);  // Nombre corregido
                    cmdReserva.Parameters.AddWithValue("@dias", dias);
                    cmdReserva.Parameters.AddWithValue("@adultos", adultos);
                    cmdReserva.Parameters.AddWithValue("@ninos", niños);
                    cmdReserva.Parameters.AddWithValue("@subtotal", subtotal);
                    cmdReserva.Parameters.AddWithValue("@iva", iva);
                    cmdReserva.Parameters.AddWithValue("@total", total);
                    cmdReserva.ExecuteNonQuery();
                    string actualizarEstado = "UPDATE habitacion SET estado = 'Ocupada' WHERE Id_habitacion = @id";
                    MySqlCommand cmdActualizar = new MySqlCommand(actualizarEstado, conn);
                    cmdActualizar.Parameters.AddWithValue("@id", Id_habitacion);
                    cmdActualizar.ExecuteNonQuery();

                    MessageBox.Show("Reserva registrada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la reserva: " + ex.Message);
            }

        }


        private void CmbTipoHabitacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void LblTipoHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void LblAdultos_Click(object sender, EventArgs e)
        {

        }

        private void TxtAdultos_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnImprimirFactura_Click(object sender, EventArgs e)
        {
            ImprimirFactura frm = new ImprimirFactura(
         TxtNombreCliente.Text,
         TxtApellidos.Text,
         TxtRFC.Text,
         CmbNumerodeHabitacion.Text,
         CmbTipoHabitacion.Text,
         DtpFechaIngreso.Value,
         DtpFechaIngreso.Value.AddDays((int)NumDiashospedarse.Value),
         TxtSubtotal.Text,
         TxtIVA.Text,
         TxtTotal.Text
     );
            {
                MessageBox.Show("Estoy enviando: " + TxtNombreCliente.Text);
            }
            frm.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
