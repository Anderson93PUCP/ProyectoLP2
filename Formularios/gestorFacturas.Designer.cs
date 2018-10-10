namespace Formularios
{
    partial class gestorFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestorFacturas));
            this.btnAddFactura = new System.Windows.Forms.Button();
            this.btnElimFactura = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIDGestorFacturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRUCGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedorGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoGestorFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFactura
            // 
            this.btnAddFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFactura.Image = global::Formularios.Properties.Resources.plus__1_;
            this.btnAddFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFactura.Location = new System.Drawing.Point(56, 33);
            this.btnAddFactura.Name = "btnAddFactura";
            this.btnAddFactura.Size = new System.Drawing.Size(102, 50);
            this.btnAddFactura.TabIndex = 0;
            this.btnAddFactura.Text = "    Agregar";
            this.btnAddFactura.UseVisualStyleBackColor = true;
            this.btnAddFactura.Click += new System.EventHandler(this.btnAddFactura_Click);
            // 
            // btnElimFactura
            // 
            this.btnElimFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimFactura.Image = global::Formularios.Properties.Resources._008_document;
            this.btnElimFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimFactura.Location = new System.Drawing.Point(206, 33);
            this.btnElimFactura.Name = "btnElimFactura";
            this.btnElimFactura.Size = new System.Drawing.Size(102, 50);
            this.btnElimFactura.TabIndex = 1;
            this.btnElimFactura.Text = "    Eliminar";
            this.btnElimFactura.UseVisualStyleBackColor = true;
            this.btnElimFactura.Click += new System.EventHandler(this.btnElimFactura_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(341, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por Vendedor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(482, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nombre Cliente";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(428, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "RUC";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Formularios.Properties.Resources._015_search1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(504, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Buscar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDGestorFacturas,
            this.colRUCGestorFactura,
            this.colClienteGestorFactura,
            this.colVendedorGestorFactura,
            this.colFechaEGestorFactura,
            this.colEstadoGestorFactura});
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // colIDGestorFacturas
            // 
            this.colIDGestorFacturas.HeaderText = "ID";
            this.colIDGestorFacturas.Name = "colIDGestorFacturas";
            this.colIDGestorFacturas.ReadOnly = true;
            // 
            // colRUCGestorFactura
            // 
            this.colRUCGestorFactura.HeaderText = "RUC";
            this.colRUCGestorFactura.Name = "colRUCGestorFactura";
            this.colRUCGestorFactura.ReadOnly = true;
            // 
            // colClienteGestorFactura
            // 
            this.colClienteGestorFactura.HeaderText = "Cliente";
            this.colClienteGestorFactura.Name = "colClienteGestorFactura";
            this.colClienteGestorFactura.ReadOnly = true;
            // 
            // colVendedorGestorFactura
            // 
            this.colVendedorGestorFactura.HeaderText = "Vendedor";
            this.colVendedorGestorFactura.Name = "colVendedorGestorFactura";
            this.colVendedorGestorFactura.ReadOnly = true;
            // 
            // colFechaEGestorFactura
            // 
            this.colFechaEGestorFactura.HeaderText = "Fecha Emision";
            this.colFechaEGestorFactura.Name = "colFechaEGestorFactura";
            this.colFechaEGestorFactura.ReadOnly = true;
            // 
            // colEstadoGestorFactura
            // 
            this.colEstadoGestorFactura.HeaderText = "Estado";
            this.colEstadoGestorFactura.Name = "colEstadoGestorFactura";
            this.colEstadoGestorFactura.ReadOnly = true;
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Image = global::Formularios.Properties.Resources.file;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(504, 65);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 28);
            this.btnVer.TabIndex = 9;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarFactura.Image = global::Formularios.Properties.Resources.back__1_;
            this.btnCancelarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarFactura.Location = new System.Drawing.Point(311, 273);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(96, 42);
            this.btnCancelarFactura.TabIndex = 2;
            this.btnCancelarFactura.Text = "    &Regresar";
            this.btnCancelarFactura.UseVisualStyleBackColor = true;
            this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
            // 
            // gestorFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 337);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelarFactura);
            this.Controls.Add(this.btnElimFactura);
            this.Controls.Add(this.btnAddFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestorFacturas";
            this.Text = "Gestion de Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFactura;
        private System.Windows.Forms.Button btnElimFactura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDGestorFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRUCGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedorGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEGestorFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoGestorFactura;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnCancelarFactura;
    }
}