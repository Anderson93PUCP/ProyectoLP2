namespace Formularios
{
    partial class verPedido
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaRVerPedido = new System.Windows.Forms.TextBox();
            this.txtClienteVerPedido = new System.Windows.Forms.TextBox();
            this.txtDireVerPedido = new System.Windows.Forms.TextBox();
            this.txtVendVerPedido = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.colItemVerPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdVerPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcionVerPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantVerPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPUVerPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescVerPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTVerPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Registro:";
            // 
            // txtFechaRVerPedido
            // 
            this.txtFechaRVerPedido.Enabled = false;
            this.txtFechaRVerPedido.Location = new System.Drawing.Point(118, 92);
            this.txtFechaRVerPedido.Name = "txtFechaRVerPedido";
            this.txtFechaRVerPedido.Size = new System.Drawing.Size(123, 20);
            this.txtFechaRVerPedido.TabIndex = 4;
            // 
            // txtClienteVerPedido
            // 
            this.txtClienteVerPedido.Enabled = false;
            this.txtClienteVerPedido.Location = new System.Drawing.Point(118, 19);
            this.txtClienteVerPedido.Name = "txtClienteVerPedido";
            this.txtClienteVerPedido.Size = new System.Drawing.Size(123, 20);
            this.txtClienteVerPedido.TabIndex = 5;
            // 
            // txtDireVerPedido
            // 
            this.txtDireVerPedido.Enabled = false;
            this.txtDireVerPedido.Location = new System.Drawing.Point(118, 44);
            this.txtDireVerPedido.Name = "txtDireVerPedido";
            this.txtDireVerPedido.Size = new System.Drawing.Size(123, 20);
            this.txtDireVerPedido.TabIndex = 6;
            // 
            // txtVendVerPedido
            // 
            this.txtVendVerPedido.Enabled = false;
            this.txtVendVerPedido.Location = new System.Drawing.Point(118, 68);
            this.txtVendVerPedido.Name = "txtVendVerPedido";
            this.txtVendVerPedido.Size = new System.Drawing.Size(123, 20);
            this.txtVendVerPedido.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemVerPedido,
            this.colProdVerPedido,
            this.colDescripcionVerPedido,
            this.colCantVerPedido,
            this.colPUVerPedido,
            this.colDescVerPedido,
            this.colSubTVerPedido});
            this.dataGridView1.Location = new System.Drawing.Point(33, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 147);
            this.dataGridView1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Detalle Pedido:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // colItemVerPedido
            // 
            this.colItemVerPedido.HeaderText = "Item";
            this.colItemVerPedido.Name = "colItemVerPedido";
            this.colItemVerPedido.ReadOnly = true;
            this.colItemVerPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemVerPedido.Width = 30;
            // 
            // colProdVerPedido
            // 
            this.colProdVerPedido.HeaderText = "Producto";
            this.colProdVerPedido.Name = "colProdVerPedido";
            this.colProdVerPedido.ReadOnly = true;
            this.colProdVerPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProdVerPedido.Width = 75;
            // 
            // colDescripcionVerPedido
            // 
            this.colDescripcionVerPedido.HeaderText = "Descripcion";
            this.colDescripcionVerPedido.Name = "colDescripcionVerPedido";
            this.colDescripcionVerPedido.ReadOnly = true;
            this.colDescripcionVerPedido.Width = 200;
            // 
            // colCantVerPedido
            // 
            this.colCantVerPedido.HeaderText = "Cant.";
            this.colCantVerPedido.Name = "colCantVerPedido";
            this.colCantVerPedido.ReadOnly = true;
            this.colCantVerPedido.Width = 37;
            // 
            // colPUVerPedido
            // 
            this.colPUVerPedido.HeaderText = "P.U.";
            this.colPUVerPedido.Name = "colPUVerPedido";
            this.colPUVerPedido.ReadOnly = true;
            this.colPUVerPedido.Width = 30;
            // 
            // colDescVerPedido
            // 
            this.colDescVerPedido.HeaderText = "Desc.";
            this.colDescVerPedido.Name = "colDescVerPedido";
            this.colDescVerPedido.ReadOnly = true;
            this.colDescVerPedido.Width = 38;
            // 
            // colSubTVerPedido
            // 
            this.colSubTVerPedido.HeaderText = "Subtotal";
            this.colSubTVerPedido.Name = "colSubTVerPedido";
            this.colSubTVerPedido.ReadOnly = true;
            this.colSubTVerPedido.Width = 75;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Formularios.Properties.Resources._012_printer_1;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(464, 105);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(69, 28);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(464, 305);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // verPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 335);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtVendVerPedido);
            this.Controls.Add(this.txtDireVerPedido);
            this.Controls.Add(this.txtClienteVerPedido);
            this.Controls.Add(this.txtFechaRVerPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "verPedido";
            this.Text = "verPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaRVerPedido;
        private System.Windows.Forms.TextBox txtClienteVerPedido;
        private System.Windows.Forms.TextBox txtDireVerPedido;
        private System.Windows.Forms.TextBox txtVendVerPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemVerPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdVerPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionVerPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantVerPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPUVerPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescVerPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTVerPedido;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAceptar;
    }
}