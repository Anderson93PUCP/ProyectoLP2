namespace Formularios
{
    partial class AgregarUsuario
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
            this.cmbrol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelf = new System.Windows.Forms.TextBox();
            this.txtrazon = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblruc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcomision = new System.Windows.Forms.TextBox();
            this.lblcomision = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbrol
            // 
            this.cmbrol.FormattingEnabled = true;
            this.cmbrol.Items.AddRange(new object[] {
            "Administrador",
            "Operario",
            "Vendedor"});
            this.cmbrol.Location = new System.Drawing.Point(441, 41);
            this.cmbrol.Name = "cmbrol";
            this.cmbrol.Size = new System.Drawing.Size(146, 21);
            this.cmbrol.TabIndex = 29;
            this.cmbrol.SelectedIndexChanged += new System.EventHandler(this.cmbvendedor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "ROL";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(177, 207);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(146, 24);
            this.txtemail.TabIndex = 25;
            // 
            // txttelf
            // 
            this.txttelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelf.Location = new System.Drawing.Point(177, 115);
            this.txttelf.Name = "txttelf";
            this.txttelf.Size = new System.Drawing.Size(146, 24);
            this.txttelf.TabIndex = 24;
            // 
            // txtrazon
            // 
            this.txtrazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrazon.Location = new System.Drawing.Point(177, 75);
            this.txtrazon.Name = "txtrazon";
            this.txtrazon.Size = new System.Drawing.Size(146, 24);
            this.txtrazon.TabIndex = 23;
            // 
            // txtruc
            // 
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.Location = new System.Drawing.Point(177, 36);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(146, 24);
            this.txtruc.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 212);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(40, 120);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(65, 16);
            this.lbltelefono.TabIndex = 19;
            this.lbltelefono.Text = "Telefono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(40, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 16);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Apellido:";
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblruc.Location = new System.Drawing.Point(40, 41);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(60, 16);
            this.lblruc.TabIndex = 17;
            this.lblruc.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(177, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 24);
            this.textBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha de Ingreso:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(441, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 24);
            this.textBox2.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Salario (S/.):";
            // 
            // txtcomision
            // 
            this.txtcomision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomision.Location = new System.Drawing.Point(441, 118);
            this.txtcomision.Name = "txtcomision";
            this.txtcomision.Size = new System.Drawing.Size(146, 24);
            this.txtcomision.TabIndex = 38;
            this.txtcomision.Visible = false;
            // 
            // lblcomision
            // 
            this.lblcomision.AutoSize = true;
            this.lblcomision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomision.Location = new System.Drawing.Point(348, 123);
            this.lblcomision.Name = "lblcomision";
            this.lblcomision.Size = new System.Drawing.Size(87, 16);
            this.lblcomision.TabIndex = 37;
            this.lblcomision.Text = "Comision (%)";
            this.lblcomision.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = global::Formularios.Properties.Resources.cross;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(488, 238);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(99, 36);
            this.btncancelar.TabIndex = 28;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = global::Formularios.Properties.Resources.check;
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaceptar.Location = new System.Drawing.Point(370, 238);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(100, 36);
            this.btnaceptar.TabIndex = 27;
            this.btnaceptar.Text = "Registrar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 306);
            this.Controls.Add(this.txtcomision);
            this.Controls.Add(this.lblcomision);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbrol);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelf);
            this.Controls.Add(this.txtrazon);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblruc);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbrol;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelf;
        private System.Windows.Forms.TextBox txtrazon;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcomision;
        private System.Windows.Forms.Label lblcomision;
    }
}