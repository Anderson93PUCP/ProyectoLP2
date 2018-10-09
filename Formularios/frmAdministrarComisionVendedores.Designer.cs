namespace Formularios
{
    partial class frmAdministrarComisionVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarComisionVendedores));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIDAdminComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRUCAdminComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSAdminComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendAdminComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComAdminComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoPagoVendAdminComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalComision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDAdminComision,
            this.colRUCAdminComision,
            this.colRazonSAdminComision,
            this.colVendAdminComision,
            this.colComAdminComision,
            this.colEstadoPagoVendAdminComision});
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colIDAdminComision
            // 
            this.colIDAdminComision.HeaderText = "ID";
            this.colIDAdminComision.Name = "colIDAdminComision";
            this.colIDAdminComision.ReadOnly = true;
            // 
            // colRUCAdminComision
            // 
            this.colRUCAdminComision.HeaderText = "RUC";
            this.colRUCAdminComision.Name = "colRUCAdminComision";
            this.colRUCAdminComision.ReadOnly = true;
            // 
            // colRazonSAdminComision
            // 
            this.colRazonSAdminComision.HeaderText = "Razón Social";
            this.colRazonSAdminComision.Name = "colRazonSAdminComision";
            this.colRazonSAdminComision.ReadOnly = true;
            // 
            // colVendAdminComision
            // 
            this.colVendAdminComision.HeaderText = "Vendedor";
            this.colVendAdminComision.Name = "colVendAdminComision";
            this.colVendAdminComision.ReadOnly = true;
            // 
            // colComAdminComision
            // 
            this.colComAdminComision.HeaderText = "Comision";
            this.colComAdminComision.Name = "colComAdminComision";
            this.colComAdminComision.ReadOnly = true;
            // 
            // colEstadoPagoVendAdminComision
            // 
            this.colEstadoPagoVendAdminComision.HeaderText = "Estado";
            this.colEstadoPagoVendAdminComision.Name = "colEstadoPagoVendAdminComision";
            this.colEstadoPagoVendAdminComision.ReadOnly = true;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(482, 24);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "\t",
            "Vendedor1",
            "Vendedor2"});
            this.comboBox1.Location = new System.Drawing.Point(469, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnPagar
            // 
            this.btnPagar.Image = global::Formularios.Properties.Resources._026_cash;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(596, 32);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(64, 35);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "&Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL:";
            // 
            // txtTotalComision
            // 
            this.txtTotalComision.Enabled = false;
            this.txtTotalComision.Location = new System.Drawing.Point(457, 261);
            this.txtTotalComision.Name = "txtTotalComision";
            this.txtTotalComision.Size = new System.Drawing.Size(71, 20);
            this.txtTotalComision.TabIndex = 6;
            this.txtTotalComision.Text = "742.23";
            this.txtTotalComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "S/.";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = global::Formularios.Properties.Resources.back__1_;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(304, 280);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(91, 35);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "&Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmAdministrarComisionVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 327);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalComision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministrarComisionVendedores";
            this.Text = "Administrar pago comisiones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDAdminComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUCAdminComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSAdminComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendAdminComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComAdminComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoPagoVendAdminComision;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalComision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
    }
}