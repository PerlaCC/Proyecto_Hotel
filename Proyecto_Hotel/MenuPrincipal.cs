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
    public partial class MenuPrincipal : Form
    {
       //Login mLogin = new Login();
        public string Palabra2;
        public MenuPrincipal()
        {
            InitializeComponent();

            if (Palabra2 == "recep")
            {
                BtnHuespedes.Enabled = false;
            }

            if (Palabra2 == "admin")
            {
                BtnHuespedes.Enabled = true;
            }
        }

        private void LblHotel_ELSol_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultarHabitaciones_Click(object sender, EventArgs e)
        {
            new ConsultarHabitaciones().Show();
        }

        private void BtnRegistroHabitaciones_Click(object sender, EventArgs e)
        {
            new RegistrodeHabitaciones().Show();
        }

        private void BtnSalidaHuespedes_Click(object sender, EventArgs e)
        {
            new SalidadeHuespedes().Show();
        }

        private void BtnImprimirFactura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La factura solo se genera despues de registrar una habitacion.");
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHuespedes_Click(object sender, EventArgs e)
        {
            new Gestion_de_Huespedes().Show();
        }
    }
}
