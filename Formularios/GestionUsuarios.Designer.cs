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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itememail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnBusqRuc = new System.Windows.Forms.RadioButton();
            this.txtBusqPedido = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnBusquedaPedido = new System.Windows.Forms.Button();
            this.btnElimCliente = new System.Windows.Forms.Button();
            this.btnModCliente = new System.Windows.Forms.Button();
            this.btnAddUsuario = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRUC,
            this.colNombre,
            this.colTelef,
            this.colEmail,
            this.itememail,
            this.Column1,
            this.ROL});
            this.dgvClientes.Location = new System.Drawing.Point(39, 118);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(699, 217);
            this.dgvClientes.TabIndex = 28;
            // 
            // colRUC
            // 
            this.colRUC.HeaderText = "Nombre";
            this.colRUC.Name = "colRUC";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Apellido";
            this.colNombre.Name = "colNombre";
            // 
            // colTelef
            // 
            this.colTelef.HeaderText = "DNI";
            this.colTelef.Name = "colTelef";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Telefono";
            this.colEmail.Name = "colEmail";
            // 
            // itememail
            // 
            this.itememail.HeaderText = "Email";
            this.itememail.Name = "itememail";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha de Ingreso";
            this.Column1.Name = "Column1";
            // 
            // ROL
            // 
            this.ROL.HeaderText = "ROL";
            this.ROL.Name = "ROL";
            // 
            // rbtnBusqRuc
            // 
            this.rbtnBusqRuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnBusqRuc.AutoSize = true;
            this.rbtnBusqRuc.Location = new System.Drawing.Point(453, 44);
            this.rbtnBusqRuc.Name = "rbtnBusqRuc";
            this.rbtnBusqRuc.Size = new System.Drawing.Size(63, 17);
            this.rbtnBusqRuc.TabIndex = 27;
            this.rbtnBusqRuc.TabStop = true;
            this.rbtnBusqRuc.Text = "Por DNI";
            this.rbtnBusqRuc.UseVisualStyleBackColor = true;
            // 
            // txtBusqPedido
            // 
            this.txtBusqPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqPedido.Location = new System.Drawing.Point(532, 44);
            this.txtBusqPedido.Name = "txtBusqPedido";
            this.txtBusqPedido.Size = new System.Drawing.Size(119, 20);
            this.txtBusqPedido.TabIndex = 26;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(453, 84);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por ROL";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Operario",
            "Vendedor"});
            this.comboBox1.Location = new System.Drawing.Point(532, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Image = global::Formularios.Properties.Resources.file;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(671, 76);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(67, 31);
            this.btnVer.TabIndex = 30;
            this.btnVer.Text = "   Ver";
            this.btnVer.UseVisualStyleBackColor = true;
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
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnBusquedaPedido);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.rbtnBusqRuc);
            this.Controls.Add(this.txtBusqPedido);
            this.Controls.Add(this.btnElimCliente);
            this.Controls.Add(this.btnModCliente);
            this.Controls.Add(this.btnAddUsuario);
            this.Name = "GestionUsuarios";
            this.Text = "GestionUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnBusquedaPedido;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.RadioButton rbtnBusqRuc;
        private System.Windows.Forms.TextBox txtBusqPedido;
        private System.Windows.Forms.Button btnElimCliente;
        private System.Windows.Forms.Button btnModCliente;
        private System.Windows.Forms.Button btnAddUsuario;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn itememail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROL;
        private System.Windows.Forms.Button btncancelar;
    }
}