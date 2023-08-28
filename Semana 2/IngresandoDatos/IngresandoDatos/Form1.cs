using System.Windows.Forms.VisualStyles;

namespace IngresandoDatos
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dato 1: " + txtDato1.Text + "\n" + "\n"
                + "Dato 2: " + txtDato2.Text,
                "DATOS DESDE LOS TEXTBOX", MessageBoxButtons.OK, MessageBoxIcon.Information);

            String dato1;
            String dato2;

            dato1 = Convert.ToString
                (
                Microsoft.VisualBasic.Interaction.InputBox("Ingresa el valor del DATO 1", "PRIMER DATO", "Ingrese aquí")
                );
            dato2 = Convert.ToString
                (
                Microsoft.VisualBasic.Interaction.InputBox("Ingresa el valor del DATO 2", "SEGUNDO DATO", "Ingrese aquí")
                );

            MessageBox.Show("Dato 1: " + dato1 + "\n" + "\n"
               + "Dato 2: " + dato2,
               "DATOS DESDE LOS CUADROS DE DIALOGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {

            int num1;
            int num2;

            num1 = int.Parse(Convert.ToString
                (
                Microsoft.VisualBasic.Interaction.InputBox("Ingresa el primer numero", "NUMERO 1", "Ingrese aquí")
                ));
            num2 = int.Parse(Convert.ToString
                (
                Microsoft.VisualBasic.Interaction.InputBox("Ingresa el segundo numero", "NUMERO 2", "Ingrese aquí")
                ));

            int mayor;

            if (num1 > num2)
            {
                mayor = num1;
            }
            else if (num1 < num2)
            {
                mayor = num2;
            }
            else mayor = num1;

            MessageBox.Show("El mayor numero ingresado es: " + mayor,
               "MAYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    
    }
}