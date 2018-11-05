namespace Formularios
{
    partial class gestorFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestorFacturas));
            this.btnAddFactura = new System.Windows.Forms.Button();
            this.btnElimFactura = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbtnVendedor = new System.Windows.Forms.RadioButton();
            this.rbtnNombreCliente = new System.Windows.Forms.RadioButton();
            this.rbtnRUC = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgwFacturas = new System.Windows.Forms.DataGridView();
            this.colIDGestorFacturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRUCGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedorGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.btnCancelado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFactura
            // 
            this.btnAddFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFactura.Image = global::Formularios.Properties.Resources.plus__1_;
            this.btnAddFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFactura.Location = new System.Drawing.Point(56, 33);
            this.btnAddFactura.Name = "btnAddFactura";
            this.btnAddFactura.Size = new System.Drawing.Size(102, 50);
            this.btnAddFactura.TabIndex = 0;
            this.btnAddFactura.Text = "    Agregar";
            this.btnAddFactura.UseVisualStyleBackColor = true;
            this.btnAddFactura.Click += new System.EventHandler(this.btnAddFactura_Click);
            // 
            // btnElimFactura
            // 
            this.btnElimFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimFactura.Image = global::Formularios.Properties.Resources._008_document;
            this.btnElimFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimFactura.Location = new System.Drawing.Point(206, 33);
            this.btnElimFactura.Name = "btnElimFactura";
            this.btnElimFactura.Size = new System.Drawing.Size(102, 50);
            this.btnElimFactura.TabIndex = 1;
            this.btnElimFactura.Text = "    Eliminar";
            this.btnElimFactura.UseVisualStyleBackColor = true;
            this.btnElimFactura.Click += new System.EventHandler(this.btnElimFactura_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(389, 37);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(157, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // rbtnVendedor
            // 
            this.rbtnVendedor.AutoSize = true;
            this.rbtnVendedor.Location = new System.Drawing.Point(504, 14);
            this.rbtnVendedor.Name = "rbtnVendedor";
            this.rbtnVendedor.Size = new System.Drawing.Size(90, 17);
            this.rbtnVendedor.TabIndex = 4;
            this.rbtnVendedor.TabStop = true;
            this.rbtnVendedor.Text = "Por Vendedor";
            this.rbtnVendedor.UseVisualStyleBackColor = true;
            // 
            // rbtnNombreCliente
            // 
            this.rbtnNombreCliente.AutoSize = true;
            this.rbtnNombreCliente.Location = new System.Drawing.Point(395, 14);
            this.rbtnNombreCliente.Name = "rbtnNombreCliente";
            this.rbtnNombreCliente.Size = new System.Drawing.Size(97, 17);
            this.rbtnNombreCliente.TabIndex = 5;
            this.rbtnNombreCliente.TabStop = true;
            this.rbtnNombreCliente.Text = "Nombre Cliente";
            this.rbtnNombreCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnRUC
            // 
            this.rbtnRUC.AutoSize = true;
            this.rbtnRUC.Location = new System.Drawing.Point(341, 14);
            this.rbtnRUC.Name = "rbtnRUC";
            this.rbtnRUC.Size = new System.Drawing.Size(48, 17);
            this.rbtnRUC.TabIndex = 6;
            this.rbtnRUC.TabStop = true;
            this.rbtnRUC.Text = "RUC";
            this.rbtnRUC.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(552, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgwFacturas
            // 
            this.dgwFacturas.AllowUserToAddRows = false;
            this.dgwFacturas.AllowUserToDeleteRows = false;
            this.dgwFacturas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDGestorFacturas,
            this.colRUCGestorFactura,
            this.colClienteGestorFactura,
            this.colVendedorGestorFactura,
            this.colFechaEGestorFactura,
            this.colEstadoGestorFactura});
            this.dgwFacturas.Location = new System.Drawing.Point(12, 99);
            this.dgwFacturas.Name = "dgwFacturas";
            this.dgwFacturas.ReadOnly = true;
            this.dgwFacturas.Size = new System.Drawing.Size(652, 150);
            this.dgwFacturas.TabIndex = 8;
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
            this.colFechaEGestorFactura.HeaderText = "Fecha Emision";
            this.colFechaEGestorFactura.Name = "colFechaEGestorFactura";
            this.colFechaEGestorFactura.ReadOnly = true;
            // 
            // colEstadoGestorFactura
            // 
            this.colEstadoGestorFactura.HeaderText = "Estado";
            this.colEstadoGestorFactura.Name = "colEstadoGestorFactura";
            this.colEstadoGestorFactura.ReadOnly = true;
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Image = global::Formularios.Properties.Resources.file;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(460, 63);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 28);
            this.btnVer.TabIndex = 9;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarFactura.Image = global::Formularios.Properties.Resources.back__1_;
            this.btnCancelarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarFactura.Location = new System.Drawing.Point(311, 273);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(96, 42);
            this.btnCancelarFactura.TabIndex = 2;
            this.btnCancelarFactura.Text = "    &Regresar";
            this.btnCancelarFactura.UseVisualStyleBackColor = true;
            this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
            // 
            // btnCancelado
            // 
            this.btnCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelado.Location = new System.Drawing.Point(552, 63);
            this.btnCancelado.Name = "btnCancelado";
            this.btnCancelado.Size = new System.Drawing.Size(75, 28);
            this.btnCancelado.TabIndex = 10;
            this.btnCancelado.Text = "Cancelar";
            this.btnCancelado.UseVisualStyleBackColor = true;
            // 
            // gestorFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 337);
            this.Controls.Add(this.btnCancelado);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dgwFacturas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rbtnRUC);
            this.Controls.Add(this.rbtnNombreCliente);
            this.Controls.Add(this.rbtnVendedor);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCancelarFactura);
            this.Controls.Add(this.btnElimFactura);
            this.Controls.Add(this.btnAddFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestorFacturas";
            this.Text = "Gestion de Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.dgwFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFactura;
        private System.Windows.Forms.Button btnElimFactura;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbtnVendedor;
        private System.Windows.Forms.RadioButton rbtnNombreCliente;
        private System.Windows.Forms.RadioButton rbtnRUC;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgwFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDGestorFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUCGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedorGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoGestorFactura;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnCancelarFactura;
        private System.Windows.Forms.Button btnCancelado;
    }
}