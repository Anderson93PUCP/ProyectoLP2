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
            this.txttelf = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblruc = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimeFechaI = new System.Windows.Forms.DateTimePicker();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lblsalario = new System.Windows.Forms.Label();
            this.txtcomision = new System.Windows.Forms.TextBox();
            this.lblcomision = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbedad = new System.Windows.Forms.PictureBox();
            this.pbdni = new System.Windows.Forms.PictureBox();
            this.pbtelefono = new System.Windows.Forms.PictureBox();
            this.pbapellido = new System.Windows.Forms.PictureBox();
            this.pbnombre = new System.Windows.Forms.PictureBox();
            this.pbemail = new System.Windows.Forms.PictureBox();
            this.pbusuario = new System.Windows.Forms.PictureBox();
            this.pbcomision = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.dtpnacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbapellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcomision)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbrol
            // 
            this.cmbrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrol.FormattingEnabled = true;
            this.cmbrol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Operario"});
            this.cmbrol.Location = new System.Drawing.Point(460, 139);
            this.cmbrol.Name = "cmbrol";
            this.cmbrol.Size = new System.Drawing.Size(146, 21);
            this.cmbrol.TabIndex = 30;
            this.cmbrol.SelectedIndexChanged += new System.EventHandler(this.cmbvendedor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "ROL";
            // 
            // txttelf
            // 
            this.txttelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelf.Location = new System.Drawing.Point(177, 135);
            this.txttelf.MaxLength = 9;
            this.txttelf.Name = "txttelf";
            this.txttelf.Size = new System.Drawing.Size(146, 24);
            this.txttelf.TabIndex = 24;
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(177, 85);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(146, 24);
            this.txtapellido.TabIndex = 23;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(177, 36);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(146, 24);
            this.txtnombre.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 293);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(40, 140);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(53, 16);
            this.lbltelefono.TabIndex = 19;
            this.lbltelefono.Text = "Celular:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(40, 90);
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
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.Location = new System.Drawing.Point(177, 188);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(146, 24);
            this.txtdni.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha de Ingreso:";
            // 
            // datetimeFechaI
            // 
            this.datetimeFechaI.CustomFormat = "dd/MM/yyyy";
            this.datetimeFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeFechaI.Location = new System.Drawing.Point(177, 341);
            this.datetimeFechaI.MinDate = new System.DateTime(2018, 11, 27, 0, 0, 0, 0);
            this.datetimeFechaI.Name = "datetimeFechaI";
            this.datetimeFechaI.Size = new System.Drawing.Size(146, 20);
            this.datetimeFechaI.TabIndex = 28;
            this.datetimeFechaI.Value = new System.DateTime(2018, 11, 27, 0, 32, 28, 0);
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(460, 185);
            this.txtsalario.MaxLength = 9;
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(81, 24);
            this.txtsalario.TabIndex = 36;
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalario.Location = new System.Drawing.Point(367, 190);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(81, 16);
            this.lblsalario.TabIndex = 35;
            this.lblsalario.Text = "Salario (S/.):";
            // 
            // txtcomision
            // 
            this.txtcomision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomision.Location = new System.Drawing.Point(460, 185);
            this.txtcomision.MaxLength = 5;
            this.txtcomision.Name = "txtcomision";
            this.txtcomision.Size = new System.Drawing.Size(81, 24);
            this.txtcomision.TabIndex = 33;
            this.txtcomision.Visible = false;
            // 
            // lblcomision
            // 
            this.lblcomision.AutoSize = true;
            this.lblcomision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomision.Location = new System.Drawing.Point(367, 190);
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
            this.btncancelar.Location = new System.Drawing.Point(506, 331);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 36);
            this.btncancelar.TabIndex = 38;
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
            this.btnaceptar.Location = new System.Drawing.Point(370, 331);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(100, 36);
            this.btnaceptar.TabIndex = 34;
            this.btnaceptar.Text = "Registrar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(460, 85);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.ReadOnly = true;
            this.txtcontraseña.Size = new System.Drawing.Size(146, 24);
            this.txtcontraseña.TabIndex = 42;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(460, 36);
            this.txtusuario.MaxLength = 20;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(146, 24);
            this.txtusuario.TabIndex = 29;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.Location = new System.Drawing.Point(367, 90);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(80, 16);
            this.lblcontraseña.TabIndex = 40;
            this.lblcontraseña.Text = "Contraseña:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(367, 41);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(58, 16);
            this.lblusuario.TabIndex = 39;
            this.lblusuario.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha Nacimiento:";
            // 
            // pbedad
            // 
            this.pbedad.Location = new System.Drawing.Point(329, 234);
            this.pbedad.Name = "pbedad";
            this.pbedad.Size = new System.Drawing.Size(29, 28);
            this.pbedad.TabIndex = 62;
            this.pbedad.TabStop = false;
            // 
            // pbdni
            // 
            this.pbdni.Location = new System.Drawing.Point(329, 182);
            this.pbdni.Name = "pbdni";
            this.pbdni.Size = new System.Drawing.Size(29, 28);
            this.pbdni.TabIndex = 61;
            this.pbdni.TabStop = false;
            // 
            // pbtelefono
            // 
            this.pbtelefono.Location = new System.Drawing.Point(329, 131);
            this.pbtelefono.Name = "pbtelefono";
            this.pbtelefono.Size = new System.Drawing.Size(29, 28);
            this.pbtelefono.TabIndex = 60;
            this.pbtelefono.TabStop = false;
            // 
            // pbapellido
            // 
            this.pbapellido.Location = new System.Drawing.Point(329, 81);
            this.pbapellido.Name = "pbapellido";
            this.pbapellido.Size = new System.Drawing.Size(29, 28);
            this.pbapellido.TabIndex = 59;
            this.pbapellido.TabStop = false;
            // 
            // pbnombre
            // 
            this.pbnombre.Location = new System.Drawing.Point(329, 32);
            this.pbnombre.Name = "pbnombre";
            this.pbnombre.Size = new System.Drawing.Size(29, 28);
            this.pbnombre.TabIndex = 58;
            this.pbnombre.TabStop = false;
            // 
            // pbemail
            // 
            this.pbemail.Location = new System.Drawing.Point(329, 284);
            this.pbemail.Name = "pbemail";
            this.pbemail.Size = new System.Drawing.Size(29, 28);
            this.pbemail.TabIndex = 63;
            this.pbemail.TabStop = false;
            // 
            // pbusuario
            // 
            this.pbusuario.Location = new System.Drawing.Point(618, 32);
            this.pbusuario.Name = "pbusuario";
            this.pbusuario.Size = new System.Drawing.Size(29, 28);
            this.pbusuario.TabIndex = 64;
            this.pbusuario.TabStop = false;
            // 
            // pbcomision
            // 
            this.pbcomision.Location = new System.Drawing.Point(547, 182);
            this.pbcomision.Name = "pbcomision";
            this.pbcomision.Size = new System.Drawing.Size(29, 28);
            this.pbcomision.TabIndex = 66;
            this.pbcomision.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(174, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "(Obligatorio)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(174, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "(Obligatorio)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(174, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "(Obligatorio)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(174, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "(Obligatorio)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(174, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "(Obligatorio)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(174, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "(Obligatorio)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(457, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "(Obligatorio)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(457, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "(Obligatorio)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label13.Location = new System.Drawing.Point(457, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "(Obligatorio)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Location = new System.Drawing.Point(457, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "(Obligatorio)";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(177, 288);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(146, 24);
            this.txtemail.TabIndex = 27;
            // 
            // dtpnacimiento
            // 
            this.dtpnacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpnacimiento.Location = new System.Drawing.Point(177, 238);
            this.dtpnacimiento.MinDate = new System.DateTime(1800, 11, 27, 0, 0, 0, 0);
            this.dtpnacimiento.Name = "dtpnacimiento";
            this.dtpnacimiento.Size = new System.Drawing.Size(146, 20);
            this.dtpnacimiento.TabIndex = 26;
            this.dtpnacimiento.Value = new System.DateTime(2018, 11, 27, 0, 32, 28, 0);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 376);
            this.Controls.Add(this.dtpnacimiento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbcomision);
            this.Controls.Add(this.pbusuario);
            this.Controls.Add(this.pbemail);
            this.Controls.Add(this.pbedad);
            this.Controls.Add(this.pbdni);
            this.Controls.Add(this.pbtelefono);
            this.Controls.Add(this.pbapellido);
            this.Controls.Add(this.pbnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txtcomision);
            this.Controls.Add(this.lblcomision);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.datetimeFechaI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbrol);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelf);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblruc);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbapellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcomision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbrol;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttelf;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimeFechaI;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.TextBox txtcomision;
        private System.Windows.Forms.Label lblcomision;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbedad;
        private System.Windows.Forms.PictureBox pbdni;
        private System.Windows.Forms.PictureBox pbtelefono;
        private System.Windows.Forms.PictureBox pbapellido;
        private System.Windows.Forms.PictureBox pbnombre;
        private System.Windows.Forms.PictureBox pbemail;
        private System.Windows.Forms.PictureBox pbusuario;
        private System.Windows.Forms.PictureBox pbcomision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.DateTimePicker dtpnacimiento;
    }
}