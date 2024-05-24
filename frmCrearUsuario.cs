using pryInicioSesionLogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryInicioDeSesion
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }
        clsUsuario Usuario = new clsUsuario();
        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            Usuario.AgregarUsuario(nombreUsuario, contraseña);
            LimpiarCampos();
            MessageBox.Show("Usuario agregado correctamente.");
        }

        private void LimpiarCampos()
        {
            
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            
        }
    }
}
