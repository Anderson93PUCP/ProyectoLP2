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
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.rbtnBusqRuc = new System.Windows.Forms.RadioButton();
            this.txtBusqPedido = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnBusquedaPedido = new System.Windows.Forms.Button();
            this.btnElimCliente = new System.Windows.Forms.Button();
            this.btnModCliente = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransportistas
            // 
            this.dgvTransportistas.AllowUserToOrderColumns = true;
            this.dgvTransportistas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvTransportistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransportistas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTransportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colRUC,
            this.colNombre,
            this.colTelef,
            this.colEmail});
            this.dgvTransportistas.Location = new System.Drawing.Point(38, 104);
            this.dgvTransportistas.Name = "dgvTransportistas";
            this.dgvTransportistas.Size = new System.Drawing.Size(699, 217);
            this.dgvTransportistas.TabIndex = 27;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(332, 344);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(113, 31);
            this.btnCancelarPedido.TabIndex = 28;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Visible = false;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // rbtnBusqRuc
            // 
            this.rbtnBusqRuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnBusqRuc.AutoSize = true;
            this.rbtnBusqRuc.Location = new System.Drawing.Point(452, 16);
            this.rbtnBusqRuc.Name = "rbtnBusqRuc";
            this.rbtnBusqRuc.Size = new System.Drawing.Size(67, 17);
            this.rbtnBusqRuc.TabIndex = 33;
            this.rbtnBusqRuc.TabStop = true;
            this.rbtnBusqRuc.Text = "Por RUC";
            this.rbtnBusqRuc.UseVisualStyleBackColor = true;
            // 
            // txtBusqPedido
            // 
            this.txtBusqPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqPedido.Location = new System.Drawing.Point(452, 37);
            this.txtBusqPedido.Name = "txtBusqPedido";
            this.txtBusqPedido.Size = new System.Drawing.Size(212, 20);
            this.txtBusqPedido.TabIndex = 32;
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Image = global::Formularios.Properties.Resources.file;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(670, 65);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(67, 31);
            this.btnVer.TabIndex = 35;
            this.btnVer.Text = "   Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Visible = false;
            // 
            // btnBusquedaPedido
            // 
            this.btnBusquedaPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBusquedaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaPedido.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBusquedaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaPedido.Location = new System.Drawing.Point(670, 33);
            this.btnBusquedaPedido.Name = "btnBusquedaPedido";
            this.btnBusquedaPedido.Size = new System.Drawing.Size(67, 26);
            this.btnBusquedaPedido.TabIndex = 34;
            this.btnBusquedaPedido.Text = "Buscar";
            this.btnBusquedaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusquedaPedido.UseVisualStyleBackColor = true;
            // 
            // btnElimCliente
            // 
            this.btnElimCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElimCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnElimCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimCliente.Image = global::Formularios.Properties.Resources._008_document;
            this.btnElimCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimCliente.Location = new System.Drawing.Point(307, 33);
            this.btnElimCliente.Name = "btnElimCliente";
            this.btnElimCliente.Size = new System.Drawing.Size(114, 50);
            this.btnElimCliente.TabIndex = 31;
            this.btnElimCliente.Text = "Eliminar";
            this.btnElimCliente.UseVisualStyleBackColor = false;
            // 
            // btnModCliente
            // 
            this.btnModCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnModCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModCliente.Image = global::Formularios.Properties.Resources.file__3_;
            this.btnModCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModCliente.Location = new System.Drawing.Point(173, 33);
            this.btnModCliente.Name = "btnModCliente";
            this.btnModCliente.Size = new System.Drawing.Size(114, 50);
            this.btnModCliente.TabIndex = 30;
            this.btnModCliente.Text = "Modificar";
            this.btnModCliente.UseVisualStyleBackColor = false;
            this.btnModCliente.Click += new System.EventHandler(this.btnModCliente_Click);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.Image = global::Formularios.Properties.Resources.plus__1_;
            this.btnAddCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCliente.Location = new System.Drawing.Point(38, 33);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(114, 50);
            this.btnAddCliente.TabIndex = 29;
            this.btnAddCliente.Text = "Agregar";
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colRUC
            // 
            this.colRUC.DataPropertyName = "Ruc";
            this.colRUC.HeaderText = "R.U.C";
            this.colRUC.Name = "colRUC";
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Razon Social";
            this.colNombre.Name = "colNombre";
            // 
            // colTelef
            // 
            this.colTelef.DataPropertyName = "Telefono";
            this.colTelef.HeaderText = "Telefono";
            this.colTelef.Name = "colTelef";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // GestionTransportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 387);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnBusquedaPedido);
            this.Controls.Add(this.rbtnBusqRuc);
            this.Controls.Add(this.txtBusqPedido);
            this.Controls.Add(this.btnElimCliente);
            this.Controls.Add(this.btnModCliente);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.dgvTransportistas);
            this.Name = "GestionTransportistas";
            this.Text = "GestionTransportistas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransportistas;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnBusquedaPedido;
        private System.Windows.Forms.RadioButton rbtnBusqRuc;
        private System.Windows.Forms.TextBox txtBusqPedido;
        private System.Windows.Forms.Button btnElimCliente;
        private System.Windows.Forms.Button btnModCliente;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}