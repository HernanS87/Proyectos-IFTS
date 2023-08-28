namespace IngresandoDatos
{
    partial class frmIngreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDato1 = new Label();
            lblDato2 = new Label();
            txtDato1 = new TextBox();
            txtDato2 = new TextBox();
            btnAceptar = new Button();
            btnCalculo = new Button();
            SuspendLayout();
            // 
            // lblDato1
            // 
            lblDato1.AutoSize = true;
            lblDato1.Location = new Point(109, 50);
            lblDato1.Name = "lblDato1";
            lblDato1.Size = new Size(45, 15);
            lblDato1.TabIndex = 0;
            lblDato1.Text = "DATO 1";
            // 
            // lblDato2
            // 
            lblDato2.AutoSize = true;
            lblDato2.Location = new Point(109, 96);
            lblDato2.Name = "lblDato2";
            lblDato2.Size = new Size(45, 15);
            lblDato2.TabIndex = 1;
            lblDato2.Text = "DATO 2";
            // 
            // txtDato1
            // 
            txtDato1.Location = new Point(201, 47);
            txtDato1.Name = "txtDato1";
            txtDato1.Size = new Size(176, 23);
            txtDato1.TabIndex = 2;
            // 
            // txtDato2
            // 
            txtDato2.Location = new Point(201, 93);
            txtDato2.Name = "txtDato2";
            txtDato2.Size = new Size(176, 23);
            txtDato2.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(253, 157);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(253, 202);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(75, 23);
            btnCalculo.TabIndex = 5;
            btnCalculo.Text = "CALCULO";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(575, 252);
            Controls.Add(btnCalculo);
            Controls.Add(btnAceptar);
            Controls.Add(txtDato2);
            Controls.Add(txtDato1);
            Controls.Add(lblDato2);
            Controls.Add(lblDato1);
            Name = "frmIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDato1;
        private Label lblDato2;
        private TextBox txtDato1;
        private TextBox txtDato2;
        private Button btnAceptar;
        private Button btnCalculo;
    }
}