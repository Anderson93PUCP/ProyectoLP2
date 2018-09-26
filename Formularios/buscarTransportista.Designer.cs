namespace Formularios
{
    partial class buscarTransportista
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
            this.rbtnRUC = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarTran = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colRUCBuscarTran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSocialBuscarTran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnRUC
            // 
            this.rbtnRUC.AutoSize = true;
            this.rbtnRUC.Location = new System.Drawing.Point(26, 13);
            this.rbtnRUC.Name = "rbtnRUC";
            this.rbtnRUC.Size = new System.Drawing.Size(48, 17);
            this.rbtnRUC.TabIndex = 0;
            this.rbtnRUC.TabStop = true;
            this.rbtnRUC.Text = "RUC";
            this.rbtnRUC.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(80, 12);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnNombre.TabIndex = 1;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnBuscarTran
            // 
            this.btnBuscarTran.Location = new System.Drawing.Point(159, 37);
            this.btnBuscarTran.Name = "btnBuscarTran";
            this.btnBuscarTran.Size = new System.Drawing.Size(67, 20);
            this.btnBuscarTran.TabIndex = 3;
            this.btnBuscarTran.Text = "Buscar...";
            this.btnBuscarTran.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRUCBuscarTran,
            this.colRazonSocialBuscarTran});
            this.dataGridView1.Location = new System.Drawing.Point(26, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 134);
            this.dataGridView1.TabIndex = 4;
            // 
            // colRUCBuscarTran
            // 
            this.colRUCBuscarTran.Frozen = true;
            this.colRUCBuscarTran.HeaderText = "RUC";
            this.colRUCBuscarTran.Name = "colRUCBuscarTran";
            this.colRUCBuscarTran.ReadOnly = true;
            // 
            // colRazonSocialBuscarTran
            // 
            this.colRazonSocialBuscarTran.Frozen = true;
            this.colRazonSocialBuscarTran.HeaderText = "Razon Social";
            this.colRazonSocialBuscarTran.Name = "colRazonSocialBuscarTran";
            this.colRazonSocialBuscarTran.ReadOnly = true;
            this.colRazonSocialBuscarTran.Width = 200;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(294, 258);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(204, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // buscarTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 293);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarTran);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnNombre);
            this.Controls.Add(this.rbtnRUC);
            this.Name = "buscarTransportista";
            this.Text = "Buscar Transportista";
            this.Load += new System.EventHandler(this.buscarTransportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnRUC;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarTran;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUCBuscarTran;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocialBuscarTran;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}