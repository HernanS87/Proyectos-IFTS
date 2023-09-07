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
            int doc = txtDoc.Text != "" ? int.Parse(txtDoc.Text) : 0;

            if (nom != "" && ape != "" && txtDoc.Text.Length >= 7 && txtDoc.Text.Length <= 8 && tipo != "")
            {
                Postulante p = new Postulante(nom, ape, tipo, doc);

                int fila = dtgvDatos.Rows.Add();

                dtgvDatos.Rows[fila].Cells[0].Value = p.Nombre;
                dtgvDatos.Rows[fila].Cells[1].Value = p.Apellido;
                dtgvDatos.Rows[fila].Cells[2].Value = p.Tipo;
                dtgvDatos.Rows[fila].Cells[3].Value = p.Documento;

                txtNombre.Text = "";
                txtApellido.Text = "";
                cboTipo.SelectedItem = null;
                txtDoc.Text = "";

                //MessageBox.Show("Nombre: " + p.Nombre + "\n" +
                //                "Apellido: " + p.Apellido + "\n" +
                //                "Tipo: " + p.Tipo + "\n" +
                //                "Documento: " + p.Documento + "\n",
                //                "Postulante Ingresado Exitosamente!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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