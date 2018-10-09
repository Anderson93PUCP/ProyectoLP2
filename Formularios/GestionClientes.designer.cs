namespace Formularios
{
    partial class GestionClientes
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
            this.rbtnBusqRucCLiente = new System.Windows.Forms.RadioButton();
            this.txtBusqClientes = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.columnRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBusquedaClientes = new System.Windows.Forms.Button();
            this.btnCancelarClientes = new System.Windows.Forms.Button();
            this.btnElimCliente = new System.Windows.Forms.Button();
            this.btnModCliente = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnBusqRucCLiente
            // 
            this.rbtnBusqRucCLiente.AutoSize = true;
            this.rbtnBusqRucCLiente.Location = new System.Drawing.Point(15, 26);
            this.rbtnBusqRucCLiente.Name = "rbtnBusqRucCLiente";
            this.rbtnBusqRucCLiente.Size = new System.Drawing.Size(67, 17);
            this.rbtnBusqRucCLiente.TabIndex = 16;
            this.rbtnBusqRucCLiente.TabStop = true;
            this.rbtnBusqRucCLiente.Text = "Por RUC";
            this.rbtnBusqRucCLiente.UseVisualStyleBackColor = true;
            this.rbtnBusqRucCLiente.CheckedChanged += new System.EventHandler(this.rbtnBusqRucCLiente_CheckedChanged);
            // 
            // txtBusqClientes
            // 
            this.txtBusqClientes.Enabled = false;
            this.txtBusqClientes.Location = new System.Drawing.Point(15, 47);
            this.txtBusqClientes.Name = "txtBusqClientes";
            this.txtBusqClientes.Size = new System.Drawing.Size(212, 20);
            this.txtBusqClientes.TabIndex = 13;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnRUC,
            this.columnNombre,
            this.columnApellido,
            this.columnCorreo,
            this.columnTelefono});
            this.dgvClientes.Location = new System.Drawing.Point(45, 129);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(699, 217);
            this.dgvClientes.TabIndex = 20;
            // 
            // columnRUC
            // 
            this.columnRUC.DataPropertyName = "Ruc";
            this.columnRUC.HeaderText = "RUC";
            this.columnRUC.Name = "columnRUC";
            this.columnRUC.ReadOnly = true;
            // 
            // columnNombre
            // 
            this.columnNombre.DataPropertyName = "Nombre";
            this.columnNombre.HeaderText = "NOMBRE";
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.ReadOnly = true;
            // 
            // columnApellido
            // 
            this.columnApellido.DataPropertyName = "ApellidoPaterno";
            this.columnApellido.HeaderText = "APELLIDO";
            this.columnApellido.Name = "columnApellido";
            this.columnApellido.ReadOnly = true;
            // 
            // columnCorreo
            // 
            this.columnCorreo.DataPropertyName = "Email";
            this.columnCorreo.HeaderText = "CORREO";
            this.columnCorreo.Name = "columnCorreo";
            this.columnCorreo.ReadOnly = true;
            // 
            // columnTelefono
            // 
            this.columnTelefono.DataPropertyName = "Telefono";
            this.columnTelefono.HeaderText = "TELEFONO";
            this.columnTelefono.Name = "columnTelefono";
            this.columnTelefono.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnBusquedaClientes);
            this.groupBox1.Controls.Add(this.txtBusqClientes);
            this.groupBox1.Controls.Add(this.rbtnBusqRucCLiente);
            this.groupBox1.Location = new System.Drawing.Point(434, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 90);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // btnBusquedaClientes
            // 
            this.btnBusquedaClientes.Enabled = false;
            this.btnBusquedaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaClientes.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBusquedaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaClientes.Location = new System.Drawing.Point(233, 43);
            this.btnBusquedaClientes.Name = "btnBusquedaClientes";
            this.btnBusquedaClientes.Size = new System.Drawing.Size(67, 26);
            this.btnBusquedaClientes.TabIndex = 21;
            this.btnBusquedaClientes.Text = "Buscar";
            this.btnBusquedaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusquedaClientes.UseVisualStyleBackColor = true;
            this.btnBusquedaClientes.Click += new System.EventHandler(this.btnBusquedaClientes_Click);
            // 
            // btnCancelarClientes
            // 
            this.btnCancelarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarClientes.Image = global::Formularios.Properties.Resources.cross;
            this.btnCancelarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarClientes.Location = new System.Drawing.Point(348, 364);
            this.btnCancelarClientes.Name = "btnCancelarClientes";
            this.btnCancelarClientes.Size = new System.Drawing.Size(100, 31);
            this.btnCancelarClientes.TabIndex = 19;
            this.btnCancelarClientes.Text = "Cancelar";
            this.btnCancelarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarClientes.UseVisualStyleBackColor = true;
            this.btnCancelarClientes.Visible = false;
            this.btnCancelarClientes.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnElimCliente
            // 
            this.btnElimCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElimCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnElimCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimCliente.Image = global::Formularios.Properties.Resources._008_document;
            this.btnElimCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimCliente.Location = new System.Drawing.Point(314, 49);
            this.btnElimCliente.Name = "btnElimCliente";
            this.btnElimCliente.Size = new System.Drawing.Size(114, 50);
            this.btnElimCliente.TabIndex = 12;
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
            this.btnModCliente.Location = new System.Drawing.Point(180, 49);
            this.btnModCliente.Name = "btnModCliente";
            this.btnModCliente.Size = new System.Drawing.Size(114, 50);
            this.btnModCliente.TabIndex = 11;
            this.btnModCliente.Text = "Modificar";
            this.btnModCliente.UseVisualStyleBackColor = false;
            this.btnModCliente.Click += new System.EventHandler(this.btnModCliente_Click);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.Image = global::Formularios.Properties.Resources.plus__1_;
            this.btnAddCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCliente.Location = new System.Drawing.Point(45, 49);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(114, 50);
            this.btnAddCliente.TabIndex = 10;
            this.btnAddCliente.Text = "Agregar";
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // GestionClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCancelarClientes);
            this.Controls.Add(this.btnElimCliente);
            this.Controls.Add(this.btnModCliente);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionClientes";
            this.Text = "GestionClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarClientes;
        private System.Windows.Forms.RadioButton rbtnBusqRucCLiente;
        private System.Windows.Forms.TextBox txtBusqClientes;
        private System.Windows.Forms.Button btnElimCliente;
        private System.Windows.Forms.Button btnModCliente;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnBusquedaClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefono;
    }
}