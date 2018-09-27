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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dudCantidadPro = new System.Windows.Forms.DomainUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dudDescuento = new System.Windows.Forms.DomainUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIDDetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescpDetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockDetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptarAddDetPedido = new System.Windows.Forms.Button();
            this.btnCancelarAddDetPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::Formularios.Properties.Resources._015_search1;
            this.button1.Location = new System.Drawing.Point(154, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 24);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dudCantidadPro
            // 
            this.dudCantidadPro.Location = new System.Drawing.Point(97, 67);
            this.dudCantidadPro.Name = "dudCantidadPro";
            this.dudCantidadPro.Size = new System.Drawing.Size(32, 20);
            this.dudCantidadPro.TabIndex = 4;
            this.dudCantidadPro.Text = "0";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(26, 69);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descuento:";
            // 
            // dudDescuento
            // 
            this.dudDescuento.Location = new System.Drawing.Point(97, 93);
            this.dudDescuento.Name = "dudDescuento";
            this.dudDescuento.Size = new System.Drawing.Size(32, 20);
            this.dudDescuento.TabIndex = 7;
            this.dudDescuento.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDDetallePedido,
            this.colDescpDetallePedido,
            this.colStockDetallePedido});
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // colIDDetallePedido
            // 
            this.colIDDetallePedido.HeaderText = "ID";
            this.colIDDetallePedido.Name = "colIDDetallePedido";
            this.colIDDetallePedido.ReadOnly = true;
            // 
            // colDescpDetallePedido
            // 
            this.colDescpDetallePedido.HeaderText = "Descripcion";
            this.colDescpDetallePedido.Name = "colDescpDetallePedido";
            this.colDescpDetallePedido.ReadOnly = true;
            // 
            // colStockDetallePedido
            // 
            this.colStockDetallePedido.HeaderText = "Stock";
            this.colStockDetallePedido.Name = "colStockDetallePedido";
            this.colStockDetallePedido.ReadOnly = true;
            // 
            // btnAceptarAddDetPedido
            // 
            this.btnAceptarAddDetPedido.Image = global::Formularios.Properties.Resources.check;
            this.btnAceptarAddDetPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarAddDetPedido.Location = new System.Drawing.Point(278, 294);
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
            this.btnCancelarAddDetPedido.Location = new System.Drawing.Point(182, 294);
            this.btnCancelarAddDetPedido.Name = "btnCancelarAddDetPedido";
            this.btnCancelarAddDetPedido.Size = new System.Drawing.Size(80, 32);
            this.btnCancelarAddDetPedido.TabIndex = 17;
            this.btnCancelarAddDetPedido.Text = "Cancelar";
            this.btnCancelarAddDetPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarAddDetPedido.UseVisualStyleBackColor = true;
            this.btnCancelarAddDetPedido.Click += new System.EventHandler(this.btnCancelarAddDetPedido_Click);
            // 
            // detallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 338);
            this.Controls.Add(this.btnAceptarAddDetPedido);
            this.Controls.Add(this.btnCancelarAddDetPedido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dudDescuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dudCantidadPro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnDescp);
            this.Controls.Add(this.rbtnID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "detallePedido";
            this.Text = "Agregar Detalle Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnID;
        private System.Windows.Forms.RadioButton rbtnDescp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown dudCantidadPro;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown dudDescuento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDDetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescpDetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockDetallePedido;
        private System.Windows.Forms.Button btnAceptarAddDetPedido;
        private System.Windows.Forms.Button btnCancelarAddDetPedido;
    }
}