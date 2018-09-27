namespace Formularios
{
    partial class AgregarDirecciones
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
            this.cmbdepartamento = new System.Windows.Forms.ComboBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldirec = new System.Windows.Forms.Label();
            this.lbdistrito = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lbldepartamento = new System.Windows.Forms.Label();
            this.cmbprovincia = new System.Windows.Forms.ComboBox();
            this.cmbdistrito = new System.Windows.Forms.ComboBox();
            this.btnagregarDireccion = new System.Windows.Forms.Button();
            this.btncancelarDireccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbdepartamento
            // 
            this.cmbdepartamento.FormattingEnabled = true;
            this.cmbdepartamento.Location = new System.Drawing.Point(171, 32);
            this.cmbdepartamento.Name = "cmbdepartamento";
            this.cmbdepartamento.Size = new System.Drawing.Size(275, 21);
            this.cmbdepartamento.TabIndex = 23;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(171, 156);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(275, 24);
            this.txtdireccion.TabIndex = 20;
            // 
            // lbldirec
            // 
            this.lbldirec.AutoSize = true;
            this.lbldirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldirec.Location = new System.Drawing.Point(34, 164);
            this.lbldirec.Name = "lbldirec";
            this.lbldirec.Size = new System.Drawing.Size(68, 16);
            this.lbldirec.TabIndex = 19;
            this.lbldirec.Text = "Direccion:";
            // 
            // lbdistrito
            // 
            this.lbdistrito.AutoSize = true;
            this.lbdistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdistrito.Location = new System.Drawing.Point(34, 117);
            this.lbdistrito.Name = "lbdistrito";
            this.lbdistrito.Size = new System.Drawing.Size(49, 16);
            this.lbdistrito.TabIndex = 18;
            this.lbdistrito.Text = "Distrito";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(34, 77);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(67, 16);
            this.lblProvincia.TabIndex = 17;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lbldepartamento
            // 
            this.lbldepartamento.AutoSize = true;
            this.lbldepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartamento.Location = new System.Drawing.Point(34, 37);
            this.lbldepartamento.Name = "lbldepartamento";
            this.lbldepartamento.Size = new System.Drawing.Size(97, 16);
            this.lbldepartamento.TabIndex = 16;
            this.lbldepartamento.Text = "Departamento:";
            // 
            // cmbprovincia
            // 
            this.cmbprovincia.FormattingEnabled = true;
            this.cmbprovincia.Location = new System.Drawing.Point(171, 72);
            this.cmbprovincia.Name = "cmbprovincia";
            this.cmbprovincia.Size = new System.Drawing.Size(275, 21);
            this.cmbprovincia.TabIndex = 24;
            // 
            // cmbdistrito
            // 
            this.cmbdistrito.FormattingEnabled = true;
            this.cmbdistrito.Location = new System.Drawing.Point(171, 112);
            this.cmbdistrito.Name = "cmbdistrito";
            this.cmbdistrito.Size = new System.Drawing.Size(275, 21);
            this.cmbdistrito.TabIndex = 25;
            // 
            // btnagregarDireccion
            // 
            this.btnagregarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarDireccion.Location = new System.Drawing.Point(251, 213);
            this.btnagregarDireccion.Name = "btnagregarDireccion";
            this.btnagregarDireccion.Size = new System.Drawing.Size(94, 28);
            this.btnagregarDireccion.TabIndex = 26;
            this.btnagregarDireccion.Text = "ACEPTAR";
            this.btnagregarDireccion.UseVisualStyleBackColor = true;
            this.btnagregarDireccion.Click += new System.EventHandler(this.btnagregarDireccion_Click);
            // 
            // btncancelarDireccion
            // 
            this.btncancelarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarDireccion.Location = new System.Drawing.Point(351, 213);
            this.btncancelarDireccion.Name = "btncancelarDireccion";
            this.btncancelarDireccion.Size = new System.Drawing.Size(95, 28);
            this.btncancelarDireccion.TabIndex = 27;
            this.btncancelarDireccion.Text = "CANCELAR";
            this.btncancelarDireccion.UseVisualStyleBackColor = true;
            this.btncancelarDireccion.Click += new System.EventHandler(this.btncancelarDireccion_Click);
            // 
            // AgregarDirecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 253);
            this.Controls.Add(this.btncancelarDireccion);
            this.Controls.Add(this.btnagregarDireccion);
            this.Controls.Add(this.cmbdistrito);
            this.Controls.Add(this.cmbprovincia);
            this.Controls.Add(this.cmbdepartamento);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.lbldirec);
            this.Controls.Add(this.lbdistrito);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lbldepartamento);
            this.Name = "AgregarDirecciones";
            this.Text = "AgregarDirecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbdepartamento;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldirec;
        private System.Windows.Forms.Label lbdistrito;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lbldepartamento;
        private System.Windows.Forms.ComboBox cmbprovincia;
        private System.Windows.Forms.ComboBox cmbdistrito;
        private System.Windows.Forms.Button btnagregarDireccion;
        private System.Windows.Forms.Button btncancelarDireccion;
    }
}