﻿namespace Formularios
{
    partial class ModificarUsuario
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
            this.txtcomision = new System.Windows.Forms.TextBox();
            this.lblcomision = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lblsalario = new System.Windows.Forms.Label();
            this.datetimeFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbrol = new System.Windows.Forms.ComboBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelf = new System.Windows.Forms.TextBox();
            this.txtrazon = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblruc = new System.Windows.Forms.Label();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcomision
            // 
            this.txtcomision.Enabled = false;
            this.txtcomision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomision.Location = new System.Drawing.Point(510, 75);
            this.txtcomision.Name = "txtcomision";
            this.txtcomision.Size = new System.Drawing.Size(83, 24);
            this.txtcomision.TabIndex = 58;
            this.txtcomision.Visible = false;
            // 
            // lblcomision
            // 
            this.lblcomision.AutoSize = true;
            this.lblcomision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomision.Location = new System.Drawing.Point(342, 80);
            this.lblcomision.Name = "lblcomision";
            this.lblcomision.Size = new System.Drawing.Size(87, 16);
            this.lblcomision.TabIndex = 57;
            this.lblcomision.Text = "Comision (%)";
            this.lblcomision.Visible = false;
            // 
            // txtsalario
            // 
            this.txtsalario.Enabled = false;
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(510, 75);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(83, 24);
            this.txtsalario.TabIndex = 56;
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalario.Location = new System.Drawing.Point(342, 80);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(81, 16);
            this.lblsalario.TabIndex = 55;
            this.lblsalario.Text = "Salario (S/.):";
            // 
            // datetimeFecha
            // 
            this.datetimeFecha.Enabled = false;
            this.datetimeFecha.Location = new System.Drawing.Point(178, 252);
            this.datetimeFecha.Name = "datetimeFecha";
            this.datetimeFecha.Size = new System.Drawing.Size(146, 20);
            this.datetimeFecha.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Fecha de Ingreso:";
            // 
            // txtdni
            // 
            this.txtdni.Enabled = false;
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.Location = new System.Drawing.Point(178, 157);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(146, 24);
            this.txtdni.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "DNI:";
            // 
            // cmbrol
            // 
            this.cmbrol.Enabled = false;
            this.cmbrol.FormattingEnabled = true;
            this.cmbrol.Items.AddRange(new object[] {
            "Administrador",
            "Operario",
            "Vendedor"});
            this.cmbrol.Location = new System.Drawing.Point(510, 38);
            this.cmbrol.Name = "cmbrol";
            this.cmbrol.Size = new System.Drawing.Size(146, 21);
            this.cmbrol.TabIndex = 50;
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = global::Formularios.Properties.Resources.cross;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(557, 236);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(99, 36);
            this.btncancelar.TabIndex = 49;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = global::Formularios.Properties.Resources.check;
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaceptar.Location = new System.Drawing.Point(345, 236);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(100, 36);
            this.btnaceptar.TabIndex = 48;
            this.btnaceptar.Text = "Registrar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "ROL";
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(178, 205);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(146, 24);
            this.txtemail.TabIndex = 46;
            // 
            // txttelf
            // 
            this.txttelf.Enabled = false;
            this.txttelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelf.Location = new System.Drawing.Point(178, 113);
            this.txttelf.Name = "txttelf";
            this.txttelf.Size = new System.Drawing.Size(146, 24);
            this.txttelf.TabIndex = 45;
            // 
            // txtrazon
            // 
            this.txtrazon.Enabled = false;
            this.txtrazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrazon.Location = new System.Drawing.Point(178, 73);
            this.txtrazon.Name = "txtrazon";
            this.txtrazon.Size = new System.Drawing.Size(146, 24);
            this.txtrazon.TabIndex = 44;
            // 
            // txtruc
            // 
            this.txtruc.Enabled = false;
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.Location = new System.Drawing.Point(178, 34);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(146, 24);
            this.txtruc.TabIndex = 43;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(41, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "Email:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(41, 118);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(65, 16);
            this.lbltelefono.TabIndex = 41;
            this.lbltelefono.Text = "Telefono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(41, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 16);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "Apellido:";
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblruc.Location = new System.Drawing.Point(41, 39);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(60, 16);
            this.lblruc.TabIndex = 39;
            this.lblruc.Text = "Nombre:";
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.Image = global::Formularios.Properties.Resources.file__3_;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(451, 236);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(100, 36);
            this.btnEditarCliente.TabIndex = 59;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 306);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.txtcomision);
            this.Controls.Add(this.lblcomision);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.datetimeFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdni);
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
            this.Name = "ModificarUsuario";
            this.Text = "ModificarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcomision;
        private System.Windows.Forms.Label lblcomision;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.DateTimePicker datetimeFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnEditarCliente;
    }
}