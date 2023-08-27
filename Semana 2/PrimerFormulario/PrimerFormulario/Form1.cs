using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerFormulario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String dni = txtDni.Text;
            MessageBox.Show("Hola mi nombre es " + nombre + " " + apellido + ", y mi documento es " + dni);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";

        }
    }
}
