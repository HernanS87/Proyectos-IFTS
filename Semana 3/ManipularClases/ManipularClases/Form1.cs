namespace ManipularClases
{
    public partial class frmPrimerProyecto : Form
    {
        public frmPrimerProyecto()
        {
            InitializeComponent();
        }

        private void lblIngresar_Click(object sender, EventArgs e)
        {
            String nom = txtNombre.Text;
            String ape = txtApellido.Text;
            String? tipo = cboTipo.SelectedItem != null ? cboTipo.SelectedItem.ToString() : "";
            int doc = int.Parse(txtDoc.Text);

            if (nom != "" && ape != "" && txtDoc.Text.Length >= 7 && txtDoc.Text.Length <= 8 && tipo != "")
            {
                Postulante p = new Postulante(nom, ape, tipo, doc);

                MessageBox.Show("Nombre: " + p.Nombre + "\n" +
                                "Apellido: " + p.Apellido + "\n" +
                                "Tipo: " + p.Tipo + "\n" +
                                "Documento: " + p.Documento + "\n",
                                "Postulante Ingresado Exitosamente!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completa todos los campos correctamente",
                                "ERROR al ingresar el postulante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDoc.Text = "";
            cboTipo.Text = "";
        }
    }
}