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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteAddPedido = new System.Windows.Forms.TextBox();
            this.lblDirecAddPedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccAddPedido = new System.Windows.Forms.TextBox();
            this.txtTransAddPedido = new System.Windows.Forms.TextBox();
            this.dgvAddPedido = new System.Windows.Forms.DataGridView();
            this.colCodPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductoDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPUDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuentoDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTDetPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDetPedido = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTotalAddPedido = new System.Windows.Forms.Label();
            this.txtTotalAddPedido = new System.Windows.Forms.TextBox();
            this.btnBuscarDireAddPedido = new System.Windows.Forms.Button();
            this.btnBuscarTransAddPedido = new System.Windows.Forms.Button();
            this.btnBuscarCliAddPedido = new System.Windows.Forms.Button();
            this.btnAceptarAddPedido = new System.Windows.Forms.Button();
            this.btnCancelarAddPedido = new System.Windows.Forms.Button();
            this.btnAddDetPedido = new System.Windows.Forms.Button();
            this.btnModDetPedido = new System.Windows.Forms.Button();
            this.btnElimDetPedido = new System.Windows.Forms.Button();
            this.lblPedidoAddpedido = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblSolesSubTotal = new System.Windows.Forms.Label();
            this.cbEstadoPedido = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddPedido)).BeginInit();
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
            this.txtClienteAddPedido.Enabled = false;
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
            this.txtDireccAddPedido.Enabled = false;
            this.txtDireccAddPedido.Location = new System.Drawing.Point(117, 55);
            this.txtDireccAddPedido.Name = "txtDireccAddPedido";
            this.txtDireccAddPedido.Size = new System.Drawing.Size(227, 20);
            this.txtDireccAddPedido.TabIndex = 5;
            // 
            // txtTransAddPedido
            // 
            this.txtTransAddPedido.Enabled = false;
            this.txtTransAddPedido.Location = new System.Drawing.Point(117, 80);
            this.txtTransAddPedido.Name = "txtTransAddPedido";
            this.txtTransAddPedido.Size = new System.Drawing.Size(227, 20);
            this.txtTransAddPedido.TabIndex = 6;
            // 
            // dgvAddPedido
            // 
            this.dgvAddPedido.AllowUserToAddRows = false;
            this.dgvAddPedido.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAddPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodPro,
            this.colProductoDetPedido,
            this.colDescDetPedido,
            this.colCantidadDetPedido,
            this.colPUDetPedido,
            this.colDescuentoDetPedido,
            this.colSubTDetPedido});
            this.dgvAddPedido.GridColor = System.Drawing.SystemColors.Control;
            this.dgvAddPedido.Location = new System.Drawing.Point(32, 203);
            this.dgvAddPedido.Name = "dgvAddPedido";
            this.dgvAddPedido.Size = new System.Drawing.Size(758, 176);
            this.dgvAddPedido.TabIndex = 10;
            // 
            // colCodPro
            // 
            this.colCodPro.DataPropertyName = "proCod";
            this.colCodPro.Frozen = true;
            this.colCodPro.HeaderText = "Codigo";
            this.colCodPro.Name = "colCodPro";
            this.colCodPro.ReadOnly = true;
            // 
            // colProductoDetPedido
            // 
            this.colProductoDetPedido.DataPropertyName = "proNomb";
            this.colProductoDetPedido.Frozen = true;
            this.colProductoDetPedido.HeaderText = "Nombre";
            this.colProductoDetPedido.Name = "colProductoDetPedido";
            this.colProductoDetPedido.ReadOnly = true;
            this.colProductoDetPedido.Width = 80;
            // 
            // colDescDetPedido
            // 
            this.colDescDetPedido.DataPropertyName = "proDesc";
            this.colDescDetPedido.Frozen = true;
            this.colDescDetPedido.HeaderText = "Descripcion";
            this.colDescDetPedido.Name = "colDescDetPedido";
            this.colDescDetPedido.ReadOnly = true;
            // 
            // colCantidadDetPedido
            // 
            this.colCantidadDetPedido.DataPropertyName = "Cantidad";
            this.colCantidadDetPedido.Frozen = true;
            this.colCantidadDetPedido.HeaderText = "Cantidad";
            this.colCantidadDetPedido.Name = "colCantidadDetPedido";
            this.colCantidadDetPedido.ReadOnly = true;
            // 
            // colPUDetPedido
            // 
            this.colPUDetPedido.DataPropertyName = "proPre";
            this.colPUDetPedido.Frozen = true;
            this.colPUDetPedido.HeaderText = "P.U.";
            this.colPUDetPedido.Name = "colPUDetPedido";
            this.colPUDetPedido.ReadOnly = true;
            // 
            // colDescuentoDetPedido
            // 
            this.colDescuentoDetPedido.DataPropertyName = "Desc";
            this.colDescuentoDetPedido.Frozen = true;
            this.colDescuentoDetPedido.HeaderText = "Desc.";
            this.colDescuentoDetPedido.Name = "colDescuentoDetPedido";
            this.colDescuentoDetPedido.ReadOnly = true;
            // 
            // colSubTDetPedido
            // 
            this.colSubTDetPedido.DataPropertyName = "Subtotal";
            this.colSubTDetPedido.Frozen = true;
            this.colSubTDetPedido.HeaderText = "Sub. Total";
            this.colSubTDetPedido.Name = "colSubTDetPedido";
            this.colSubTDetPedido.ReadOnly = true;
            // 
            // lblDetPedido
            // 
            this.lblDetPedido.AutoSize = true;
            this.lblDetPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetPedido.Location = new System.Drawing.Point(12, 177);
            this.lblDetPedido.Name = "lblDetPedido";
            this.lblDetPedido.Size = new System.Drawing.Size(126, 20);
            this.lblDetPedido.TabIndex = 14;
            this.lblDetPedido.Text = "Detalle Pedido";
            // 
            // lblTotalAddPedido
            // 
            this.lblTotalAddPedido.AutoSize = true;
            this.lblTotalAddPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAddPedido.Location = new System.Drawing.Point(545, 382);
            this.lblTotalAddPedido.Name = "lblTotalAddPedido";
            this.lblTotalAddPedido.Size = new System.Drawing.Size(83, 24);
            this.lblTotalAddPedido.TabIndex = 23;
            this.lblTotalAddPedido.Text = "TOTAL:";
            // 
            // txtTotalAddPedido
            // 
            this.txtTotalAddPedido.Enabled = false;
            this.txtTotalAddPedido.Location = new System.Drawing.Point(665, 385);
            this.txtTotalAddPedido.Name = "txtTotalAddPedido";
            this.txtTotalAddPedido.Size = new System.Drawing.Size(86, 20);
            this.txtTotalAddPedido.TabIndex = 24;
            // 
            // btnBuscarDireAddPedido
            // 
            this.btnBuscarDireAddPedido.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBuscarDireAddPedido.Location = new System.Drawing.Point(351, 52);
            this.btnBuscarDireAddPedido.Name = "btnBuscarDireAddPedido";
            this.btnBuscarDireAddPedido.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarDireAddPedido.TabIndex = 22;
            this.btnBuscarDireAddPedido.UseVisualStyleBackColor = true;
            this.btnBuscarDireAddPedido.Click += new System.EventHandler(this.btnBuscarDireAddPedido_Click);
            // 
            // btnBuscarTransAddPedido
            // 
            this.btnBuscarTransAddPedido.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBuscarTransAddPedido.Location = new System.Drawing.Point(351, 80);
            this.btnBuscarTransAddPedido.Name = "btnBuscarTransAddPedido";
            this.btnBuscarTransAddPedido.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarTransAddPedido.TabIndex = 21;
            this.btnBuscarTransAddPedido.UseVisualStyleBackColor = true;
            this.btnBuscarTransAddPedido.Click += new System.EventHandler(this.btnBuscarTransAddPedido_Click);
            // 
            // btnBuscarCliAddPedido
            // 
            this.btnBuscarCliAddPedido.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBuscarCliAddPedido.Location = new System.Drawing.Point(351, 25);
            this.btnBuscarCliAddPedido.Name = "btnBuscarCliAddPedido";
            this.btnBuscarCliAddPedido.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarCliAddPedido.TabIndex = 20;
            this.btnBuscarCliAddPedido.UseVisualStyleBackColor = true;
            this.btnBuscarCliAddPedido.Click += new System.EventHandler(this.btnBuscarCliAddPedido_Click);
            // 
            // btnAceptarAddPedido
            // 
            this.btnAceptarAddPedido.Image = global::Formularios.Properties.Resources.check;
            this.btnAceptarAddPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarAddPedido.Location = new System.Drawing.Point(712, 416);
            this.btnAceptarAddPedido.Name = "btnAceptarAddPedido";
            this.btnAceptarAddPedido.Size = new System.Drawing.Size(78, 32);
            this.btnAceptarAddPedido.TabIndex = 16;
            this.btnAceptarAddPedido.Text = "Registrar";
            this.btnAceptarAddPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarAddPedido.UseVisualStyleBackColor = true;
            this.btnAceptarAddPedido.Click += new System.EventHandler(this.btnAceptarAddPedido_Click);
            // 
            // btnCancelarAddPedido
            // 
            this.btnCancelarAddPedido.Image = global::Formularios.Properties.Resources.cross;
            this.btnCancelarAddPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarAddPedido.Location = new System.Drawing.Point(616, 416);
            this.btnCancelarAddPedido.Name = "btnCancelarAddPedido";
            this.btnCancelarAddPedido.Size = new System.Drawing.Size(80, 32);
            this.btnCancelarAddPedido.TabIndex = 15;
            this.btnCancelarAddPedido.Text = "Cancelar";
            this.btnCancelarAddPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarAddPedido.UseVisualStyleBackColor = true;
            this.btnCancelarAddPedido.Click += new System.EventHandler(this.btnCancelarAddPedido_Click);
            // 
            // btnAddDetPedido
            // 
            this.btnAddDetPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetPedido.Image = global::Formularios.Properties.Resources.plus__1_;
            this.btnAddDetPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDetPedido.Location = new System.Drawing.Point(705, 160);
            this.btnAddDetPedido.Name = "btnAddDetPedido";
            this.btnAddDetPedido.Size = new System.Drawing.Size(85, 37);
            this.btnAddDetPedido.TabIndex = 13;
            this.btnAddDetPedido.Text = "Agregar producto";
            this.btnAddDetPedido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAddDetPedido.UseVisualStyleBackColor = true;
            this.btnAddDetPedido.Click += new System.EventHandler(this.btnAddDetPedido_Click);
            // 
            // btnModDetPedido
            // 
            this.btnModDetPedido.Image = global::Formularios.Properties.Resources.exchange;
            this.btnModDetPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModDetPedido.Location = new System.Drawing.Point(609, 160);
            this.btnModDetPedido.Name = "btnModDetPedido";
            this.btnModDetPedido.Size = new System.Drawing.Size(85, 37);
            this.btnModDetPedido.TabIndex = 12;
            this.btnModDetPedido.Text = "&Modificar";
            this.btnModDetPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModDetPedido.UseVisualStyleBackColor = true;
            this.btnModDetPedido.Click += new System.EventHandler(this.btnModDetPedido_Click);
            // 
            // btnElimDetPedido
            // 
            this.btnElimDetPedido.Image = global::Formularios.Properties.Resources.package;
            this.btnElimDetPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimDetPedido.Location = new System.Drawing.Point(512, 160);
            this.btnElimDetPedido.Name = "btnElimDetPedido";
            this.btnElimDetPedido.Size = new System.Drawing.Size(85, 37);
            this.btnElimDetPedido.TabIndex = 11;
            this.btnElimDetPedido.Text = "Eliminar producto";
            this.btnElimDetPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElimDetPedido.UseVisualStyleBackColor = true;
            this.btnElimDetPedido.Click += new System.EventHandler(this.btnElimDetPedido_Click);
            // 
            // lblPedidoAddpedido
            // 
            this.lblPedidoAddpedido.AutoSize = true;
            this.lblPedidoAddpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoAddpedido.Location = new System.Drawing.Point(12, 9);
            this.lblPedidoAddpedido.Name = "lblPedidoAddpedido";
            this.lblPedidoAddpedido.Size = new System.Drawing.Size(69, 20);
            this.lblPedidoAddpedido.TabIndex = 49;
            this.lblPedidoAddpedido.Text = "Pedido:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(117, 106);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(227, 20);
            this.txtVendedor.TabIndex = 50;
            // 
            // lblSolesSubTotal
            // 
            this.lblSolesSubTotal.AutoSize = true;
            this.lblSolesSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolesSubTotal.Location = new System.Drawing.Point(634, 389);
            this.lblSolesSubTotal.Name = "lblSolesSubTotal";
            this.lblSolesSubTotal.Size = new System.Drawing.Size(25, 13);
            this.lblSolesSubTotal.TabIndex = 51;
            this.lblSolesSubTotal.Text = "S/.";
            // 
            // cbEstadoPedido
            // 
            this.cbEstadoPedido.FormattingEnabled = true;
            this.cbEstadoPedido.Items.AddRange(new object[] {
            "pendiente",
            "en_proceso",
            "verificado"});
            this.cbEstadoPedido.Location = new System.Drawing.Point(606, 124);
            this.cbEstadoPedido.Name = "cbEstadoPedido";
            this.cbEstadoPedido.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoPedido.TabIndex = 52;
            this.cbEstadoPedido.SelectedIndexChanged += new System.EventHandler(this.cbEstadoPedido_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(509, 127);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(91, 13);
            this.lblEstado.TabIndex = 53;
            this.lblEstado.Text = "Etapa del Pedido:";
            // 
            // frmAddPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 460);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbEstadoPedido);
            this.Controls.Add(this.lblSolesSubTotal);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lblPedidoAddpedido);
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
            this.Controls.Add(this.dgvAddPedido);
            this.Controls.Add(this.txtTransAddPedido);
            this.Controls.Add(this.txtDireccAddPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDirecAddPedido);
            this.Controls.Add(this.txtClienteAddPedido);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddPedido";
            this.Text = "Añadir Pedido";
            this.Load += new System.EventHandler(this.frmAddPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddPedido)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAddPedido;
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
        private System.Windows.Forms.Label lblPedidoAddpedido;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPUDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuentoDetPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTDetPedido;
        private System.Windows.Forms.Label lblSolesSubTotal;
        private System.Windows.Forms.ComboBox cbEstadoPedido;
        private System.Windows.Forms.Label lblEstado;
    }
}