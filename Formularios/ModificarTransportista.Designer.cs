﻿namespace Formularios
{
    partial class ModificarTransportista
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.rbtDepartamentos = new System.Windows.Forms.RadioButton();
            this.rbtNacional = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txttelf = new System.Windows.Forms.TextBox();
            this.txtrazon = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.lbldirecciones = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblruc = new System.Windows.Forms.Label();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbemailmod = new System.Windows.Forms.PictureBox();
            this.pbdirecmod = new System.Windows.Forms.PictureBox();
            this.pbtelefonomod = new System.Windows.Forms.PictureBox();
            this.pbnombremod = new System.Windows.Forms.PictureBox();
            this.pbrucmod = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbemailmod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdirecmod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtelefonomod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnombremod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrucmod)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = global::Formularios.Properties.Resources.cross;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(229, 293);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 36);
            this.btncancelar.TabIndex = 48;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = global::Formularios.Properties.Resources.check;
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaceptar.Location = new System.Drawing.Point(45, 294);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(86, 36);
            this.btnaceptar.TabIndex = 47;
            this.btnaceptar.Text = "Modificar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // rbtDepartamentos
            // 
            this.rbtDepartamentos.AutoSize = true;
            this.rbtDepartamentos.Enabled = false;
            this.rbtDepartamentos.Location = new System.Drawing.Point(168, 257);
            this.rbtDepartamentos.Name = "rbtDepartamentos";
            this.rbtDepartamentos.Size = new System.Drawing.Size(116, 17);
            this.rbtDepartamentos.TabIndex = 46;
            this.rbtDepartamentos.TabStop = true;
            this.rbtDepartamentos.Text = "Por Departamentos";
            this.rbtDepartamentos.UseVisualStyleBackColor = true;
            // 
            // rbtNacional
            // 
            this.rbtNacional.AutoSize = true;
            this.rbtNacional.Enabled = false;
            this.rbtNacional.Location = new System.Drawing.Point(168, 234);
            this.rbtNacional.Name = "rbtNacional";
            this.rbtNacional.Size = new System.Drawing.Size(67, 17);
            this.rbtNacional.TabIndex = 45;
            this.rbtNacional.TabStop = true;
            this.rbtNacional.Text = "Nacional";
            this.rbtNacional.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Alcance:";
            // 
            // txttelf
            // 
            this.txttelf.Enabled = false;
            this.txttelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelf.Location = new System.Drawing.Point(168, 108);
            this.txttelf.Name = "txttelf";
            this.txttelf.Size = new System.Drawing.Size(146, 24);
            this.txttelf.TabIndex = 42;
            // 
            // txtrazon
            // 
            this.txtrazon.Enabled = false;
            this.txtrazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrazon.Location = new System.Drawing.Point(168, 68);
            this.txtrazon.Name = "txtrazon";
            this.txtrazon.Size = new System.Drawing.Size(146, 24);
            this.txtrazon.TabIndex = 41;
            // 
            // txtruc
            // 
            this.txtruc.Enabled = false;
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.Location = new System.Drawing.Point(168, 29);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(146, 24);
            this.txtruc.TabIndex = 40;
            // 
            // lbldirecciones
            // 
            this.lbldirecciones.AutoSize = true;
            this.lbldirecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldirecciones.Location = new System.Drawing.Point(31, 155);
            this.lbldirecciones.Name = "lbldirecciones";
            this.lbldirecciones.Size = new System.Drawing.Size(83, 16);
            this.lbldirecciones.TabIndex = 39;
            this.lbldirecciones.Text = "Direcciones:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(31, 113);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(65, 16);
            this.lbltelefono.TabIndex = 38;
            this.lbltelefono.Text = "Telefono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(113, 16);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre o Razon:";
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblruc.Location = new System.Drawing.Point(31, 34);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(40, 16);
            this.lblruc.TabIndex = 36;
            this.lblruc.Text = "RUC:";
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.Image = global::Formularios.Properties.Resources.file__3_;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(137, 293);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(86, 36);
            this.btnEditarCliente.TabIndex = 49;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(168, 150);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(146, 24);
            this.txtdireccion.TabIndex = 50;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(168, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 24);
            this.txtEmail.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Email:";
            // 
            // pbemailmod
            // 
            this.pbemailmod.Location = new System.Drawing.Point(320, 189);
            this.pbemailmod.Name = "pbemailmod";
            this.pbemailmod.Size = new System.Drawing.Size(29, 28);
            this.pbemailmod.TabIndex = 57;
            this.pbemailmod.TabStop = false;
            // 
            // pbdirecmod
            // 
            this.pbdirecmod.Location = new System.Drawing.Point(320, 146);
            this.pbdirecmod.Name = "pbdirecmod";
            this.pbdirecmod.Size = new System.Drawing.Size(29, 28);
            this.pbdirecmod.TabIndex = 56;
            this.pbdirecmod.TabStop = false;
            // 
            // pbtelefonomod
            // 
            this.pbtelefonomod.Location = new System.Drawing.Point(320, 104);
            this.pbtelefonomod.Name = "pbtelefonomod";
            this.pbtelefonomod.Size = new System.Drawing.Size(29, 28);
            this.pbtelefonomod.TabIndex = 55;
            this.pbtelefonomod.TabStop = false;
            // 
            // pbnombremod
            // 
            this.pbnombremod.Location = new System.Drawing.Point(320, 64);
            this.pbnombremod.Name = "pbnombremod";
            this.pbnombremod.Size = new System.Drawing.Size(29, 28);
            this.pbnombremod.TabIndex = 54;
            this.pbnombremod.TabStop = false;
            // 
            // pbrucmod
            // 
            this.pbrucmod.Location = new System.Drawing.Point(320, 25);
            this.pbrucmod.Name = "pbrucmod";
            this.pbrucmod.Size = new System.Drawing.Size(29, 28);
            this.pbrucmod.TabIndex = 53;
            this.pbrucmod.TabStop = false;
            // 
            // ModificarTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 344);
            this.Controls.Add(this.pbemailmod);
            this.Controls.Add(this.pbdirecmod);
            this.Controls.Add(this.pbtelefonomod);
            this.Controls.Add(this.pbnombremod);
            this.Controls.Add(this.pbrucmod);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.rbtDepartamentos);
            this.Controls.Add(this.rbtNacional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttelf);
            this.Controls.Add(this.txtrazon);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.lbldirecciones);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblruc);
            this.Name = "ModificarTransportista";
            this.Text = "ModificarTransportista";
            ((System.ComponentModel.ISupportInitialize)(this.pbemailmod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdirecmod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtelefonomod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnombremod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrucmod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.RadioButton rbtDepartamentos;
        private System.Windows.Forms.RadioButton rbtNacional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttelf;
        private System.Windows.Forms.TextBox txtrazon;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label lbldirecciones;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbemailmod;
        private System.Windows.Forms.PictureBox pbdirecmod;
        private System.Windows.Forms.PictureBox pbtelefonomod;
        private System.Windows.Forms.PictureBox pbnombremod;
        private System.Windows.Forms.PictureBox pbrucmod;
    }
}