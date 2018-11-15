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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarTransportista));
            this.rbtnRUC = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.txtBuscarT = new System.Windows.Forms.TextBox();
            this.btnBuscarTran = new System.Windows.Forms.Button();
            this.dgvTransportistas = new System.Windows.Forms.DataGridView();
            this.colRUCBuscarTran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSocialBuscarTran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportistas)).BeginInit();
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
            this.rbtnNombre.Size = new System.Drawing.Size(88, 17);
            this.rbtnNombre.TabIndex = 1;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Razon Social";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscarT
            // 
            this.txtBuscarT.Location = new System.Drawing.Point(26, 37);
            this.txtBuscarT.Name = "txtBuscarT";
            this.txtBuscarT.Size = new System.Drawing.Size(116, 20);
            this.txtBuscarT.TabIndex = 2;
            this.txtBuscarT.TextChanged += new System.EventHandler(this.txtBuscarT_TextChanged);
            // 
            // btnBuscarTran
            // 
            this.btnBuscarTran.Image = global::Formularios.Properties.Resources._015_search1;
            this.btnBuscarTran.Location = new System.Drawing.Point(148, 34);
            this.btnBuscarTran.Name = "btnBuscarTran";
            this.btnBuscarTran.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarTran.TabIndex = 3;
            this.btnBuscarTran.UseVisualStyleBackColor = true;
            this.btnBuscarTran.Click += new System.EventHandler(this.btnBuscarTran_Click);
            // 
            // dgvTransportistas
            // 
            this.dgvTransportistas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTransportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRUCBuscarTran,
            this.colRazonSocialBuscarTran});
            this.dgvTransportistas.Location = new System.Drawing.Point(26, 94);
            this.dgvTransportistas.Name = "dgvTransportistas";
            this.dgvTransportistas.Size = new System.Drawing.Size(343, 134);
            this.dgvTransportistas.TabIndex = 4;
            // 
            // colRUCBuscarTran
            // 
            this.colRUCBuscarTran.DataPropertyName = "Ruc";
            this.colRUCBuscarTran.Frozen = true;
            this.colRUCBuscarTran.HeaderText = "RUC";
            this.colRUCBuscarTran.Name = "colRUCBuscarTran";
            this.colRUCBuscarTran.ReadOnly = true;
            // 
            // colRazonSocialBuscarTran
            // 
            this.colRazonSocialBuscarTran.DataPropertyName = "Nombre";
            this.colRazonSocialBuscarTran.Frozen = true;
            this.colRazonSocialBuscarTran.HeaderText = "Razon Social";
            this.colRazonSocialBuscarTran.Name = "colRazonSocialBuscarTran";
            this.colRazonSocialBuscarTran.ReadOnly = true;
            this.colRazonSocialBuscarTran.Width = 200;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Formularios.Properties.Resources.check;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(203, 249);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 32);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Formularios.Properties.Resources.cross;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(289, 249);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Controls.Add(this.dgvTransportistas);
            this.Controls.Add(this.btnBuscarTran);
            this.Controls.Add(this.txtBuscarT);
            this.Controls.Add(this.rbtnNombre);
            this.Controls.Add(this.rbtnRUC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buscarTransportista";
            this.Text = "Buscar Transportista";
            this.Load += new System.EventHandler(this.buscarTransportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnRUC;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.TextBox txtBuscarT;
        private System.Windows.Forms.Button btnBuscarTran;
        private System.Windows.Forms.DataGridView dgvTransportistas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUCBuscarTran;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocialBuscarTran;
    }
}