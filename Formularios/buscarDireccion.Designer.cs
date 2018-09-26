namespace Formularios
{
    partial class buscarDireccion
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
            this.rbtnDep = new System.Windows.Forms.RadioButton();
            this.rbtnProv = new System.Windows.Forms.RadioButton();
            this.rbtnDist = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarDire = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIDBuscarDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirecBuscarDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepBuscaDire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvBuscarDirec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistBuscarDire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAcpetarBuscDire = new System.Windows.Forms.Button();
            this.btnCancelarBuscarDire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnDep
            // 
            this.rbtnDep.AutoSize = true;
            this.rbtnDep.Location = new System.Drawing.Point(22, 13);
            this.rbtnDep.Name = "rbtnDep";
            this.rbtnDep.Size = new System.Drawing.Size(92, 17);
            this.rbtnDep.TabIndex = 0;
            this.rbtnDep.TabStop = true;
            this.rbtnDep.Text = "Departamento";
            this.rbtnDep.UseVisualStyleBackColor = true;
            // 
            // rbtnProv
            // 
            this.rbtnProv.AutoSize = true;
            this.rbtnProv.Location = new System.Drawing.Point(180, 12);
            this.rbtnProv.Name = "rbtnProv";
            this.rbtnProv.Size = new System.Drawing.Size(69, 17);
            this.rbtnProv.TabIndex = 1;
            this.rbtnProv.TabStop = true;
            this.rbtnProv.Text = "Provincia";
            this.rbtnProv.UseVisualStyleBackColor = true;
            // 
            // rbtnDist
            // 
            this.rbtnDist.AutoSize = true;
            this.rbtnDist.Location = new System.Drawing.Point(117, 13);
            this.rbtnDist.Name = "rbtnDist";
            this.rbtnDist.Size = new System.Drawing.Size(57, 17);
            this.rbtnDist.TabIndex = 2;
            this.rbtnDist.TabStop = true;
            this.rbtnDist.Text = "Distrito";
            this.rbtnDist.UseVisualStyleBackColor = true;
            this.rbtnDist.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnBuscarDire
            // 
            this.btnBuscarDire.Location = new System.Drawing.Point(204, 33);
            this.btnBuscarDire.Name = "btnBuscarDire";
            this.btnBuscarDire.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDire.TabIndex = 4;
            this.btnBuscarDire.Text = "Buscar...";
            this.btnBuscarDire.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDBuscarDir,
            this.colDirecBuscarDireccion,
            this.colDepBuscaDire,
            this.colProvBuscarDirec,
            this.colDistBuscarDire});
            this.dataGridView1.Location = new System.Drawing.Point(22, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colIDBuscarDir
            // 
            this.colIDBuscarDir.HeaderText = "ID";
            this.colIDBuscarDir.Name = "colIDBuscarDir";
            this.colIDBuscarDir.ReadOnly = true;
            // 
            // colDirecBuscarDireccion
            // 
            this.colDirecBuscarDireccion.HeaderText = "Direccion";
            this.colDirecBuscarDireccion.Name = "colDirecBuscarDireccion";
            this.colDirecBuscarDireccion.ReadOnly = true;
            // 
            // colDepBuscaDire
            // 
            this.colDepBuscaDire.HeaderText = "Departamento";
            this.colDepBuscaDire.Name = "colDepBuscaDire";
            this.colDepBuscaDire.ReadOnly = true;
            // 
            // colProvBuscarDirec
            // 
            this.colProvBuscarDirec.HeaderText = "Provincia";
            this.colProvBuscarDirec.Name = "colProvBuscarDirec";
            this.colProvBuscarDirec.ReadOnly = true;
            // 
            // colDistBuscarDire
            // 
            this.colDistBuscarDire.HeaderText = "Distrito";
            this.colDistBuscarDire.Name = "colDistBuscarDire";
            this.colDistBuscarDire.ReadOnly = true;
            // 
            // btnAcpetarBuscDire
            // 
            this.btnAcpetarBuscDire.Location = new System.Drawing.Point(474, 238);
            this.btnAcpetarBuscDire.Name = "btnAcpetarBuscDire";
            this.btnAcpetarBuscDire.Size = new System.Drawing.Size(75, 23);
            this.btnAcpetarBuscDire.TabIndex = 6;
            this.btnAcpetarBuscDire.Text = "Aceptar";
            this.btnAcpetarBuscDire.UseVisualStyleBackColor = true;
            this.btnAcpetarBuscDire.Click += new System.EventHandler(this.btnAcpetarBuscDire_Click);
            // 
            // btnCancelarBuscarDire
            // 
            this.btnCancelarBuscarDire.Location = new System.Drawing.Point(380, 238);
            this.btnCancelarBuscarDire.Name = "btnCancelarBuscarDire";
            this.btnCancelarBuscarDire.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBuscarDire.TabIndex = 7;
            this.btnCancelarBuscarDire.Text = "Cancelar";
            this.btnCancelarBuscarDire.UseVisualStyleBackColor = true;
            this.btnCancelarBuscarDire.Click += new System.EventHandler(this.btnCancelarBuscarDire_Click);
            // 
            // buscarDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 273);
            this.Controls.Add(this.btnCancelarBuscarDire);
            this.Controls.Add(this.btnAcpetarBuscDire);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarDire);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnDist);
            this.Controls.Add(this.rbtnProv);
            this.Controls.Add(this.rbtnDep);
            this.Name = "buscarDireccion";
            this.Text = "buscarDireccion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnDep;
        private System.Windows.Forms.RadioButton rbtnProv;
        private System.Windows.Forms.RadioButton rbtnDist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarDire;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDBuscarDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirecBuscarDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepBuscaDire;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvBuscarDirec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistBuscarDire;
        private System.Windows.Forms.Button btnAcpetarBuscDire;
        private System.Windows.Forms.Button btnCancelarBuscarDire;
    }
}