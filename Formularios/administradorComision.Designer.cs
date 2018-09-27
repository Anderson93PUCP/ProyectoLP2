namespace Formularios
{
    partial class administradorComision
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPagarCom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colIDAdmCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteAdmCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente1AdmCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedorAdmCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoAAdmCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoAdmCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDAdmCom,
            this.colClienteAdmCom,
            this.colCliente1AdmCom,
            this.colVendedorAdmCom,
            this.colMontoAAdmCom,
            this.colEstadoAdmCom});
            this.dataGridView1.Location = new System.Drawing.Point(23, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPagarCom
            // 
            this.btnPagarCom.Location = new System.Drawing.Point(555, 28);
            this.btnPagarCom.Name = "btnPagarCom";
            this.btnPagarCom.Size = new System.Drawing.Size(98, 33);
            this.btnPagarCom.TabIndex = 3;
            this.btnPagarCom.Text = "Pagar";
            this.btnPagarCom.UseVisualStyleBackColor = true;
            this.btnPagarCom.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(471, 308);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(427, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vendedor:";
            // 
            // colIDAdmCom
            // 
            this.colIDAdmCom.HeaderText = "ID";
            this.colIDAdmCom.Name = "colIDAdmCom";
            this.colIDAdmCom.ReadOnly = true;
            // 
            // colClienteAdmCom
            // 
            this.colClienteAdmCom.HeaderText = "Ruc";
            this.colClienteAdmCom.Name = "colClienteAdmCom";
            this.colClienteAdmCom.ReadOnly = true;
            // 
            // colCliente1AdmCom
            // 
            this.colCliente1AdmCom.HeaderText = "Razon Social";
            this.colCliente1AdmCom.Name = "colCliente1AdmCom";
            this.colCliente1AdmCom.ReadOnly = true;
            // 
            // colVendedorAdmCom
            // 
            this.colVendedorAdmCom.HeaderText = "Vendedor";
            this.colVendedorAdmCom.Name = "colVendedorAdmCom";
            this.colVendedorAdmCom.ReadOnly = true;
            // 
            // colMontoAAdmCom
            // 
            this.colMontoAAdmCom.HeaderText = "Comision";
            this.colMontoAAdmCom.Name = "colMontoAAdmCom";
            this.colMontoAAdmCom.ReadOnly = true;
            // 
            // colEstadoAdmCom
            // 
            this.colEstadoAdmCom.HeaderText = "Estado";
            this.colEstadoAdmCom.Name = "colEstadoAdmCom";
            this.colEstadoAdmCom.ReadOnly = true;
            // 
            // administradorComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPagarCom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "administradorComision";
            this.Text = "administradorComision";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDAdmCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteAdmCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente1AdmCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedorAdmCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoAAdmCom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPagarCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoAdmCom;
    }
}