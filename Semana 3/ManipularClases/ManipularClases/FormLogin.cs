using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularClases
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void formPostulante_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Administrador" && txtClave.Text == "Admin1234")
            {
                Form formPostulante = new frmPrimerProyecto();
                formPostulante.Show();
                formPostulante.FormClosed += formPostulante_FormClosed;
                this.Hide();
            } else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos",
                                "ERROR AL INICIAR SESIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "CONTRASEÑA")
            {
                txtClave.Text = "";
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "CONTRASEÑA";
                txtClave.UseSystemPasswordChar = false;
            }
        }


    }
}
