﻿namespace Formularios
{
    partial class Panel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOperarios = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTransportes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMantenimiento,
            this.menuPedido,
            this.menuAlmacen,
            this.menuReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMantenimiento
            // 
            this.menuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemClientes,
            this.itemVendedores,
            this.itemOperarios,
            this.itemTransportes,
            this.itemProveedores});
            this.menuMantenimiento.Name = "menuMantenimiento";
            this.menuMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.menuMantenimiento.Text = "Mantenimiento";
            // 
            // itemClientes
            // 
            this.itemClientes.Name = "itemClientes";
            this.itemClientes.Size = new System.Drawing.Size(152, 22);
            this.itemClientes.Text = "Clientes";
            // 
            // itemVendedores
            // 
            this.itemVendedores.Name = "itemVendedores";
            this.itemVendedores.Size = new System.Drawing.Size(152, 22);
            this.itemVendedores.Text = "Vendedores";
            // 
            // itemOperarios
            // 
            this.itemOperarios.Name = "itemOperarios";
            this.itemOperarios.Size = new System.Drawing.Size(152, 22);
            this.itemOperarios.Text = "Operarios";
            // 
            // itemTransportes
            // 
            this.itemTransportes.Name = "itemTransportes";
            this.itemTransportes.Size = new System.Drawing.Size(152, 22);
            this.itemTransportes.Text = "Transportistas";
            // 
            // itemProveedores
            // 
            this.itemProveedores.Name = "itemProveedores";
            this.itemProveedores.Size = new System.Drawing.Size(152, 22);
            this.itemProveedores.Text = "Proveedores";
            // 
            // menuPedido
            // 
            this.menuPedido.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFacturas});
            this.menuPedido.Name = "menuPedido";
            this.menuPedido.Size = new System.Drawing.Size(56, 20);
            this.menuPedido.Text = "Pedido";
            // 
            // itemFacturas
            // 
            this.itemFacturas.Name = "itemFacturas";
            this.itemFacturas.Size = new System.Drawing.Size(118, 22);
            this.itemFacturas.Text = "Facturas";
            // 
            // menuAlmacen
            // 
            this.menuAlmacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemProductos,
            this.itemAlmacen});
            this.menuAlmacen.Name = "menuAlmacen";
            this.menuAlmacen.Size = new System.Drawing.Size(66, 20);
            this.menuAlmacen.Text = "Almacen";
            // 
            // itemProductos
            // 
            this.itemProductos.Name = "itemProductos";
            this.itemProductos.Size = new System.Drawing.Size(191, 22);
            this.itemProductos.Text = "Productos";
            // 
            // itemAlmacen
            // 
            this.itemAlmacen.Name = "itemAlmacen";
            this.itemAlmacen.Size = new System.Drawing.Size(191, 22);
            this.itemAlmacen.Text = "Gestion de Almacenes";
            // 
            // menuReportes
            // 
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(65, 20);
            this.menuReportes.Text = "Reportes";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Panel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem itemClientes;
        private System.Windows.Forms.ToolStripMenuItem itemVendedores;
        private System.Windows.Forms.ToolStripMenuItem itemOperarios;
        private System.Windows.Forms.ToolStripMenuItem menuPedido;
        private System.Windows.Forms.ToolStripMenuItem itemTransportes;
        private System.Windows.Forms.ToolStripMenuItem itemProveedores;
        private System.Windows.Forms.ToolStripMenuItem itemFacturas;
        private System.Windows.Forms.ToolStripMenuItem menuAlmacen;
        private System.Windows.Forms.ToolStripMenuItem itemProductos;
        private System.Windows.Forms.ToolStripMenuItem itemAlmacen;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
    }
}