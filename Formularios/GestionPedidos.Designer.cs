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
            this.rbtn = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtnBusqRuc = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRUCPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedorPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnBusquedaPedido = new System.Windows.Forms.Button();
            this.btnElimPedido = new System.Windows.Forms.Button();
            this.btnModPedido = new System.Windows.Forms.Button();
            this.btnAddPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqPedido
            // 
            this.txtBusqPedido.Location = new System.Drawing.Point(442, 46);
            this.txtBusqPedido.Name = "txtBusqPedido";
            this.txtBusqPedido.Size = new System.Drawing.Size(212, 20);
            this.txtBusqPedido.TabIndex = 3;
            this.txtBusqPedido.TextChanged += new System.EventHandler(this.txtBusqPedido_TextChanged);
            // 
            // rbtn
            // 
            this.rbtn.AutoSize = true;
            this.rbtn.Location = new System.Drawing.Point(442, 23);
            this.rbtn.Name = "rbtn";
            this.rbtn.Size = new System.Drawing.Size(90, 17);
            this.rbtn.TabIndex = 4;
            this.rbtn.TabStop = true;
            this.rbtn.Text = "Por Vendedor";
            this.rbtn.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(538, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Por Nombre Cliente";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnBusqRuc
            // 
            this.rbtnBusqRuc.AutoSize = true;
            this.rbtnBusqRuc.Location = new System.Drawing.Point(660, 23);
            this.rbtnBusqRuc.Name = "rbtnBusqRuc";
            this.rbtnBusqRuc.Size = new System.Drawing.Size(67, 17);
            this.rbtnBusqRuc.TabIndex = 6;
            this.rbtnBusqRuc.TabStop = true;
            this.rbtnBusqRuc.Text = "Por RUC";
            this.rbtnBusqRuc.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPedido,
            this.colRUCPedido,
            this.colClientePedido,
            this.colVendedorPedido,
            this.colfechaPedido,
            this.colEstadoPedido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(28, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 251);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colIdPedido
            // 
            this.colIdPedido.Frozen = true;
            this.colIdPedido.HeaderText = "ID";
            this.colIdPedido.Name = "colIdPedido";
            this.colIdPedido.ReadOnly = true;
            this.colIdPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colIdPedido.Width = 40;
            // 
            // colRUCPedido
            // 
            this.colRUCPedido.Frozen = true;
            this.colRUCPedido.HeaderText = "RUC";
            this.colRUCPedido.Name = "colRUCPedido";
            this.colRUCPedido.ReadOnly = true;
            this.colRUCPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRUCPedido.Width = 80;
            // 
            // colClientePedido
            // 
            this.colClientePedido.Frozen = true;
            this.colClientePedido.HeaderText = "Cliente";
            this.colClientePedido.Name = "colClientePedido";
            this.colClientePedido.ReadOnly = true;
            this.colClientePedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colClientePedido.Width = 200;
            // 
            // colVendedorPedido
            // 
            this.colVendedorPedido.Frozen = true;
            this.colVendedorPedido.HeaderText = "Vendedor";
            this.colVendedorPedido.Name = "colVendedorPedido";
            this.colVendedorPedido.ReadOnly = true;
            this.colVendedorPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colVendedorPedido.Width = 150;
            // 
            // colfechaPedido
            // 
            this.colfechaPedido.Frozen = true;
            this.colfechaPedido.HeaderText = "Fecha";
            this.colfechaPedido.Name = "colfechaPedido";
            this.colfechaPedido.ReadOnly = true;
            this.colfechaPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEstadoPedido
            // 
            this.colEstadoPedido.Frozen = true;
            this.colEstadoPedido.HeaderText = "Estado";
            this.colEstadoPedido.Name = "colEstadoPedido";
            this.colEstadoPedido.ReadOnly = true;
            this.colEstadoPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // GestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 446);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBusquedaPedido);
            this.Controls.Add(this.rbtnBusqRuc);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbtn);
            this.Controls.Add(this.txtBusqPedido);
            this.Controls.Add(this.btnElimPedido);
            this.Controls.Add(this.btnModPedido);
            this.Controls.Add(this.btnAddPedido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionPedidos";
            this.Text = "Gestion de Pedidos";
            this.Load += new System.EventHandler(this.GestionPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.Button btnModPedido;
        private System.Windows.Forms.TextBox txtBusqPedido;
        private System.Windows.Forms.RadioButton rbtn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtnBusqRuc;
        private System.Windows.Forms.Button btnBusquedaPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUCPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedorPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnElimPedido;
    }
}