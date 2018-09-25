namespace Formularios
{
    partial class AgregarPedido
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
            this.btnCancelarAddPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelarAddPedido
            // 
            this.btnCancelarAddPedido.Location = new System.Drawing.Point(110, 262);
            this.btnCancelarAddPedido.Name = "btnCancelarAddPedido";
            this.btnCancelarAddPedido.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAddPedido.TabIndex = 0;
            this.btnCancelarAddPedido.Text = "Cancelar";
            this.btnCancelarAddPedido.UseVisualStyleBackColor = true;
            this.btnCancelarAddPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 313);
            this.Controls.Add(this.btnCancelarAddPedido);
            this.Name = "AgregarPedido";
            this.Text = "Agregar Pedido";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarAddPedido;
    }
}