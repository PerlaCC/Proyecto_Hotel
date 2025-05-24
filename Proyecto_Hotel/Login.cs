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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text;
            string clave = TxtContraseña.Text;

            if (usuario == "admin" && clave == "1234")
            {
                MessageBox.Show("Acceso correcto como Administrador.");
                new MenuPrincipal().Show();
                this.Hide();
            }
            else if (usuario == "recep" && clave == "5678")
            {
                MessageBox.Show("Acceso correcto como Recepcionista.");
                new MenuPrincipal().Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas.");
            }
        }
    }
}
           
       
