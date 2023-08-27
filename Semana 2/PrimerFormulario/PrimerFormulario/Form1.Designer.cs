namespace PrimerFormulario
{
    partial class frmPrincipal
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
            lblNombre = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            lblDni = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            txtDni = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(109, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(109, 119);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new System.Drawing.Point(109, 180);
            lblDni.Name = "lblDni";
            lblDni.Size = new System.Drawing.Size(27, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(220, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(165, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(220, 119);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(165, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Location = new System.Drawing.Point(220, 180);
            txtDni.Name = "txtDni";
            txtDni.Size = new System.Drawing.Size(165, 23);
            txtDni.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(503, 81);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(101, 38);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(503, 148);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(101, 38);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            ClientSize = new System.Drawing.Size(704, 246);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Primer Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
