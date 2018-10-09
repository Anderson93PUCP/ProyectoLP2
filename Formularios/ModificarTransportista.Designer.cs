namespace Formularios
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
            this.btndirecciones = new System.Windows.Forms.Button();
            this.txttelf = new System.Windows.Forms.TextBox();
            this.txtrazon = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.lbldirecciones = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblruc = new System.Windows.Forms.Label();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = global::Formularios.Properties.Resources.cross;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(218, 278);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 36);
            this.btncancelar.TabIndex = 48;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = global::Formularios.Properties.Resources.check;
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaceptar.Location = new System.Drawing.Point(34, 279);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(86, 36);
            this.btnaceptar.TabIndex = 47;
            this.btnaceptar.Text = "Registrar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // rbtDepartamentos
            // 
            this.rbtDepartamentos.AutoSize = true;
            this.rbtDepartamentos.Enabled = false;
            this.rbtDepartamentos.Location = new System.Drawing.Point(168, 219);
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
            this.rbtNacional.Location = new System.Drawing.Point(168, 196);
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
            this.label1.Location = new System.Drawing.Point(31, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Alcance:";
            // 
            // btndirecciones
            // 
            this.btndirecciones.Enabled = false;
            this.btndirecciones.Location = new System.Drawing.Point(168, 155);
            this.btndirecciones.Name = "btndirecciones";
            this.btndirecciones.Size = new System.Drawing.Size(146, 23);
            this.btndirecciones.TabIndex = 43;
            this.btndirecciones.Text = "...";
            this.btndirecciones.UseVisualStyleBackColor = true;
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
            this.btnEditarCliente.Location = new System.Drawing.Point(126, 278);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(86, 36);
            this.btnEditarCliente.TabIndex = 49;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // ModificarTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 332);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.rbtDepartamentos);
            this.Controls.Add(this.rbtNacional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndirecciones);
            this.Controls.Add(this.txttelf);
            this.Controls.Add(this.txtrazon);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.lbldirecciones);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblruc);
            this.Name = "ModificarTransportista";
            this.Text = "ModificarTransportista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.RadioButton rbtDepartamentos;
        private System.Windows.Forms.RadioButton rbtNacional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndirecciones;
        private System.Windows.Forms.TextBox txttelf;
        private System.Windows.Forms.TextBox txtrazon;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label lbldirecciones;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.Button btnEditarCliente;
    }
}