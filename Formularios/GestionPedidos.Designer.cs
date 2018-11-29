namespace Formularios
{
    partial class GestionPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPedidos));
            this.txtBusqPedido = new System.Windows.Forms.TextBox();
            this.rbtnVendedor = new System.Windows.Forms.RadioButton();
            this.rbtnRazonSocial = new System.Windows.Forms.RadioButton();
            this.rbtnBusqRuc = new System.Windows.Forms.RadioButton();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnBusquedaPedido = new System.Windows.Forms.Button();
            this.btnElimPedido = new System.Windows.Forms.Button();
            this.btnModPedido = new System.Windows.Forms.Button();
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.colRUCPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqPedido
            // 
            this.txtBusqPedido.Location = new System.Drawing.Point(442, 46);
            this.txtBusqPedido.Name = "txtBusqPedido";
            this.txtBusqPedido.Size = new System.Drawing.Size(212, 20);
            this.txtBusqPedido.TabIndex = 3;
            this.txtBusqPedido.TextChanged += new System.EventHandler(this.txtBusqPedido_TextChanged);
            this.txtBusqPedido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqPedido_KeyUp);
            // 
            // rbtnVendedor
            // 
            this.rbtnVendedor.AutoSize = true;
            this.rbtnVendedor.Location = new System.Drawing.Point(597, 23);
            this.rbtnVendedor.Name = "rbtnVendedor";
            this.rbtnVendedor.Size = new System.Drawing.Size(90, 17);
            this.rbtnVendedor.TabIndex = 4;
            this.rbtnVendedor.TabStop = true;
            this.rbtnVendedor.Text = "Por Vendedor";
            this.rbtnVendedor.UseVisualStyleBackColor = true;
            // 
            // rbtnRazonSocial
            // 
            this.rbtnRazonSocial.AutoSize = true;
            this.rbtnRazonSocial.Location = new System.Drawing.Point(515, 23);
            this.rbtnRazonSocial.Name = "rbtnRazonSocial";
            this.rbtnRazonSocial.Size = new System.Drawing.Size(76, 17);
            this.rbtnRazonSocial.TabIndex = 5;
            this.rbtnRazonSocial.TabStop = true;
            this.rbtnRazonSocial.Text = "Por Cliente";
            this.rbtnRazonSocial.UseVisualStyleBackColor = true;
            this.rbtnRazonSocial.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnBusqRuc
            // 
            this.rbtnBusqRuc.AutoSize = true;
            this.rbtnBusqRuc.Location = new System.Drawing.Point(442, 23);
            this.rbtnBusqRuc.Name = "rbtnBusqRuc";
            this.rbtnBusqRuc.Size = new System.Drawing.Size(67, 17);
            this.rbtnBusqRuc.TabIndex = 6;
            this.rbtnBusqRuc.TabStop = true;
            this.rbtnBusqRuc.Text = "Por RUC";
            this.rbtnBusqRuc.UseVisualStyleBackColor = true;
            this.rbtnBusqRuc.CheckedChanged += new System.EventHandler(this.rbtnBusqRuc_CheckedChanged);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRUCPedido,
            this.colClientePedido,
            this.colNombreVendedor,
            this.colfechaPedido,
            this.colEstadoPedido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.Location = new System.Drawing.Point(28, 120);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(711, 251);
            this.dgvPedidos.TabIndex = 8;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Image = global::Formularios.Properties.Resources.file;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(660, 74);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(67, 31);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "   Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPedido.Image = global::Formularios.Properties.Resources._005_x_button__1_;
            this.btnCancelarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPedido.Location = new System.Drawing.Point(341, 377);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(96, 42);
            this.btnCancelarPedido.TabIndex = 9;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnBusquedaPedido
            // 
            this.btnBusquedaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaPedido.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBusquedaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaPedido.Location = new System.Drawing.Point(660, 42);
            this.btnBusquedaPedido.Name = "btnBusquedaPedido";
            this.btnBusquedaPedido.Size = new System.Drawing.Size(67, 26);
            this.btnBusquedaPedido.TabIndex = 7;
            this.btnBusquedaPedido.Text = "Buscar";
            this.btnBusquedaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusquedaPedido.UseVisualStyleBackColor = true;
            this.btnBusquedaPedido.Click += new System.EventHandler(this.btnBusquedaPedido_Click);
            // 
            // btnElimPedido
            // 
            this.btnElimPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimPedido.Image = global::Formularios.Properties.Resources._008_document;
            this.btnElimPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimPedido.Location = new System.Drawing.Point(297, 30);
            this.btnElimPedido.Name = "btnElimPedido";
            this.btnElimPedido.Size = new System.Drawing.Size(102, 50);
            this.btnElimPedido.TabIndex = 2;
            this.btnElimPedido.Text = "  Eliminar";
            this.btnElimPedido.UseVisualStyleBackColor = true;
            this.btnElimPedido.Click += new System.EventHandler(this.btnElimPedido_Click);
            // 
            // btnModPedido
            // 
            this.btnModPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModPedido.Image = global::Formularios.Properties.Resources.file__3_;
            this.btnModPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModPedido.Location = new System.Drawing.Point(163, 30);
            this.btnModPedido.Name = "btnModPedido";
            this.btnModPedido.Size = new System.Drawing.Size(102, 50);
            this.btnModPedido.TabIndex = 1;
            this.btnModPedido.Text = "   Modificar";
            this.btnModPedido.UseVisualStyleBackColor = true;
            this.btnModPedido.Click += new System.EventHandler(this.btnModPedido_Click);
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPedido.Image = global::Formularios.Properties.Resources.plus__1_;
            this.btnAddPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPedido.Location = new System.Drawing.Point(28, 30);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(102, 50);
            this.btnAddPedido.TabIndex = 0;
            this.btnAddPedido.Text = "Agregar";
            this.btnAddPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPedido.UseMnemonic = false;
            this.btnAddPedido.UseVisualStyleBackColor = false;
            this.btnAddPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // colRUCPedido
            // 
            this.colRUCPedido.DataPropertyName = "ClienteRUC";
            this.colRUCPedido.Frozen = true;
            this.colRUCPedido.HeaderText = "RUC";
            this.colRUCPedido.Name = "colRUCPedido";
            this.colRUCPedido.ReadOnly = true;
            this.colRUCPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRUCPedido.Width = 80;
            // 
            // colClientePedido
            // 
            this.colClientePedido.DataPropertyName = "ClienteNombre";
            this.colClientePedido.Frozen = true;
            this.colClientePedido.HeaderText = "Cliente";
            this.colClientePedido.Name = "colClientePedido";
            this.colClientePedido.ReadOnly = true;
            this.colClientePedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colClientePedido.Width = 200;
            // 
            // colNombreVendedor
            // 
            this.colNombreVendedor.DataPropertyName = "NombreVendedor";
            this.colNombreVendedor.Frozen = true;
            this.colNombreVendedor.HeaderText = "Vendedor";
            this.colNombreVendedor.Name = "colNombreVendedor";
            this.colNombreVendedor.ReadOnly = true;
            // 
            // colfechaPedido
            // 
            this.colfechaPedido.DataPropertyName = "Fecha_e";
            this.colfechaPedido.Frozen = true;
            this.colfechaPedido.HeaderText = "Fecha";
            this.colfechaPedido.Name = "colfechaPedido";
            this.colfechaPedido.ReadOnly = true;
            this.colfechaPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEstadoPedido
            // 
            this.colEstadoPedido.DataPropertyName = "Etapa1";
            this.colEstadoPedido.Frozen = true;
            this.colEstadoPedido.HeaderText = "Etapa";
            this.colEstadoPedido.Name = "colEstadoPedido";
            this.colEstadoPedido.ReadOnly = true;
            this.colEstadoPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // GestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 446);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnBusquedaPedido);
            this.Controls.Add(this.rbtnBusqRuc);
            this.Controls.Add(this.rbtnRazonSocial);
            this.Controls.Add(this.rbtnVendedor);
            this.Controls.Add(this.txtBusqPedido);
            this.Controls.Add(this.btnElimPedido);
            this.Controls.Add(this.btnModPedido);
            this.Controls.Add(this.btnAddPedido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionPedidos";
            this.Text = "Gestion de Pedidos";
            this.Load += new System.EventHandler(this.GestionPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.Button btnModPedido;
        private System.Windows.Forms.TextBox txtBusqPedido;
        private System.Windows.Forms.RadioButton rbtnVendedor;
        private System.Windows.Forms.RadioButton rbtnRazonSocial;
        private System.Windows.Forms.RadioButton rbtnBusqRuc;
        private System.Windows.Forms.Button btnBusquedaPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnElimPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUCPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoPedido;
    }
}