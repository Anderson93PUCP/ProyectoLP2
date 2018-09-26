namespace Formularios
{
    partial class buscarCliente
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
            this.rbtnBusqRuc = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colRucBuscarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSocialBuscarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailBuscarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefBuscarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnBusqRuc
            // 
            this.rbtnBusqRuc.AutoSize = true;
            this.rbtnBusqRuc.Location = new System.Drawing.Point(13, 13);
            this.rbtnBusqRuc.Name = "rbtnBusqRuc";
            this.rbtnBusqRuc.Size = new System.Drawing.Size(48, 17);
            this.rbtnBusqRuc.TabIndex = 0;
            this.rbtnBusqRuc.TabStop = true;
            this.rbtnBusqRuc.Text = "RUC";
            this.rbtnBusqRuc.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(67, 12);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnNombre.TabIndex = 1;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(13, 37);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(116, 20);
            this.txtBuscarCliente.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(136, 33);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRucBuscarCliente,
            this.colRazonSocialBuscarCliente,
            this.colEmailBuscarCliente,
            this.colTelefBuscarCliente});
            this.dataGridView1.Location = new System.Drawing.Point(13, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // colRucBuscarCliente
            // 
            this.colRucBuscarCliente.Frozen = true;
            this.colRucBuscarCliente.HeaderText = "RUC";
            this.colRucBuscarCliente.Name = "colRucBuscarCliente";
            this.colRucBuscarCliente.ReadOnly = true;
            // 
            // colRazonSocialBuscarCliente
            // 
            this.colRazonSocialBuscarCliente.Frozen = true;
            this.colRazonSocialBuscarCliente.HeaderText = "Razon Social";
            this.colRazonSocialBuscarCliente.Name = "colRazonSocialBuscarCliente";
            this.colRazonSocialBuscarCliente.ReadOnly = true;
            // 
            // colEmailBuscarCliente
            // 
            this.colEmailBuscarCliente.Frozen = true;
            this.colEmailBuscarCliente.HeaderText = "e-mail";
            this.colEmailBuscarCliente.Name = "colEmailBuscarCliente";
            this.colEmailBuscarCliente.ReadOnly = true;
            // 
            // colTelefBuscarCliente
            // 
            this.colTelefBuscarCliente.Frozen = true;
            this.colTelefBuscarCliente.HeaderText = "Telefóno";
            this.colTelefBuscarCliente.Name = "colTelefBuscarCliente";
            this.colTelefBuscarCliente.ReadOnly = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(382, 272);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(290, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // buscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 307);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.rbtnNombre);
            this.Controls.Add(this.rbtnBusqRuc);
            this.Name = "buscarCliente";
            this.Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnBusqRuc;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRucBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocialBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefBuscarCliente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}