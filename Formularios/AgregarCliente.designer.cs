namespace Formularios
{
    partial class AgregarCliente
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
            this.lblruc = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lbldirecciones = new System.Windows.Forms.Label();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtrazon = new System.Windows.Forms.TextBox();
            this.txttelf = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cmbvendedor = new System.Windows.Forms.ComboBox();
            this.btndirecciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblruc.Location = new System.Drawing.Point(28, 41);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(40, 16);
            this.lblruc.TabIndex = 0;
            this.lblruc.Text = "RUC:";
            this.lblruc.Click += new System.EventHandler(this.lblruc_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(28, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(113, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre o Razon:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(28, 120);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(65, 16);
            this.lbltelefono.TabIndex = 2;
            this.lbltelefono.Text = "Telefono:";
            this.lbltelefono.Click += new System.EventHandler(this.lbltelefono_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(28, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lbldirecciones
            // 
            this.lbldirecciones.AutoSize = true;
            this.lbldirecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldirecciones.Location = new System.Drawing.Point(28, 203);
            this.lbldirecciones.Name = "lbldirecciones";
            this.lbldirecciones.Size = new System.Drawing.Size(83, 16);
            this.lbldirecciones.TabIndex = 4;
            this.lbldirecciones.Text = "Direcciones:";
            this.lbldirecciones.Click += new System.EventHandler(this.lbldirecciones_Click);
            // 
            // txtruc
            // 
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.Location = new System.Drawing.Point(165, 36);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(146, 24);
            this.txtruc.TabIndex = 5;
            this.txtruc.TextChanged += new System.EventHandler(this.txtruc_TextChanged);
            // 
            // txtrazon
            // 
            this.txtrazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrazon.Location = new System.Drawing.Point(165, 75);
            this.txtrazon.Name = "txtrazon";
            this.txtrazon.Size = new System.Drawing.Size(146, 24);
            this.txtrazon.TabIndex = 6;
            this.txtrazon.TextChanged += new System.EventHandler(this.txtrazon_TextChanged);
            // 
            // txttelf
            // 
            this.txttelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelf.Location = new System.Drawing.Point(165, 115);
            this.txttelf.Name = "txttelf";
            this.txttelf.Size = new System.Drawing.Size(146, 24);
            this.txttelf.TabIndex = 7;
            this.txttelf.TextChanged += new System.EventHandler(this.txttelf_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(165, 159);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(146, 24);
            this.txtemail.TabIndex = 8;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vendedor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = global::Formularios.Properties.Resources.check;
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaceptar.Location = new System.Drawing.Point(66, 295);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(86, 36);
            this.btnaceptar.TabIndex = 12;
            this.btnaceptar.Text = "Registrar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = global::Formularios.Properties.Resources.cross;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(180, 295);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 36);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cmbvendedor
            // 
            this.cmbvendedor.FormattingEnabled = true;
            this.cmbvendedor.Location = new System.Drawing.Point(165, 257);
            this.cmbvendedor.Name = "cmbvendedor";
            this.cmbvendedor.Size = new System.Drawing.Size(146, 21);
            this.cmbvendedor.TabIndex = 15;
            // 
            // btndirecciones
            // 
            this.btndirecciones.Location = new System.Drawing.Point(165, 203);
            this.btndirecciones.Name = "btndirecciones";
            this.btndirecciones.Size = new System.Drawing.Size(146, 23);
            this.btndirecciones.TabIndex = 16;
            this.btndirecciones.Text = "...";
            this.btndirecciones.UseVisualStyleBackColor = true;
            this.btndirecciones.Click += new System.EventHandler(this.btndirecciones_Click);
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(347, 343);
            this.Controls.Add(this.btndirecciones);
            this.Controls.Add(this.cmbvendedor);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelf);
            this.Controls.Add(this.txtrazon);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.lbldirecciones);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblruc);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbldirecciones;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtrazon;
        private System.Windows.Forms.TextBox txttelf;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cmbvendedor;
        private System.Windows.Forms.Button btndirecciones;
    }
}