namespace Formularios
{
    partial class registradoPedido
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
            this.lblConfirmadoPedido = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmadoPedido
            // 
            this.lblConfirmadoPedido.AutoSize = true;
            this.lblConfirmadoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmadoPedido.Location = new System.Drawing.Point(26, 50);
            this.lblConfirmadoPedido.Name = "lblConfirmadoPedido";
            this.lblConfirmadoPedido.Size = new System.Drawing.Size(319, 25);
            this.lblConfirmadoPedido.TabIndex = 0;
            this.lblConfirmadoPedido.Text = "REGISTRADO CORRECTAMEN";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(142, 119);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // registradoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 169);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblConfirmadoPedido);
            this.Name = "registradoPedido";
            this.Text = "CONFIRMACION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmadoPedido;
        private System.Windows.Forms.Button btnAceptar;
    }
}