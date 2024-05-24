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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
            
        }
        clsUsuario usuario = new clsUsuario();
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (usuario.estadoConexion != "Conectado")
            {
                MessageBox.Show("Error al conectar con la base de datos: " + usuario.estadoConexion);
                return;
            }
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            usuario.ValidarUsuario(nombreUsuario, contraseña);
            if(usuario.estadoConexion == "Usuario EXISTE")
            {
                MessageBox.Show("Inicio de sesión exitoso");
                frmReporte reporte = new frmReporte();
                reporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearUsuario crear = new frmCrearUsuario();
            crear.ShowDialog();
        }
    }
}
