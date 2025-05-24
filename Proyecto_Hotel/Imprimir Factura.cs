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
using System.IO;


namespace Proyecto_Hotel
{
    public partial class ImprimirFactura : Form
    {
        //public ImprimirFactura()
        //{
        //    InitializeComponent();
        //}

        private string numeroHabitacionPrivada;
        public ImprimirFactura(string nombre, string apellidos, string rfc, string numeroHabitacion,
                               string tipoHabitacion, DateTime fechaIngreso, DateTime fechaSalida,
                               string subtotal, string iva, string total)
        {
            InitializeComponent();
            MessageBox.Show("Constructor con datos invocado");
            // Guardar número de habitación para consultas
            numeroHabitacionPrivada = numeroHabitacion;

            // Llenar controles visuales
            TxtNombreCliente.Text = nombre;
            TxtApellidos.Text = apellidos;
            TxtRFC.Text = rfc;
            CmbNumHabitacion.Text = numeroHabitacion;
            CmbTipoHabitacion.Text = tipoHabitacion;
            DtpFechaIngreso.Value = fechaIngreso;
            DtpFechaSalida.Value = fechaSalida;
            TxtSubtotal.Text = subtotal;
            TxtIVA.Text = iva;
            TxtTotal.Text = total;
        }
        private void ImprimirFactura_Load(object sender, EventArgs e)
        {

        }
        private void BtnImprimirFactura_Click(object sender, EventArgs e)
        {
           try
            {
                // Obtener valores
                string numeroHabitacion = CmbNumHabitacion.Text;
                string nombre = TxtNombreCliente.Text;
                string apellidos = TxtApellidos.Text;
                string tipo = CmbTipoHabitacion.Text;
                string subtotal = TxtSubtotal.Text;
                string iva = TxtIVA.Text;
                string total = TxtTotal.Text;

                // Crear carpeta
                string folderPath = @"C:\FacturasHotelElSol";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Crear ruta CSV
                string filePath = Path.Combine(folderPath, string.Format("Factura_Hab{0}_{1:yyyyMMdd_HHmmss}.csv", numeroHabitacion, DateTime.Now));

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("HOTEL \"EL SOL\"");
                    writer.WriteLine("Factura de Hospedaje");
                    writer.WriteLine(); // Línea en blanco
                    writer.WriteLine("Número de Habitación,Nombre,Apellidos,Tipo de Habitación,Subtotal,IVA,Total");
                    writer.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6}",
    numeroHabitacion, nombre, apellidos, tipo, subtotal, iva, total));
                }

                MessageBox.Show("Factura generada correctamente en C:\\FacturasHotelElSol\\", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la factura: " + ex.Message);
            }
        }

        private void CargarDatosFactura()
        {
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}


        


       
            


           



