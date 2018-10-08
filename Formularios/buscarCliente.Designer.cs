namespace Formularios
{
    partial class buscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarCliente));
            this.rbtnBusqRuc = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.colRucBuscarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSocialBuscarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailBuscarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefBuscarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnBusqRuc
            // 
            this.rbtnBusqRuc.AutoSize = true;
            this.rbtnBusqRuc.Location = new System.Drawing.Point(13, 13);
            this.rbtnBusqRuc.Name = "rbtnBusqRuc";
            this.rbtnBusqRuc.Size = new System.Drawing.Size(48, 17);
            this.rbtnBusqRuc.TabIndex = 0;
            this.rbtnBusqRuc.TabStop = true;
            this.rbtnBusqRuc.Text = "RUC";
            this.rbtnBusqRuc.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(67, 12);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnNombre.TabIndex = 1;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(13, 37);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(116, 20);
            this.txtBuscarCliente.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBuscarCliente.Location = new System.Drawing.Point(136, 33);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRucBuscarCliente,
            this.colRazonSocialBuscarCliente,
            this.colEmailBuscarCliente,
            this.colTelefBuscarCliente});
            this.dgvClientes.Location = new System.Drawing.Point(13, 76);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(444, 150);
            this.dgvClientes.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Formularios.Properties.Resources.check;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(379, 245);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 32);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Formularios.Properties.Resources.cross;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(293, 245);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // colRucBuscarCliente
            // 
            this.colRucBuscarCliente.DataPropertyName = "RUC";
            this.colRucBuscarCliente.Frozen = true;
            this.colRucBuscarCliente.HeaderText = "RUC";
            this.colRucBuscarCliente.Name = "colRucBuscarCliente";
            this.colRucBuscarCliente.ReadOnly = true;
            // 
            // colRazonSocialBuscarCliente
            // 
            this.colRazonSocialBuscarCliente.DataPropertyName = "Nombre";
            this.colRazonSocialBuscarCliente.Frozen = true;
            this.colRazonSocialBuscarCliente.HeaderText = "Razon Social";
            this.colRazonSocialBuscarCliente.Name = "colRazonSocialBuscarCliente";
            this.colRazonSocialBuscarCliente.ReadOnly = true;
            // 
            // colEmailBuscarCliente
            // 
            this.colEmailBuscarCliente.DataPropertyName = "Email";
            this.colEmailBuscarCliente.Frozen = true;
            this.colEmailBuscarCliente.HeaderText = "e-mail";
            this.colEmailBuscarCliente.Name = "colEmailBuscarCliente";
            this.colEmailBuscarCliente.ReadOnly = true;
            // 
            // colTelefBuscarCliente
            // 
            this.colTelefBuscarCliente.DataPropertyName = "Telefono";
            this.colTelefBuscarCliente.Frozen = true;
            this.colTelefBuscarCliente.HeaderText = "Telefóno";
            this.colTelefBuscarCliente.Name = "colTelefBuscarCliente";
            this.colTelefBuscarCliente.ReadOnly = true;
            // 
            // buscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 286);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.rbtnNombre);
            this.Controls.Add(this.rbtnBusqRuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buscarCliente";
            this.Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnBusqRuc;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRucBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocialBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefBuscarCliente;
    }
}