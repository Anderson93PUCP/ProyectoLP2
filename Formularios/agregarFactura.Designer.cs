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
            this.rbtnVendedor = new System.Windows.Forms.RadioButton();
            this.rbtnCliente = new System.Windows.Forms.RadioButton();
            this.rbtnRuc = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIDGestorFacturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRUCGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedorGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptarAddFactura = new System.Windows.Forms.Button();
            this.btnCancelarAddFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(413, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(597, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDGestorFacturas,
            this.colRUCGestorFactura,
            this.colClienteGestorFactura,
            this.colVendedorGestorFactura,
            this.colFechaEGestorFactura,
            this.colEstadoGestorFactura});
            this.dataGridView1.Location = new System.Drawing.Point(20, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // colIDGestorFacturas
            // 
            this.colIDGestorFacturas.HeaderText = "ID";
            this.colIDGestorFacturas.Name = "colIDGestorFacturas";
            this.colIDGestorFacturas.ReadOnly = true;
            // 
            // colRUCGestorFactura
            // 
            this.colRUCGestorFactura.HeaderText = "RUC";
            this.colRUCGestorFactura.Name = "colRUCGestorFactura";
            this.colRUCGestorFactura.ReadOnly = true;
            // 
            // colClienteGestorFactura
            // 
            this.colClienteGestorFactura.HeaderText = "Cliente";
            this.colClienteGestorFactura.Name = "colClienteGestorFactura";
            this.colClienteGestorFactura.ReadOnly = true;
            // 
            // colVendedorGestorFactura
            // 
            this.colVendedorGestorFactura.HeaderText = "Vendedor";
            this.colVendedorGestorFactura.Name = "colVendedorGestorFactura";
            this.colVendedorGestorFactura.ReadOnly = true;
            // 
            // colFechaEGestorFactura
            // 
            this.colFechaEGestorFactura.HeaderText = "Fecha";
            this.colFechaEGestorFactura.Name = "colFechaEGestorFactura";
            this.colFechaEGestorFactura.ReadOnly = true;
            // 
            // colEstadoGestorFactura
            // 
            this.colEstadoGestorFactura.HeaderText = "Estado";
            this.colEstadoGestorFactura.Name = "colEstadoGestorFactura";
            this.colEstadoGestorFactura.ReadOnly = true;
            // 
            // btnAceptarAddFactura
            // 
            this.btnAceptarAddFactura.Location = new System.Drawing.Point(551, 288);
            this.btnAceptarAddFactura.Name = "btnAceptarAddFactura";
            this.btnAceptarAddFactura.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAddFactura.TabIndex = 10;
            this.btnAceptarAddFactura.Text = "Aceptar";
            this.btnAceptarAddFactura.UseVisualStyleBackColor = true;
            this.btnAceptarAddFactura.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarAddFactura
            // 
            this.btnCancelarAddFactura.Location = new System.Drawing.Point(453, 288);
            this.btnCancelarAddFactura.Name = "btnCancelarAddFactura";
            this.btnCancelarAddFactura.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAddFactura.TabIndex = 11;
            this.btnCancelarAddFactura.Text = "Cancelar";
            this.btnCancelarAddFactura.UseVisualStyleBackColor = true;
            this.btnCancelarAddFactura.Click += new System.EventHandler(this.button2_Click);
            // 
            // agregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 342);
            this.Controls.Add(this.btnCancelarAddFactura);
            this.Controls.Add(this.btnAceptarAddFactura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnRuc);
            this.Controls.Add(this.rbtnCliente);
            this.Controls.Add(this.rbtnVendedor);
            this.Name = "agregarFactura";
            this.Text = "Agregar Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnVendedor;
        private System.Windows.Forms.RadioButton rbtnCliente;
        private System.Windows.Forms.RadioButton rbtnRuc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDGestorFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUCGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedorGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoGestorFactura;
        private System.Windows.Forms.Button btnAceptarAddFactura;
        private System.Windows.Forms.Button btnCancelarAddFactura;
    }
}