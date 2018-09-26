namespace Formularios
{
    partial class reporteprod
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateinicio = new System.Windows.Forms.DateTimePicker();
            this.graphProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.btnExportReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(38, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Rango de fecha :";
            // 
            // dateinicio
            // 
            this.dateinicio.CustomFormat = "MM-yyyy";
            this.dateinicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateinicio.Location = new System.Drawing.Point(204, 30);
            this.dateinicio.Name = "dateinicio";
            this.dateinicio.Size = new System.Drawing.Size(95, 20);
            this.dateinicio.TabIndex = 2;
            // 
            // graphProductos
            // 
            chartArea1.Name = "ChartArea1";
            this.graphProductos.ChartAreas.Add(chartArea1);
            legend1.Name = "Productos";
            this.graphProductos.Legends.Add(legend1);
            this.graphProductos.Location = new System.Drawing.Point(81, 72);
            this.graphProductos.Name = "graphProductos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Productos";
            series1.Name = "Productos";
            this.graphProductos.Series.Add(series1);
            this.graphProductos.Size = new System.Drawing.Size(492, 300);
            this.graphProductos.TabIndex = 3;
            this.graphProductos.Text = "chart1";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(164, 33);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "Inicio";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(361, 36);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(21, 13);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "Fin";
            // 
            // dateFin
            // 
            this.dateFin.CustomFormat = "MM-yyyy";
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFin.Location = new System.Drawing.Point(388, 30);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(92, 20);
            this.dateFin.TabIndex = 6;
            // 
            // btnExportReporte
            // 
            this.btnExportReporte.Location = new System.Drawing.Point(506, 30);
            this.btnExportReporte.Name = "btnExportReporte";
            this.btnExportReporte.Size = new System.Drawing.Size(122, 23);
            this.btnExportReporte.TabIndex = 7;
            this.btnExportReporte.Text = "Exportar Reporte";
            this.btnExportReporte.UseVisualStyleBackColor = true;
            // 
            // reporteprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 393);
            this.Controls.Add(this.btnExportReporte);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.graphProductos);
            this.Controls.Add(this.dateinicio);
            this.Controls.Add(this.lblFecha);
            this.Name = "reporteprod";
            this.Text = "reporteprod";
            ((System.ComponentModel.ISupportInitialize)(this.graphProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateinicio;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphProductos;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Button btnExportReporte;
    }
}