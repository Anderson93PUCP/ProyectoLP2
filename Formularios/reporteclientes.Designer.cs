﻿namespace Formularios
{
    partial class reporteclientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporteclientes));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dateinicio = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.dataListaClientes = new System.Windows.Forms.DataGridView();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExportReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(39, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Rango de fecha :";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(171, 33);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 5;
            this.lblInicio.Text = "Inicio";
            // 
            // dateinicio
            // 
            this.dateinicio.CustomFormat = "MM-yyyy";
            this.dateinicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateinicio.Location = new System.Drawing.Point(209, 28);
            this.dateinicio.Name = "dateinicio";
            this.dateinicio.Size = new System.Drawing.Size(95, 20);
            this.dateinicio.TabIndex = 6;
            // 
            // dateFin
            // 
            this.dateFin.CustomFormat = "MM-yyyy";
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFin.Location = new System.Drawing.Point(407, 29);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(92, 20);
            this.dateFin.TabIndex = 9;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(380, 34);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(21, 13);
            this.lblFin.TabIndex = 8;
            this.lblFin.Text = "Fin";
            // 
            // dataListaClientes
            // 
            this.dataListaClientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RUC,
            this.Nombre,
            this.Cantidad,
            this.Producto,
            this.Monto});
            this.dataListaClientes.Location = new System.Drawing.Point(76, 83);
            this.dataListaClientes.Name = "dataListaClientes";
            this.dataListaClientes.Size = new System.Drawing.Size(577, 296);
            this.dataListaClientes.TabIndex = 11;
            // 
            // RUC
            // 
            this.RUC.HeaderText = "RUC";
            this.RUC.Name = "RUC";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Total (S/.)";
            this.Monto.Name = "Monto";
            // 
            // button1
            // 
            this.button1.Image = global::Formularios.Properties.Resources.back__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(310, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Regresar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExportReporte
            // 
            this.btnExportReporte.Image = global::Formularios.Properties.Resources.file__2_;
            this.btnExportReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportReporte.Location = new System.Drawing.Point(557, 21);
            this.btnExportReporte.Name = "btnExportReporte";
            this.btnExportReporte.Size = new System.Drawing.Size(116, 40);
            this.btnExportReporte.TabIndex = 10;
            this.btnExportReporte.Text = "Exportar Reporte";
            this.btnExportReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportReporte.UseVisualStyleBackColor = true;
            this.btnExportReporte.Click += new System.EventHandler(this.btnExportReporte_Click);
            // 
            // reporteclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataListaClientes);
            this.Controls.Add(this.btnExportReporte);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.dateinicio);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reporteclientes";
            this.Text = "Reporte de Utilidad de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dateinicio;
        private System.Windows.Forms.Button btnExportReporte;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DataGridView dataListaClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}