namespace Formularios
{
    partial class GestionTransportistas
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
            this.dgvTransportistas = new System.Windows.Forms.DataGridView();
            this.colRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBusquedaTransportista = new System.Windows.Forms.Button();
            this.rbtnBusqRuc = new System.Windows.Forms.RadioButton();
            this.txtBusqTransportista = new System.Windows.Forms.TextBox();
            this.btnElimTransportista = new System.Windows.Forms.Button();
            this.btnModTransportista = new System.Windows.Forms.Button();
            this.btnagregarTransp = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransportistas
            // 
            this.dgvTransportistas.AllowUserToOrderColumns = true;
            this.dgvTransportistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRUC,
            this.colNombre,
            this.colTelef,
            this.colEmail});
            this.dgvTransportistas.Location = new System.Drawing.Point(38, 104);
            this.dgvTransportistas.Name = "dgvTransportistas";
            this.dgvTransportistas.Size = new System.Drawing.Size(699, 217);
            this.dgvTransportistas.TabIndex = 27;
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
            // btnBusquedaTransportista
            // 
            this.btnBusquedaTransportista.Location = new System.Drawing.Point(670, 42);
            this.btnBusquedaTransportista.Name = "btnBusquedaTransportista";
            this.btnBusquedaTransportista.Size = new System.Drawing.Size(67, 26);
            this.btnBusquedaTransportista.TabIndex = 26;
            this.btnBusquedaTransportista.Text = "Buscar...";
            this.btnBusquedaTransportista.UseVisualStyleBackColor = true;
            // 
            // rbtnBusqRuc
            // 
            this.rbtnBusqRuc.AutoSize = true;
            this.rbtnBusqRuc.Location = new System.Drawing.Point(452, 23);
            this.rbtnBusqRuc.Name = "rbtnBusqRuc";
            this.rbtnBusqRuc.Size = new System.Drawing.Size(67, 17);
            this.rbtnBusqRuc.TabIndex = 25;
            this.rbtnBusqRuc.TabStop = true;
            this.rbtnBusqRuc.Text = "Por RUC";
            this.rbtnBusqRuc.UseVisualStyleBackColor = true;
            // 
            // txtBusqTransportista
            // 
            this.txtBusqTransportista.Location = new System.Drawing.Point(452, 46);
            this.txtBusqTransportista.Name = "txtBusqTransportista";
            this.txtBusqTransportista.Size = new System.Drawing.Size(212, 20);
            this.txtBusqTransportista.TabIndex = 24;
            // 
            // btnElimTransportista
            // 
            this.btnElimTransportista.Location = new System.Drawing.Point(307, 30);
            this.btnElimTransportista.Name = "btnElimTransportista";
            this.btnElimTransportista.Size = new System.Drawing.Size(114, 50);
            this.btnElimTransportista.TabIndex = 23;
            this.btnElimTransportista.Text = "Eliminar";
            this.btnElimTransportista.UseVisualStyleBackColor = true;
            // 
            // btnModTransportista
            // 
            this.btnModTransportista.Location = new System.Drawing.Point(173, 30);
            this.btnModTransportista.Name = "btnModTransportista";
            this.btnModTransportista.Size = new System.Drawing.Size(114, 50);
            this.btnModTransportista.TabIndex = 22;
            this.btnModTransportista.Text = "Modificar";
            this.btnModTransportista.UseVisualStyleBackColor = true;
            // 
            // btnagregarTransp
            // 
            this.btnagregarTransp.Location = new System.Drawing.Point(38, 30);
            this.btnagregarTransp.Name = "btnagregarTransp";
            this.btnagregarTransp.Size = new System.Drawing.Size(114, 50);
            this.btnagregarTransp.TabIndex = 21;
            this.btnagregarTransp.Text = "Agregar";
            this.btnagregarTransp.UseVisualStyleBackColor = true;
            this.btnagregarTransp.Click += new System.EventHandler(this.btnagregarTransp_Click);
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(332, 344);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(113, 31);
            this.btnCancelarPedido.TabIndex = 28;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // GestionTransportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 387);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.dgvTransportistas);
            this.Controls.Add(this.btnBusquedaTransportista);
            this.Controls.Add(this.rbtnBusqRuc);
            this.Controls.Add(this.txtBusqTransportista);
            this.Controls.Add(this.btnElimTransportista);
            this.Controls.Add(this.btnModTransportista);
            this.Controls.Add(this.btnagregarTransp);
            this.Name = "GestionTransportistas";
            this.Text = "GestionTransportistas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransportistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Button btnBusquedaTransportista;
        private System.Windows.Forms.RadioButton rbtnBusqRuc;
        private System.Windows.Forms.TextBox txtBusqTransportista;
        private System.Windows.Forms.Button btnElimTransportista;
        private System.Windows.Forms.Button btnModTransportista;
        private System.Windows.Forms.Button btnagregarTransp;
        private System.Windows.Forms.Button btnCancelarPedido;
    }
}