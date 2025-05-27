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
    public partial class MenuPrincipal2 : Form
    {
        public MenuPrincipal2()
        {
            InitializeComponent();
        }

        private void BtnRegistrodeHabitaciones_Click(object sender, EventArgs e)
        {
            new RegistrodeHabitaciones().Show();
        }

        private void BtnConsultarHabitaciones_Click(object sender, EventArgs e)
        {
            new ConsultarHabitaciones().Show();
        }

        private void BtnSalidadeHuespedes_Click(object sender, EventArgs e)
        {
            new SalidadeHuespedes().Show();
        }

        private void BtnImprimirFactura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La factura solo se genera despues de registrar una habitacion.");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
  