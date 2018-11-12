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
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.rbtnBusqRuc = new System.Windows.Forms.RadioButton();
            this.txtBusqTrans = new System.Windows.Forms.TextBox();
            this.btnBusquedaTrans = new System.Windows.Forms.Button();
            this.btnElimCliente = new System.Windows.Forms.Button();
            this.btnModCliente = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportistas)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.rbtnBusqRuc.Location = new System.Drawing.Point(16, 25);
            this.rbtnBusqRuc.Name = "rbtnBusqRuc";
            this.rbtnBusqRuc.Size = new System.Drawing.Size(67, 17);
            this.rbtnBusqRuc.TabIndex = 33;
            this.rbtnBusqRuc.TabStop = true;
            this.rbtnBusqRuc.Text = "Por RUC";
            this.rbtnBusqRuc.UseVisualStyleBackColor = true;
            this.rbtnBusqRuc.CheckedChanged += new System.EventHandler(this.rbtnBusqRuc_CheckedChanged);
            // 
            // txtBusqTrans
            // 
            this.txtBusqTrans.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqTrans.Enabled = false;
            this.txtBusqTrans.Location = new System.Drawing.Point(16, 46);
            this.txtBusqTrans.Name = "txtBusqTrans";
            this.txtBusqTrans.Size = new System.Drawing.Size(212, 20);
            this.txtBusqTrans.TabIndex = 32;
            // 
            // btnBusquedaTrans
            // 
            this.btnBusquedaTrans.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBusquedaTrans.Enabled = false;
            this.btnBusquedaTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaTrans.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBusquedaTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaTrans.Location = new System.Drawing.Point(234, 42);
            this.btnBusquedaTrans.Name = "btnBusquedaTrans";
            this.btnBusquedaTrans.Size = new System.Drawing.Size(67, 26);
            this.btnBusquedaTrans.TabIndex = 34;
            this.btnBusquedaTrans.Text = "Buscar";
            this.btnBusquedaTrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusquedaTrans.UseVisualStyleBackColor = true;
            this.btnBusquedaTrans.Click += new System.EventHandler(this.btnBusquedaTrans_Click);
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
            this.btnElimCliente.Click += new System.EventHandler(this.btnElimCliente_Click);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnBusquedaTrans);
            this.groupBox1.Controls.Add(this.rbtnBusqRuc);
            this.groupBox1.Controls.Add(this.txtBusqTrans);
            this.groupBox1.Location = new System.Drawing.Point(427, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 90);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // GestionTransportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 387);
            this.Controls.Add(this.btnElimCliente);
            this.Controls.Add(this.btnModCliente);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.dgvTransportistas);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionTransportistas";
            this.Text = "GestionTransportistas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportistas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransportistas;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnBusquedaTrans;
        private System.Windows.Forms.RadioButton rbtnBusqRuc;
        private System.Windows.Forms.TextBox txtBusqTrans;
        private System.Windows.Forms.Button btnElimCliente;
        private System.Windows.Forms.Button btnModCliente;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}