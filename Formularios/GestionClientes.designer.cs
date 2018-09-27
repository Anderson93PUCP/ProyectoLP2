namespace Formularios
{
    partial class GestionClientes
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
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnBusquedaPedido = new System.Windows.Forms.Button();
            this.rbtnBusqRuc = new System.Windows.Forms.RadioButton();
            this.txtBusqPedido = new System.Windows.Forms.TextBox();
            this.btnElimCliente = new System.Windows.Forms.Button();
            this.btnModCliente = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(348, 391);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(113, 31);
            this.btnCancelarPedido.TabIndex = 19;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnBusquedaPedido
            // 
            this.btnBusquedaPedido.Location = new System.Drawing.Point(677, 48);
            this.btnBusquedaPedido.Name = "btnBusquedaPedido";
            this.btnBusquedaPedido.Size = new System.Drawing.Size(67, 26);
            this.btnBusquedaPedido.TabIndex = 17;
            this.btnBusquedaPedido.Text = "Buscar...";
            this.btnBusquedaPedido.UseVisualStyleBackColor = true;
            // 
            // rbtnBusqRuc
            // 
            this.rbtnBusqRuc.AutoSize = true;
            this.rbtnBusqRuc.Location = new System.Drawing.Point(459, 29);
            this.rbtnBusqRuc.Name = "rbtnBusqRuc";
            this.rbtnBusqRuc.Size = new System.Drawing.Size(67, 17);
            this.rbtnBusqRuc.TabIndex = 16;
            this.rbtnBusqRuc.TabStop = true;
            this.rbtnBusqRuc.Text = "Por RUC";
            this.rbtnBusqRuc.UseVisualStyleBackColor = true;
            // 
            // txtBusqPedido
            // 
            this.txtBusqPedido.Location = new System.Drawing.Point(459, 52);
            this.txtBusqPedido.Name = "txtBusqPedido";
            this.txtBusqPedido.Size = new System.Drawing.Size(212, 20);
            this.txtBusqPedido.TabIndex = 13;
            // 
            // btnElimCliente
            // 
            this.btnElimCliente.Location = new System.Drawing.Point(314, 36);
            this.btnElimCliente.Name = "btnElimCliente";
            this.btnElimCliente.Size = new System.Drawing.Size(114, 50);
            this.btnElimCliente.TabIndex = 12;
            this.btnElimCliente.Text = "Eliminar";
            this.btnElimCliente.UseVisualStyleBackColor = true;
            // 
            // btnModCliente
            // 
            this.btnModCliente.Location = new System.Drawing.Point(180, 36);
            this.btnModCliente.Name = "btnModCliente";
            this.btnModCliente.Size = new System.Drawing.Size(114, 50);
            this.btnModCliente.TabIndex = 11;
            this.btnModCliente.Text = "Modificar";
            this.btnModCliente.UseVisualStyleBackColor = true;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(45, 36);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(114, 50);
            this.btnAddCliente.TabIndex = 10;
            this.btnAddCliente.Text = "Agregar";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRUC,
            this.colNombre,
            this.colTelef,
            this.colEmail});
            this.dgvClientes.Location = new System.Drawing.Point(45, 110);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(699, 217);
            this.dgvClientes.TabIndex = 20;
            // 
            // colRUC
            // 
            this.colRUC.HeaderText = "R.U.C";
            this.colRUC.Name = "colRUC";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Razon Social";
            this.colNombre.Name = "colNombre";
            // 
            // colTelef
            // 
            this.colTelef.HeaderText = "Telefono";
            this.colTelef.Name = "colTelef";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnBusquedaPedido);
            this.Controls.Add(this.rbtnBusqRuc);
            this.Controls.Add(this.txtBusqPedido);
            this.Controls.Add(this.btnElimCliente);
            this.Controls.Add(this.btnModCliente);
            this.Controls.Add(this.btnAddCliente);
            this.Name = "GestionClientes";
            this.Text = "GestionClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnBusquedaPedido;
        private System.Windows.Forms.RadioButton rbtnBusqRuc;
        private System.Windows.Forms.TextBox txtBusqPedido;
        private System.Windows.Forms.Button btnElimCliente;
        private System.Windows.Forms.Button btnModCliente;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}