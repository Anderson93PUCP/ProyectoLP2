namespace Formularios
{
    partial class confirmarPagarComision
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptarConfCom = new System.Windows.Forms.Button();
            this.btnCancelarConfComi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Confirma pago?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "52.2 S/.";
            // 
            // btnAceptarConfCom
            // 
            this.btnAceptarConfCom.Location = new System.Drawing.Point(184, 113);
            this.btnAceptarConfCom.Name = "btnAceptarConfCom";
            this.btnAceptarConfCom.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarConfCom.TabIndex = 2;
            this.btnAceptarConfCom.Text = "&Aceptar";
            this.btnAceptarConfCom.UseVisualStyleBackColor = true;
            this.btnAceptarConfCom.Click += new System.EventHandler(this.btnAceptarConfCom_Click);
            // 
            // btnCancelarConfComi
            // 
            this.btnCancelarConfComi.Location = new System.Drawing.Point(54, 113);
            this.btnCancelarConfComi.Name = "btnCancelarConfComi";
            this.btnCancelarConfComi.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarConfComi.TabIndex = 3;
            this.btnCancelarConfComi.Text = "&Cancelar";
            this.btnCancelarConfComi.UseVisualStyleBackColor = true;
            this.btnCancelarConfComi.Click += new System.EventHandler(this.btnCancelarConfComi_Click);
            // 
            // confirmarPagarComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 168);
            this.Controls.Add(this.btnCancelarConfComi);
            this.Controls.Add(this.btnAceptarConfCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "confirmarPagarComision";
            this.Text = "Confirmacion Comisión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptarConfCom;
        private System.Windows.Forms.Button btnCancelarConfComi;
    }
}