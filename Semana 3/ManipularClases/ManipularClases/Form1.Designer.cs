namespace ManipularClases
{
    partial class frmPrimerProyecto
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipo = new Label();
            lblDoc = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDoc = new TextBox();
            cboTipo = new ComboBox();
            lblIngresar = new Button();
            lblLimpiar = new Button();
            dtgvDatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Doc = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(62, 54);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(62, 108);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(83, 181);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(263, 181);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(70, 15);
            lblDoc.TabIndex = 3;
            lblDoc.Text = "Documento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(137, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(129, 100);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(137, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(349, 178);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(110, 23);
            txtDoc.TabIndex = 6;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Extranjero" });
            cboTipo.Location = new Point(129, 181);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(103, 23);
            cboTipo.TabIndex = 7;
            // 
            // lblIngresar
            // 
            lblIngresar.Location = new Point(368, 51);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(75, 23);
            lblIngresar.TabIndex = 8;
            lblIngresar.Text = "INGRESAR";
            lblIngresar.UseVisualStyleBackColor = true;
            lblIngresar.Click += lblIngresar_Click;
            // 
            // lblLimpiar
            // 
            lblLimpiar.Location = new Point(368, 99);
            lblLimpiar.Name = "lblLimpiar";
            lblLimpiar.Size = new Size(75, 23);
            lblLimpiar.TabIndex = 9;
            lblLimpiar.Text = "LIMPIAR";
            lblLimpiar.UseVisualStyleBackColor = true;
            lblLimpiar.Click += lblLimpiar_Click;
            // 
            // dtgvDatos
            // 
            dtgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDatos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Tipo, Doc });
            dtgvDatos.Location = new Point(46, 221);
            dtgvDatos.Name = "dtgvDatos";
            dtgvDatos.ReadOnly = true;
            dtgvDatos.RowTemplate.Height = 25;
            dtgvDatos.Size = new Size(424, 203);
            dtgvDatos.TabIndex = 10;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 80;
            // 
            // Doc
            // 
            Doc.HeaderText = "Documento";
            Doc.Name = "Doc";
            Doc.ReadOnly = true;
            // 
            // frmPrimerProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(507, 436);
            Controls.Add(dtgvDatos);
            Controls.Add(lblLimpiar);
            Controls.Add(lblIngresar);
            Controls.Add(cboTipo);
            Controls.Add(txtDoc);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDoc);
            Controls.Add(lblTipo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmPrimerProyecto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRIMER PROYECTO";
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipo;
        private Label lblDoc;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDoc;
        private ComboBox cboTipo;
        private Button lblIngresar;
        private Button lblLimpiar;
        private DataGridView dtgvDatos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Doc;
    }
}