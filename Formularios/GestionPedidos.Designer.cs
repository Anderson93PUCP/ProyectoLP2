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
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.btnModPedido = new System.Windows.Forms.Button();
            this.btnElimPedido = new System.Windows.Forms.Button();
            this.txtBusqPedido = new System.Windows.Forms.TextBox();
            this.rbtn = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtnBusqRuc = new System.Windows.Forms.RadioButton();
            this.btnBusquedaPedido = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRUCPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedorPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoPedido = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.Location = new System.Drawing.Point(28, 30);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(114, 50);
            this.btnAddPedido.TabIndex = 0;
            this.btnAddPedido.Text = "Agregar";
            this.btnAddPedido.UseVisualStyleBackColor = true;
            this.btnAddPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModPedido
            // 
            this.btnModPedido.Location = new System.Drawing.Point(163, 30);
            this.btnModPedido.Name = "btnModPedido";
            this.btnModPedido.Size = new System.Drawing.Size(114, 50);
            this.btnModPedido.TabIndex = 1;
            this.btnModPedido.Text = "Modificar";
            this.btnModPedido.UseVisualStyleBackColor = true;
            // 
            // btnElimPedido
            // 
            this.btnElimPedido.Location = new System.Drawing.Point(297, 30);
            this.btnElimPedido.Name = "btnElimPedido";
            this.btnElimPedido.Size = new System.Drawing.Size(114, 50);
            this.btnElimPedido.TabIndex = 2;
            this.btnElimPedido.Text = "Eliminar";
            this.btnElimPedido.UseVisualStyleBackColor = true;
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
            // btnBusquedaPedido
            // 
            this.btnBusquedaPedido.Location = new System.Drawing.Point(660, 42);
            this.btnBusquedaPedido.Name = "btnBusquedaPedido";
            this.btnBusquedaPedido.Size = new System.Drawing.Size(67, 26);
            this.btnBusquedaPedido.TabIndex = 7;
            this.btnBusquedaPedido.Text = "Buscar...";
            this.btnBusquedaPedido.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPedido,
            this.colRUCPedido,
            this.colClientePedido,
            this.colVendedorPedido,
            this.colfechaPedido,
            this.colEstadoPedido});
            this.dataGridView1.Location = new System.Drawing.Point(28, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 355);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colIdPedido
            // 
            this.colIdPedido.HeaderText = "ID";
            this.colIdPedido.Name = "colIdPedido";
            this.colIdPedido.ReadOnly = true;
            this.colIdPedido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colRUCPedido
            // 
            this.colRUCPedido.HeaderText = "RUC";
            this.colRUCPedido.Name = "colRUCPedido";
            this.colRUCPedido.ReadOnly = true;
            this.colRUCPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colClientePedido
            // 
            this.colClientePedido.HeaderText = "Cliente";
            this.colClientePedido.Name = "colClientePedido";
            this.colClientePedido.ReadOnly = true;
            this.colClientePedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colVendedorPedido
            // 
            this.colVendedorPedido.HeaderText = "Vendedor";
            this.colVendedorPedido.Name = "colVendedorPedido";
            this.colVendedorPedido.ReadOnly = true;
            this.colVendedorPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colfechaPedido
            // 
            this.colfechaPedido.HeaderText = "Fecha";
            this.colfechaPedido.Name = "colfechaPedido";
            this.colfechaPedido.ReadOnly = true;
            this.colfechaPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEstadoPedido
            // 
            this.colEstadoPedido.HeaderText = "Estado";
            this.colEstadoPedido.Name = "colEstadoPedido";
            this.colEstadoPedido.ReadOnly = true;
            this.colEstadoPedido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEstadoPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBusquedaPedido);
            this.Controls.Add(this.rbtnBusqRuc);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbtn);
            this.Controls.Add(this.txtBusqPedido);
            this.Controls.Add(this.btnElimPedido);
            this.Controls.Add(this.btnModPedido);
            this.Controls.Add(this.btnAddPedido);
            this.Name = "GestionPedidos";
            this.Text = "Gestion de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.Button btnModPedido;
        private System.Windows.Forms.Button btnElimPedido;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn colEstadoPedido;
    }
}