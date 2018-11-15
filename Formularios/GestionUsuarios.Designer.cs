namespace Formularios
{
    partial class GestionUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colTelef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnDNI = new System.Windows.Forms.RadioButton();
            this.txtBusqUsuarioDNI = new System.Windows.Forms.TextBox();
            this.rbtRol = new System.Windows.Forms.RadioButton();
            this.cmbBusqUsuarioRol = new System.Windows.Forms.ComboBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnBusquedaPedido = new System.Windows.Forms.Button();
            this.btnElimCliente = new System.Windows.Forms.Button();
            this.btnModCliente = new System.Windows.Forms.Button();
            this.btnAddUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTelef,
            this.colNombre,
            this.colApellido,
            this.colEdad,
            this.colUser,
            this.colEmail,
            this.colFechaI});
            this.dgvUsuarios.Location = new System.Drawing.Point(39, 118);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(699, 217);
            this.dgvUsuarios.TabIndex = 28;
            // 
            // colTelef
            // 
            this.colTelef.DataPropertyName = "Dni";
            this.colTelef.HeaderText = "DNI";
            this.colTelef.Name = "colTelef";
            this.colTelef.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "NOMBRE";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.DataPropertyName = "Apellido";
            this.colApellido.HeaderText = "APELLIDO";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colEdad
            // 
            this.colEdad.DataPropertyName = "Edad";
            this.colEdad.HeaderText = "EDAD";
            this.colEdad.Name = "colEdad";
            this.colEdad.ReadOnly = true;
            // 
            // colUser
            // 
            this.colUser.DataPropertyName = "IDUsuario1";
            this.colUser.HeaderText = "USERNAME";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Telefono";
            this.colEmail.HeaderText = "TELEFONO";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colFechaI
            // 
            this.colFechaI.DataPropertyName = "Fecha_ingreso";
            this.colFechaI.HeaderText = "FECHA INGRESO";
            this.colFechaI.Name = "colFechaI";
            this.colFechaI.ReadOnly = true;
            // 
            // rbtnDNI
            // 
            this.rbtnDNI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnDNI.AutoSize = true;
            this.rbtnDNI.Location = new System.Drawing.Point(453, 44);
            this.rbtnDNI.Name = "rbtnDNI";
            this.rbtnDNI.Size = new System.Drawing.Size(63, 17);
            this.rbtnDNI.TabIndex = 27;
            this.rbtnDNI.TabStop = true;
            this.rbtnDNI.Text = "Por DNI";
            this.rbtnDNI.UseVisualStyleBackColor = true;
            this.rbtnDNI.CheckedChanged += new System.EventHandler(this.rbtnDNI_CheckedChanged);
            // 
            // txtBusqUsuarioDNI
            // 
            this.txtBusqUsuarioDNI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqUsuarioDNI.Enabled = false;
            this.txtBusqUsuarioDNI.Location = new System.Drawing.Point(532, 44);
            this.txtBusqUsuarioDNI.Name = "txtBusqUsuarioDNI";
            this.txtBusqUsuarioDNI.Size = new System.Drawing.Size(119, 20);
            this.txtBusqUsuarioDNI.TabIndex = 26;
            // 
            // rbtRol
            // 
            this.rbtRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtRol.AutoSize = true;
            this.rbtRol.Location = new System.Drawing.Point(453, 84);
            this.rbtRol.Name = "rbtRol";
            this.rbtRol.Size = new System.Drawing.Size(66, 17);
            this.rbtRol.TabIndex = 31;
            this.rbtRol.TabStop = true;
            this.rbtRol.Text = "Por ROL";
            this.rbtRol.UseVisualStyleBackColor = true;
            this.rbtRol.CheckedChanged += new System.EventHandler(this.rbtRol_CheckedChanged);
            // 
            // cmbBusqUsuarioRol
            // 
            this.cmbBusqUsuarioRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBusqUsuarioRol.Enabled = false;
            this.cmbBusqUsuarioRol.FormattingEnabled = true;
            this.cmbBusqUsuarioRol.Items.AddRange(new object[] {
            "Administrador",
            "Operario",
            "Vendedor"});
            this.cmbBusqUsuarioRol.Location = new System.Drawing.Point(532, 84);
            this.cmbBusqUsuarioRol.Name = "cmbBusqUsuarioRol";
            this.cmbBusqUsuarioRol.Size = new System.Drawing.Size(121, 21);
            this.cmbBusqUsuarioRol.TabIndex = 32;
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = global::Formularios.Properties.Resources.cross;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(368, 351);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 36);
            this.btncancelar.TabIndex = 33;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVer.Enabled = false;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Image = global::Formularios.Properties.Resources.file;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(671, 76);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(67, 31);
            this.btnVer.TabIndex = 30;
            this.btnVer.Text = "   Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Visible = false;
            // 
            // btnBusquedaPedido
            // 
            this.btnBusquedaPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBusquedaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaPedido.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBusquedaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaPedido.Location = new System.Drawing.Point(671, 44);
            this.btnBusquedaPedido.Name = "btnBusquedaPedido";
            this.btnBusquedaPedido.Size = new System.Drawing.Size(67, 26);
            this.btnBusquedaPedido.TabIndex = 29;
            this.btnBusquedaPedido.Text = "Buscar";
            this.btnBusquedaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusquedaPedido.UseVisualStyleBackColor = true;
            this.btnBusquedaPedido.Click += new System.EventHandler(this.btnBusquedaPedido_Click);
            // 
            // btnElimCliente
            // 
            this.btnElimCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElimCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnElimCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimCliente.Image = global::Formularios.Properties.Resources._008_document;
            this.btnElimCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimCliente.Location = new System.Drawing.Point(308, 44);
            this.btnElimCliente.Name = "btnElimCliente";
            this.btnElimCliente.Size = new System.Drawing.Size(114, 50);
            this.btnElimCliente.TabIndex = 25;
            this.btnElimCliente.Text = "Eliminar";
            this.btnElimCliente.UseVisualStyleBackColor = false;
            this.btnElimCliente.Click += new System.EventHandler(this.btnElimCliente_Click);
            // 
            // btnModCliente
            // 
            this.btnModCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnModCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModCliente.Image = global::Formularios.Properties.Resources.file__3_;
            this.btnModCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModCliente.Location = new System.Drawing.Point(174, 44);
            this.btnModCliente.Name = "btnModCliente";
            this.btnModCliente.Size = new System.Drawing.Size(114, 50);
            this.btnModCliente.TabIndex = 24;
            this.btnModCliente.Text = "Modificar";
            this.btnModCliente.UseVisualStyleBackColor = false;
            this.btnModCliente.Click += new System.EventHandler(this.btnModCliente_Click);
            // 
            // btnAddUsuario
            // 
            this.btnAddUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsuario.Image = global::Formularios.Properties.Resources.plus__1_;
            this.btnAddUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUsuario.Location = new System.Drawing.Point(39, 44);
            this.btnAddUsuario.Name = "btnAddUsuario";
            this.btnAddUsuario.Size = new System.Drawing.Size(114, 50);
            this.btnAddUsuario.TabIndex = 23;
            this.btnAddUsuario.Text = "Agregar";
            this.btnAddUsuario.UseVisualStyleBackColor = false;
            this.btnAddUsuario.Click += new System.EventHandler(this.btnAddUsuario_Click);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.cmbBusqUsuarioRol);
            this.Controls.Add(this.rbtRol);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnBusquedaPedido);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.rbtnDNI);
            this.Controls.Add(this.txtBusqUsuarioDNI);
            this.Controls.Add(this.btnElimCliente);
            this.Controls.Add(this.btnModCliente);
            this.Controls.Add(this.btnAddUsuario);
            this.Name = "GestionUsuarios";
            this.Text = "GestionUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnBusquedaPedido;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.RadioButton rbtnDNI;
        private System.Windows.Forms.TextBox txtBusqUsuarioDNI;
        private System.Windows.Forms.Button btnElimCliente;
        private System.Windows.Forms.Button btnModCliente;
        private System.Windows.Forms.Button btnAddUsuario;
        private System.Windows.Forms.RadioButton rbtRol;
        private System.Windows.Forms.ComboBox cmbBusqUsuarioRol;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaI;
    }
}