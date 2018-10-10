namespace Formularios
{
    partial class confCancelarAddPedido
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
            this.btnAceptarConfirmacionCancelAddp = new System.Windows.Forms.Button();
            this.btnCancelarConfAddPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptarConfirmacionCancelAddp
            // 
            this.btnAceptarConfirmacionCancelAddp.Location = new System.Drawing.Point(186, 121);
            this.btnAceptarConfirmacionCancelAddp.Name = "btnAceptarConfirmacionCancelAddp";
            this.btnAceptarConfirmacionCancelAddp.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarConfirmacionCancelAddp.TabIndex = 0;
            this.btnAceptarConfirmacionCancelAddp.Text = "Aceptar";
            this.btnAceptarConfirmacionCancelAddp.UseVisualStyleBackColor = true;
            this.btnAceptarConfirmacionCancelAddp.Click += new System.EventHandler(this.btnAceptarConfirmacionCancelAddp_Click);
            // 
            // btnCancelarConfAddPedido
            // 
            this.btnCancelarConfAddPedido.Location = new System.Drawing.Point(66, 121);
            this.btnCancelarConfAddPedido.Name = "btnCancelarConfAddPedido";
            this.btnCancelarConfAddPedido.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarConfAddPedido.TabIndex = 1;
            this.btnCancelarConfAddPedido.Text = "Cancelar";
            this.btnCancelarConfAddPedido.UseVisualStyleBackColor = true;
            this.btnCancelarConfAddPedido.Click += new System.EventHandler(this.btnCancelarConfAddPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Está seguro que desea salir?";
            // 
            // confCancelarAddPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarConfAddPedido);
            this.Controls.Add(this.btnAceptarConfirmacionCancelAddp);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "confCancelarAddPedido";
            this.Text = "Confrmacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarConfirmacionCancelAddp;
        private System.Windows.Forms.Button btnCancelarConfAddPedido;
        private System.Windows.Forms.Label label1;
    }
}