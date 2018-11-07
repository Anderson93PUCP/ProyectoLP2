namespace Formularios
{
    partial class agregarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarFactura));
            this.rbtnVendedor = new System.Windows.Forms.RadioButton();
            this.rbtnCliente = new System.Windows.Forms.RadioButton();
            this.rbtnRuc = new System.Windows.Forms.RadioButton();
            this.txtbuscarPedido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgwListaPedidos = new System.Windows.Forms.DataGridView();
            this.btnAceptarAddFactura = new System.Windows.Forms.Button();
            this.btnCancelarAddFactura = new System.Windows.Forms.Button();
            this.colRUCGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedorGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnVendedor
            // 
            this.rbtnVendedor.AutoSize = true;
            this.rbtnVendedor.Location = new System.Drawing.Point(413, 30);
            this.rbtnVendedor.Name = "rbtnVendedor";
            this.rbtnVendedor.Size = new System.Drawing.Size(71, 17);
            this.rbtnVendedor.TabIndex = 0;
            this.rbtnVendedor.TabStop = true;
            this.rbtnVendedor.Text = "Vendedor";
            this.rbtnVendedor.UseVisualStyleBackColor = true;
            // 
            // rbtnCliente
            // 
            this.rbtnCliente.AutoSize = true;
            this.rbtnCliente.Location = new System.Drawing.Point(534, 30);
            this.rbtnCliente.Name = "rbtnCliente";
            this.rbtnCliente.Size = new System.Drawing.Size(57, 17);
            this.rbtnCliente.TabIndex = 1;
            this.rbtnCliente.TabStop = true;
            this.rbtnCliente.Text = "Cliente";
            this.rbtnCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnRuc
            // 
            this.rbtnRuc.AutoSize = true;
            this.rbtnRuc.Location = new System.Drawing.Point(480, 30);
            this.rbtnRuc.Name = "rbtnRuc";
            this.rbtnRuc.Size = new System.Drawing.Size(48, 17);
            this.rbtnRuc.TabIndex = 2;
            this.rbtnRuc.TabStop = true;
            this.rbtnRuc.Text = "RUC";
            this.rbtnRuc.UseVisualStyleBackColor = true;
            this.rbtnRuc.CheckedChanged += new System.EventHandler(this.rbtnRuc_CheckedChanged);
            // 
            // txtbuscarPedido
            // 
            this.txtbuscarPedido.Location = new System.Drawing.Point(413, 53);
            this.txtbuscarPedido.Name = "txtbuscarPedido";
            this.txtbuscarPedido.Size = new System.Drawing.Size(178, 20);
            this.txtbuscarPedido.TabIndex = 3;
            this.txtbuscarPedido.TextChanged += new System.EventHandler(this.txtbuscarPedido_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBuscar.Location = new System.Drawing.Point(597, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgwListaPedidos
            // 
            this.dgwListaPedidos.AllowUserToAddRows = false;
            this.dgwListaPedidos.AllowUserToDeleteRows = false;
            this.dgwListaPedidos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRUCGestorFactura,
            this.colClienteGestorFactura,
            this.colVendedorGestorFactura,
            this.colFechaEGestorFactura});
            this.dgwListaPedidos.Location = new System.Drawing.Point(20, 102);
            this.dgwListaPedidos.Name = "dgwListaPedidos";
            this.dgwListaPedidos.ReadOnly = true;
            this.dgwListaPedidos.Size = new System.Drawing.Size(652, 150);
            this.dgwListaPedidos.TabIndex = 9;
            // 
            // btnAceptarAddFactura
            // 
            this.btnAceptarAddFactura.Image = global::Formularios.Properties.Resources.check;
            this.btnAceptarAddFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarAddFactura.Location = new System.Drawing.Point(551, 288);
            this.btnAceptarAddFactura.Name = "btnAceptarAddFactura";
            this.btnAceptarAddFactura.Size = new System.Drawing.Size(78, 32);
            this.btnAceptarAddFactura.TabIndex = 10;
            this.btnAceptarAddFactura.Text = "Aceptar";
            this.btnAceptarAddFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarAddFactura.UseVisualStyleBackColor = true;
            this.btnAceptarAddFactura.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarAddFactura
            // 
            this.btnCancelarAddFactura.Image = global::Formularios.Properties.Resources.cross;
            this.btnCancelarAddFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarAddFactura.Location = new System.Drawing.Point(453, 288);
            this.btnCancelarAddFactura.Name = "btnCancelarAddFactura";
            this.btnCancelarAddFactura.Size = new System.Drawing.Size(80, 32);
            this.btnCancelarAddFactura.TabIndex = 11;
            this.btnCancelarAddFactura.Text = "Cancelar";
            this.btnCancelarAddFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarAddFactura.UseVisualStyleBackColor = true;
            this.btnCancelarAddFactura.Click += new System.EventHandler(this.button2_Click);
            // 
            // colRUCGestorFactura
            // 
            this.colRUCGestorFactura.DataPropertyName = "ClienteRUC";
            this.colRUCGestorFactura.HeaderText = "RUC";
            this.colRUCGestorFactura.Name = "colRUCGestorFactura";
            this.colRUCGestorFactura.ReadOnly = true;
            // 
            // colClienteGestorFactura
            // 
            this.colClienteGestorFactura.DataPropertyName = "ClienteNombre";
            this.colClienteGestorFactura.HeaderText = "Cliente";
            this.colClienteGestorFactura.Name = "colClienteGestorFactura";
            this.colClienteGestorFactura.ReadOnly = true;
            // 
            // colVendedorGestorFactura
            // 
            this.colVendedorGestorFactura.DataPropertyName = "NombreVendedor";
            this.colVendedorGestorFactura.HeaderText = "Vendedor";
            this.colVendedorGestorFactura.Name = "colVendedorGestorFactura";
            this.colVendedorGestorFactura.ReadOnly = true;
            // 
            // colFechaEGestorFactura
            // 
            this.colFechaEGestorFactura.DataPropertyName = "Fecha_e";
            this.colFechaEGestorFactura.HeaderText = "Fecha";
            this.colFechaEGestorFactura.Name = "colFechaEGestorFactura";
            this.colFechaEGestorFactura.ReadOnly = true;
            // 
            // agregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 342);
            this.Controls.Add(this.btnCancelarAddFactura);
            this.Controls.Add(this.btnAceptarAddFactura);
            this.Controls.Add(this.dgwListaPedidos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbuscarPedido);
            this.Controls.Add(this.rbtnRuc);
            this.Controls.Add(this.rbtnCliente);
            this.Controls.Add(this.rbtnVendedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregarFactura";
            this.Text = "Agregar Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnVendedor;
        private System.Windows.Forms.RadioButton rbtnCliente;
        private System.Windows.Forms.RadioButton rbtnRuc;
        private System.Windows.Forms.TextBox txtbuscarPedido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgwListaPedidos;
        private System.Windows.Forms.Button btnAceptarAddFactura;
        private System.Windows.Forms.Button btnCancelarAddFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUCGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedorGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEGestorFactura;
    }
}