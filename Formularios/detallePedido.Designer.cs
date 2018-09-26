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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(154, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar..";
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
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(281, 303);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(200, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // detallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 338);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dudDescuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dudCantidadPro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnDescp);
            this.Controls.Add(this.rbtnID);
            this.Name = "detallePedido";
            this.Text = "Detalle Pedido";
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
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}