namespace Lab01_02_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbPersonales = new System.Windows.Forms.GroupBox();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.banner = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.Label();
            this.txtFotografia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtDNI = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.cboCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkUsuario = new System.Windows.Forms.LinkLabel();
            this.gbPersonales.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonales
            // 
            this.gbPersonales.Controls.Add(this.lnkUsuario);
            this.gbPersonales.Controls.Add(this.txtDNI);
            this.gbPersonales.Controls.Add(this.chkActivo);
            this.gbPersonales.Controls.Add(this.dateTimePicker1);
            this.gbPersonales.Controls.Add(this.textBox7);
            this.gbPersonales.Controls.Add(this.textBox5);
            this.gbPersonales.Controls.Add(this.textBox4);
            this.gbPersonales.Controls.Add(this.textBox3);
            this.gbPersonales.Controls.Add(this.textBox2);
            this.gbPersonales.Controls.Add(this.textBox1);
            this.gbPersonales.Controls.Add(this.txtFecha);
            this.gbPersonales.Controls.Add(this.txtEmail);
            this.gbPersonales.Controls.Add(this.txtTelefono);
            this.gbPersonales.Controls.Add(this.txtDireccion);
            this.gbPersonales.Controls.Add(this.txtApellido);
            this.gbPersonales.Controls.Add(this.txtNombre);
            this.gbPersonales.Controls.Add(this.txtCodigo);
            this.gbPersonales.Location = new System.Drawing.Point(12, 64);
            this.gbPersonales.Name = "gbPersonales";
            this.gbPersonales.Size = new System.Drawing.Size(573, 256);
            this.gbPersonales.TabIndex = 0;
            this.gbPersonales.TabStop = false;
            this.gbPersonales.Text = "Datos personales";
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.pictureBox1);
            this.gbInformacion.Controls.Add(this.comboBox2);
            this.gbInformacion.Controls.Add(this.comboBox1);
            this.gbInformacion.Controls.Add(this.txtFotografia);
            this.gbInformacion.Controls.Add(this.txtCargo);
            this.gbInformacion.Controls.Add(this.txtDepartamento);
            this.gbInformacion.Location = new System.Drawing.Point(591, 64);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(359, 258);
            this.gbInformacion.TabIndex = 1;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Información adicional";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Location = new System.Drawing.Point(538, 326);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 41);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(648, 326);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 41);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(753, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 41);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(858, 326);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 41);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banner.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.banner.Location = new System.Drawing.Point(1, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(957, 46);
            this.banner.TabIndex = 6;
            this.banner.Text = "Mantenimiento de Usuarios";
            this.banner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(52, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(49, 15);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "Código:";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(52, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(55, 15);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(52, 89);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(54, 15);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Text = "Apellido:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoSize = true;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(52, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(62, 15);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(52, 141);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(58, 15);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(52, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(42, 15);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Email:";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(52, 194);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(69, 15);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.Text = "Fecha Nac:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.AutoSize = true;
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(62, 30);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(89, 15);
            this.txtDepartamento.TabIndex = 7;
            this.txtDepartamento.Text = "Departamento:";
            // 
            // txtCargo
            // 
            this.txtCargo.AutoSize = true;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(108, 69);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(43, 15);
            this.txtCargo.TabIndex = 8;
            this.txtCargo.Text = "Cargo:";
            // 
            // txtFotografia
            // 
            this.txtFotografia.AutoSize = true;
            this.txtFotografia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFotografia.Location = new System.Drawing.Point(86, 112);
            this.txtFotografia.Name = "txtFotografia";
            this.txtFotografia.Size = new System.Drawing.Size(65, 15);
            this.txtFotografia.TabIndex = 9;
            this.txtFotografia.Text = "Fotografía:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 21);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(121, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(432, 21);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(121, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(268, 21);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(121, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(432, 21);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(121, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(432, 21);
            this.textBox5.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(453, 57);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 21);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(467, 192);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 19);
            this.chkActivo.TabIndex = 14;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            this.txtDNI.AutoSize = true;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(416, 60);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(31, 15);
            this.txtDNI.TabIndex = 15;
            this.txtDNI.Text = "DNI:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(171, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cboCodigo,
            this.cboDNI,
            this.cboNombre,
            this.cboApellidos,
            this.cboDireccion,
            this.cboTelefono,
            this.cboEmail,
            this.cboFecha,
            this.cboDepartamento});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 408);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(945, 160);
            this.dgvUsuarios.TabIndex = 7;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // cboCodigo
            // 
            this.cboCodigo.HeaderText = "Código";
            this.cboCodigo.Name = "cboCodigo";
            // 
            // cboDNI
            // 
            this.cboDNI.HeaderText = "DNI";
            this.cboDNI.Name = "cboDNI";
            // 
            // cboNombre
            // 
            this.cboNombre.HeaderText = "Nombre";
            this.cboNombre.Name = "cboNombre";
            // 
            // cboApellidos
            // 
            this.cboApellidos.HeaderText = "Apellidos";
            this.cboApellidos.Name = "cboApellidos";
            // 
            // cboDireccion
            // 
            this.cboDireccion.HeaderText = "Dirección";
            this.cboDireccion.Name = "cboDireccion";
            // 
            // cboTelefono
            // 
            this.cboTelefono.HeaderText = "Teléfono";
            this.cboTelefono.Name = "cboTelefono";
            // 
            // cboEmail
            // 
            this.cboEmail.HeaderText = "Email";
            this.cboEmail.Name = "cboEmail";
            // 
            // cboFecha
            // 
            this.cboFecha.HeaderText = "Fec/Nac";
            this.cboFecha.Name = "cboFecha";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.HeaderText = "Departamento";
            this.cboDepartamento.Name = "cboDepartamento";
            // 
            // lnkUsuario
            // 
            this.lnkUsuario.AutoSize = true;
            this.lnkUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUsuario.Location = new System.Drawing.Point(121, 33);
            this.lnkUsuario.Name = "lnkUsuario";
            this.lnkUsuario.Size = new System.Drawing.Size(51, 15);
            this.lnkUsuario.TabIndex = 16;
            this.lnkUsuario.TabStop = true;
            this.lnkUsuario.Text = "U10023";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 630);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.gbPersonales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPersonales.ResumeLayout(false);
            this.gbPersonales.PerformLayout();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonales;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label banner;
        private System.Windows.Forms.Label txtDNI;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.Label txtDireccion;
        private System.Windows.Forms.Label txtApellido;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txtFotografia;
        private System.Windows.Forms.Label txtCargo;
        private System.Windows.Forms.Label txtDepartamento;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboDepartamento;
        private System.Windows.Forms.LinkLabel lnkUsuario;
    }
}

