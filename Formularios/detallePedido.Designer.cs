namespace Formularios
{
    partial class detallePedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detallePedido));
            this.rbtnID = new System.Windows.Forms.RadioButton();
            this.rbtnDescp = new System.Windows.Forms.RadioButton();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colIDDetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescpDetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptarAddDetPedido = new System.Windows.Forms.Button();
            this.btnCancelarAddDetPedido = new System.Windows.Forms.Button();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.numDesc = new System.Windows.Forms.NumericUpDown();
            this.lblDesct = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnID
            // 
            this.rbtnID.AutoSize = true;
            this.rbtnID.Location = new System.Drawing.Point(25, 13);
            this.rbtnID.Name = "rbtnID";
            this.rbtnID.Size = new System.Drawing.Size(36, 17);
            this.rbtnID.TabIndex = 0;
            this.rbtnID.TabStop = true;
            this.rbtnID.Text = "ID";
            this.rbtnID.UseVisualStyleBackColor = true;
            // 
            // rbtnDescp
            // 
            this.rbtnDescp.AutoSize = true;
            this.rbtnDescp.Location = new System.Drawing.Point(67, 12);
            this.rbtnDescp.Name = "rbtnDescp";
            this.rbtnDescp.Size = new System.Drawing.Size(81, 17);
            this.rbtnDescp.TabIndex = 1;
            this.rbtnDescp.TabStop = true;
            this.rbtnDescp.Text = "Descripcion";
            this.rbtnDescp.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(25, 37);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(123, 20);
            this.txtBuscarProducto.TabIndex = 2;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBuscar.Location = new System.Drawing.Point(154, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 24);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(137, 232);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descuento:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDDetallePedido,
            this.colNombre,
            this.colDescpDetallePedido,
            this.colUnidMedida,
            this.colPrecio});
            this.dgvProductos.Location = new System.Drawing.Point(12, 64);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(562, 150);
            this.dgvProductos.TabIndex = 8;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colIDDetallePedido
            // 
            this.colIDDetallePedido.DataPropertyName = "Codigo";
            this.colIDDetallePedido.HeaderText = "Codigo";
            this.colIDDetallePedido.Name = "colIDDetallePedido";
            this.colIDDetallePedido.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colDescpDetallePedido
            // 
            this.colDescpDetallePedido.DataPropertyName = "Descripcion";
            this.colDescpDetallePedido.HeaderText = "Descripcion";
            this.colDescpDetallePedido.Name = "colDescpDetallePedido";
            this.colDescpDetallePedido.ReadOnly = true;
            // 
            // colUnidMedida
            // 
            this.colUnidMedida.DataPropertyName = "Um";
            this.colUnidMedida.HeaderText = "U.M.";
            this.colUnidMedida.Name = "colUnidMedida";
            this.colUnidMedida.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "Precio";
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // btnAceptarAddDetPedido
            // 
            this.btnAceptarAddDetPedido.Image = global::Formularios.Properties.Resources.check;
            this.btnAceptarAddDetPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarAddDetPedido.Location = new System.Drawing.Point(381, 239);
            this.btnAceptarAddDetPedido.Name = "btnAceptarAddDetPedido";
            this.btnAceptarAddDetPedido.Size = new System.Drawing.Size(78, 32);
            this.btnAceptarAddDetPedido.TabIndex = 18;
            this.btnAceptarAddDetPedido.Text = "Aceptar";
            this.btnAceptarAddDetPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarAddDetPedido.UseVisualStyleBackColor = true;
            this.btnAceptarAddDetPedido.Click += new System.EventHandler(this.btnAceptarAddDetPedido_Click);
            // 
            // btnCancelarAddDetPedido
            // 
            this.btnCancelarAddDetPedido.Image = global::Formularios.Properties.Resources.cross;
            this.btnCancelarAddDetPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarAddDetPedido.Location = new System.Drawing.Point(284, 239);
            this.btnCancelarAddDetPedido.Name = "btnCancelarAddDetPedido";
            this.btnCancelarAddDetPedido.Size = new System.Drawing.Size(80, 32);
            this.btnCancelarAddDetPedido.TabIndex = 17;
            this.btnCancelarAddDetPedido.Text = "Cancelar";
            this.btnCancelarAddDetPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarAddDetPedido.UseVisualStyleBackColor = true;
            this.btnCancelarAddDetPedido.Click += new System.EventHandler(this.btnCancelarAddDetPedido_Click);
            // 
            // numCant
            // 
            this.numCant.Location = new System.Drawing.Point(199, 230);
            this.numCant.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(35, 20);
            this.numCant.TabIndex = 19;
            this.numCant.ValueChanged += new System.EventHandler(this.numCant_ValueChanged);
            // 
            // numDesc
            // 
            this.numDesc.Location = new System.Drawing.Point(199, 256);
            this.numDesc.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numDesc.Name = "numDesc";
            this.numDesc.Size = new System.Drawing.Size(35, 20);
            this.numDesc.TabIndex = 20;
            this.numDesc.ValueChanged += new System.EventHandler(this.numDesc_ValueChanged);
            // 
            // lblDesct
            // 
            this.lblDesct.AutoSize = true;
            this.lblDesct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesct.Location = new System.Drawing.Point(256, 258);
            this.lblDesct.Name = "lblDesct";
            this.lblDesct.Size = new System.Drawing.Size(19, 15);
            this.lblDesct.TabIndex = 21;
            this.lblDesct.Text = "%";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(199, 230);
            this.txtCantidad.MaxLength = 6;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(51, 20);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(199, 256);
            this.txtDescuento.MaxLength = 2;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(51, 20);
            this.txtDescuento.TabIndex = 23;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // detallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 292);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblDesct);
            this.Controls.Add(this.numDesc);
            this.Controls.Add(this.numCant);
            this.Controls.Add(this.btnAceptarAddDetPedido);
            this.Controls.Add(this.btnCancelarAddDetPedido);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.rbtnDescp);
            this.Controls.Add(this.rbtnID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "detallePedido";
            this.Text = "x";
            this.Load += new System.EventHandler(this.detallePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnID;
        private System.Windows.Forms.RadioButton rbtnDescp;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAceptarAddDetPedido;
        private System.Windows.Forms.Button btnCancelarAddDetPedido;
        private System.Windows.Forms.NumericUpDown numCant;
        private System.Windows.Forms.NumericUpDown numDesc;
        private System.Windows.Forms.Label lblDesct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDDetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescpDetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescuento;
    }
}