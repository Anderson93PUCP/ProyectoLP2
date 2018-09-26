namespace Formularios
{
    partial class frmAddPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteAddPedido = new System.Windows.Forms.TextBox();
            this.lblDirecAddPedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccAddPedido = new System.Windows.Forms.TextBox();
            this.txtTransAddPedido = new System.Windows.Forms.TextBox();
            this.txtVendAddPedido = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblVendeAddPedido = new System.Windows.Forms.Label();
            this.dgwAddPedido = new System.Windows.Forms.DataGridView();
            this.colItemDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductoDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPUDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuentoDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnElimDetPedido = new System.Windows.Forms.Button();
            this.btnModDetPedido = new System.Windows.Forms.Button();
            this.btnAddDetPedido = new System.Windows.Forms.Button();
            this.lblDetPedido = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancelarAddPedido = new System.Windows.Forms.Button();
            this.btnAceptarAddPedido = new System.Windows.Forms.Button();
            this.lblTotalAddPedido = new System.Windows.Forms.Label();
            this.txtTotalAddPedido = new System.Windows.Forms.TextBox();
            this.btnBuscarDireAddPedido = new System.Windows.Forms.Button();
            this.btnBuscarTransAddPedido = new System.Windows.Forms.Button();
            this.btnBuscarCliAddPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAddPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtClienteAddPedido
            // 
            this.txtClienteAddPedido.Location = new System.Drawing.Point(117, 29);
            this.txtClienteAddPedido.Name = "txtClienteAddPedido";
            this.txtClienteAddPedido.Size = new System.Drawing.Size(227, 20);
            this.txtClienteAddPedido.TabIndex = 1;
            // 
            // lblDirecAddPedido
            // 
            this.lblDirecAddPedido.AutoSize = true;
            this.lblDirecAddPedido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDirecAddPedido.Location = new System.Drawing.Point(31, 58);
            this.lblDirecAddPedido.Name = "lblDirecAddPedido";
            this.lblDirecAddPedido.Size = new System.Drawing.Size(55, 13);
            this.lblDirecAddPedido.TabIndex = 2;
            this.lblDirecAddPedido.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transportista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Location = new System.Drawing.Point(33, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendedor";
            // 
            // txtDireccAddPedido
            // 
            this.txtDireccAddPedido.Location = new System.Drawing.Point(117, 55);
            this.txtDireccAddPedido.Name = "txtDireccAddPedido";
            this.txtDireccAddPedido.Size = new System.Drawing.Size(227, 20);
            this.txtDireccAddPedido.TabIndex = 5;
            // 
            // txtTransAddPedido
            // 
            this.txtTransAddPedido.Location = new System.Drawing.Point(117, 80);
            this.txtTransAddPedido.Name = "txtTransAddPedido";
            this.txtTransAddPedido.Size = new System.Drawing.Size(227, 20);
            this.txtTransAddPedido.TabIndex = 6;
            // 
            // txtVendAddPedido
            // 
            this.txtVendAddPedido.Location = new System.Drawing.Point(118, 106);
            this.txtVendAddPedido.Name = "txtVendAddPedido";
            this.txtVendAddPedido.Size = new System.Drawing.Size(227, 20);
            this.txtVendAddPedido.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblVendeAddPedido
            // 
            this.lblVendeAddPedido.AutoSize = true;
            this.lblVendeAddPedido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblVendeAddPedido.Location = new System.Drawing.Point(29, 136);
            this.lblVendeAddPedido.Name = "lblVendeAddPedido";
            this.lblVendeAddPedido.Size = new System.Drawing.Size(82, 13);
            this.lblVendeAddPedido.TabIndex = 9;
            this.lblVendeAddPedido.Text = "Fecha Registro:";
            // 
            // dgwAddPedido
            // 
            this.dgwAddPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAddPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemDetPedido,
            this.colProductoDetPedido,
            this.colDescDetPedido,
            this.colCantidadDetPedido,
            this.colPUDetPedido,
            this.colDescuentoDetPedido,
            this.colSubTDetPedido,
            this.colStockDetPedido});
            this.dgwAddPedido.Location = new System.Drawing.Point(32, 203);
            this.dgwAddPedido.Name = "dgwAddPedido";
            this.dgwAddPedido.Size = new System.Drawing.Size(758, 176);
            this.dgwAddPedido.TabIndex = 10;
            // 
            // colItemDetPedido
            // 
            this.colItemDetPedido.Frozen = true;
            this.colItemDetPedido.HeaderText = "Item";
            this.colItemDetPedido.Name = "colItemDetPedido";
            this.colItemDetPedido.ReadOnly = true;
            this.colItemDetPedido.Width = 35;
            // 
            // colProductoDetPedido
            // 
            this.colProductoDetPedido.Frozen = true;
            this.colProductoDetPedido.HeaderText = "Producto";
            this.colProductoDetPedido.Name = "colProductoDetPedido";
            this.colProductoDetPedido.ReadOnly = true;
            this.colProductoDetPedido.Width = 80;
            // 
            // colDescDetPedido
            // 
            this.colDescDetPedido.Frozen = true;
            this.colDescDetPedido.HeaderText = "Descripcion";
            this.colDescDetPedido.Name = "colDescDetPedido";
            this.colDescDetPedido.ReadOnly = true;
            // 
            // colCantidadDetPedido
            // 
            this.colCantidadDetPedido.Frozen = true;
            this.colCantidadDetPedido.HeaderText = "Cantidad";
            this.colCantidadDetPedido.Name = "colCantidadDetPedido";
            this.colCantidadDetPedido.ReadOnly = true;
            // 
            // colPUDetPedido
            // 
            this.colPUDetPedido.Frozen = true;
            this.colPUDetPedido.HeaderText = "P.U.";
            this.colPUDetPedido.Name = "colPUDetPedido";
            this.colPUDetPedido.ReadOnly = true;
            // 
            // colDescuentoDetPedido
            // 
            this.colDescuentoDetPedido.Frozen = true;
            this.colDescuentoDetPedido.HeaderText = "Desc.";
            this.colDescuentoDetPedido.Name = "colDescuentoDetPedido";
            this.colDescuentoDetPedido.ReadOnly = true;
            // 
            // colSubTDetPedido
            // 
            this.colSubTDetPedido.Frozen = true;
            this.colSubTDetPedido.HeaderText = "Sub. Total";
            this.colSubTDetPedido.Name = "colSubTDetPedido";
            this.colSubTDetPedido.ReadOnly = true;
            // 
            // colStockDetPedido
            // 
            this.colStockDetPedido.Frozen = true;
            this.colStockDetPedido.HeaderText = "Stock";
            this.colStockDetPedido.Name = "colStockDetPedido";
            this.colStockDetPedido.ReadOnly = true;
            // 
            // btnElimDetPedido
            // 
            this.btnElimDetPedido.Location = new System.Drawing.Point(532, 174);
            this.btnElimDetPedido.Name = "btnElimDetPedido";
            this.btnElimDetPedido.Size = new System.Drawing.Size(75, 23);
            this.btnElimDetPedido.TabIndex = 11;
            this.btnElimDetPedido.Text = "Eliminar";
            this.btnElimDetPedido.UseVisualStyleBackColor = true;
            this.btnElimDetPedido.Click += new System.EventHandler(this.btnElimDetPedido_Click);
            // 
            // btnModDetPedido
            // 
            this.btnModDetPedido.Location = new System.Drawing.Point(625, 174);
            this.btnModDetPedido.Name = "btnModDetPedido";
            this.btnModDetPedido.Size = new System.Drawing.Size(75, 23);
            this.btnModDetPedido.TabIndex = 12;
            this.btnModDetPedido.Text = "Modificar";
            this.btnModDetPedido.UseVisualStyleBackColor = true;
            this.btnModDetPedido.Click += new System.EventHandler(this.btnModDetPedido_Click);
            // 
            // btnAddDetPedido
            // 
            this.btnAddDetPedido.Location = new System.Drawing.Point(715, 174);
            this.btnAddDetPedido.Name = "btnAddDetPedido";
            this.btnAddDetPedido.Size = new System.Drawing.Size(75, 23);
            this.btnAddDetPedido.TabIndex = 13;
            this.btnAddDetPedido.Text = "Agregar";
            this.btnAddDetPedido.UseVisualStyleBackColor = true;
            this.btnAddDetPedido.Click += new System.EventHandler(this.btnAddDetPedido_Click);
            // 
            // lblDetPedido
            // 
            this.lblDetPedido.AutoSize = true;
            this.lblDetPedido.Location = new System.Drawing.Point(6, 184);
            this.lblDetPedido.Name = "lblDetPedido";
            this.lblDetPedido.Size = new System.Drawing.Size(76, 13);
            this.lblDetPedido.TabIndex = 14;
            this.lblDetPedido.Text = "Detalle Pedido";
            // 
            // btnCancelarAddPedido
            // 
            this.btnCancelarAddPedido.Location = new System.Drawing.Point(625, 425);
            this.btnCancelarAddPedido.Name = "btnCancelarAddPedido";
            this.btnCancelarAddPedido.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAddPedido.TabIndex = 15;
            this.btnCancelarAddPedido.Text = "Cancelar";
            this.btnCancelarAddPedido.UseVisualStyleBackColor = true;
            this.btnCancelarAddPedido.Click += new System.EventHandler(this.btnCancelarAddPedido_Click);
            // 
            // btnAceptarAddPedido
            // 
            this.btnAceptarAddPedido.Location = new System.Drawing.Point(715, 425);
            this.btnAceptarAddPedido.Name = "btnAceptarAddPedido";
            this.btnAceptarAddPedido.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAddPedido.TabIndex = 16;
            this.btnAceptarAddPedido.Text = "Aceptar";
            this.btnAceptarAddPedido.UseVisualStyleBackColor = true;
            this.btnAceptarAddPedido.Click += new System.EventHandler(this.btnAceptarAddPedido_Click);
            // 
            // lblTotalAddPedido
            // 
            this.lblTotalAddPedido.AutoSize = true;
            this.lblTotalAddPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAddPedido.Location = new System.Drawing.Point(514, 393);
            this.lblTotalAddPedido.Name = "lblTotalAddPedido";
            this.lblTotalAddPedido.Size = new System.Drawing.Size(83, 24);
            this.lblTotalAddPedido.TabIndex = 23;
            this.lblTotalAddPedido.Text = "TOTAL:";
            // 
            // txtTotalAddPedido
            // 
            this.txtTotalAddPedido.Location = new System.Drawing.Point(598, 396);
            this.txtTotalAddPedido.Name = "txtTotalAddPedido";
            this.txtTotalAddPedido.Size = new System.Drawing.Size(86, 20);
            this.txtTotalAddPedido.TabIndex = 24;
            // 
            // btnBuscarDireAddPedido
            // 
            this.btnBuscarDireAddPedido.Image = global::Formularios.Properties.Resources._017_magnifier_tool;
            this.btnBuscarDireAddPedido.Location = new System.Drawing.Point(351, 52);
            this.btnBuscarDireAddPedido.Name = "btnBuscarDireAddPedido";
            this.btnBuscarDireAddPedido.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarDireAddPedido.TabIndex = 22;
            this.btnBuscarDireAddPedido.UseVisualStyleBackColor = true;
            this.btnBuscarDireAddPedido.Click += new System.EventHandler(this.btnBuscarDireAddPedido_Click);
            // 
            // btnBuscarTransAddPedido
            // 
            this.btnBuscarTransAddPedido.Image = global::Formularios.Properties.Resources._017_magnifier_tool;
            this.btnBuscarTransAddPedido.Location = new System.Drawing.Point(351, 80);
            this.btnBuscarTransAddPedido.Name = "btnBuscarTransAddPedido";
            this.btnBuscarTransAddPedido.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarTransAddPedido.TabIndex = 21;
            this.btnBuscarTransAddPedido.UseVisualStyleBackColor = true;
            this.btnBuscarTransAddPedido.Click += new System.EventHandler(this.btnBuscarTransAddPedido_Click);
            // 
            // btnBuscarCliAddPedido
            // 
            this.btnBuscarCliAddPedido.Image = global::Formularios.Properties.Resources._017_magnifier_tool;
            this.btnBuscarCliAddPedido.Location = new System.Drawing.Point(351, 25);
            this.btnBuscarCliAddPedido.Name = "btnBuscarCliAddPedido";
            this.btnBuscarCliAddPedido.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarCliAddPedido.TabIndex = 20;
            this.btnBuscarCliAddPedido.UseVisualStyleBackColor = true;
            this.btnBuscarCliAddPedido.Click += new System.EventHandler(this.btnBuscarCliAddPedido_Click);
            // 
            // frmAddPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 460);
            this.Controls.Add(this.txtTotalAddPedido);
            this.Controls.Add(this.lblTotalAddPedido);
            this.Controls.Add(this.btnBuscarDireAddPedido);
            this.Controls.Add(this.btnBuscarTransAddPedido);
            this.Controls.Add(this.btnBuscarCliAddPedido);
            this.Controls.Add(this.btnAceptarAddPedido);
            this.Controls.Add(this.btnCancelarAddPedido);
            this.Controls.Add(this.lblDetPedido);
            this.Controls.Add(this.btnAddDetPedido);
            this.Controls.Add(this.btnModDetPedido);
            this.Controls.Add(this.btnElimDetPedido);
            this.Controls.Add(this.dgwAddPedido);
            this.Controls.Add(this.lblVendeAddPedido);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtVendAddPedido);
            this.Controls.Add(this.txtTransAddPedido);
            this.Controls.Add(this.txtDireccAddPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDirecAddPedido);
            this.Controls.Add(this.txtClienteAddPedido);
            this.Controls.Add(this.label1);
            this.Name = "frmAddPedido";
            this.Text = "Añadir Pedido";
            this.Load += new System.EventHandler(this.frmAddPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAddPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClienteAddPedido;
        private System.Windows.Forms.Label lblDirecAddPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccAddPedido;
        private System.Windows.Forms.TextBox txtTransAddPedido;
        private System.Windows.Forms.TextBox txtVendAddPedido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblVendeAddPedido;
        private System.Windows.Forms.DataGridView dgwAddPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPUDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuentoDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockDetPedido;
        private System.Windows.Forms.Button btnElimDetPedido;
        private System.Windows.Forms.Button btnModDetPedido;
        private System.Windows.Forms.Button btnAddDetPedido;
        private System.Windows.Forms.Label lblDetPedido;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancelarAddPedido;
        private System.Windows.Forms.Button btnAceptarAddPedido;
        private System.Windows.Forms.Button btnBuscarCliAddPedido;
        private System.Windows.Forms.Button btnBuscarTransAddPedido;
        private System.Windows.Forms.Button btnBuscarDireAddPedido;
        private System.Windows.Forms.Label lblTotalAddPedido;
        private System.Windows.Forms.TextBox txtTotalAddPedido;
    }
}