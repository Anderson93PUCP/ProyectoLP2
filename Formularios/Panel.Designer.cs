namespace Formularios
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
            this.gestionDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoDeAlmacenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeAlmacenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProductoDeAltoMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
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
            this.pagosToolStripMenuItem,
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
            this.itemClientes.Size = new System.Drawing.Size(148, 22);
            this.itemClientes.Text = "Clientes";
            // 
            // itemVendedores
            // 
            this.itemVendedores.Name = "itemVendedores";
            this.itemVendedores.Size = new System.Drawing.Size(148, 22);
            this.itemVendedores.Text = "Vendedores";
            // 
            // itemOperarios
            // 
            this.itemOperarios.Name = "itemOperarios";
            this.itemOperarios.Size = new System.Drawing.Size(148, 22);
            this.itemOperarios.Text = "Operarios";
            // 
            // itemTransportes
            // 
            this.itemTransportes.Name = "itemTransportes";
            this.itemTransportes.Size = new System.Drawing.Size(148, 22);
            this.itemTransportes.Text = "Transportistas";
            // 
            // itemProveedores
            // 
            this.itemProveedores.Name = "itemProveedores";
            this.itemProveedores.Size = new System.Drawing.Size(148, 22);
            this.itemProveedores.Text = "Proveedores";
            // 
            // menuPedido
            // 
            this.menuPedido.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFacturas,
            this.gestionDePedidosToolStripMenuItem});
            this.menuPedido.Name = "menuPedido";
            this.menuPedido.Size = new System.Drawing.Size(56, 20);
            this.menuPedido.Text = "Pedido";
            // 
            // itemFacturas
            // 
            this.itemFacturas.Name = "itemFacturas";
            this.itemFacturas.Size = new System.Drawing.Size(175, 22);
            this.itemFacturas.Text = "Facturas";
            this.itemFacturas.Click += new System.EventHandler(this.itemFacturas_Click);
            // 
            // gestionDePedidosToolStripMenuItem
            // 
            this.gestionDePedidosToolStripMenuItem.Name = "gestionDePedidosToolStripMenuItem";
            this.gestionDePedidosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.gestionDePedidosToolStripMenuItem.Text = "Gestion de Pedidos";
            this.gestionDePedidosToolStripMenuItem.Click += new System.EventHandler(this.gestionDePedidosToolStripMenuItem_Click);
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
            this.itemAlmacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientoDeAlmacenesToolStripMenuItem,
            this.mantenimientoDeAlmacenesToolStripMenuItem});
            this.itemAlmacen.Name = "itemAlmacen";
            this.itemAlmacen.Size = new System.Drawing.Size(191, 22);
            this.itemAlmacen.Text = "Gestion de Almacenes";
            // 
            // movimientoDeAlmacenesToolStripMenuItem
            // 
            this.movimientoDeAlmacenesToolStripMenuItem.Name = "movimientoDeAlmacenesToolStripMenuItem";
            this.movimientoDeAlmacenesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.movimientoDeAlmacenesToolStripMenuItem.Text = "Movimiento de Almacenes";
            // 
            // mantenimientoDeAlmacenesToolStripMenuItem
            // 
            this.mantenimientoDeAlmacenesToolStripMenuItem.Name = "mantenimientoDeAlmacenesToolStripMenuItem";
            this.mantenimientoDeAlmacenesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.mantenimientoDeAlmacenesToolStripMenuItem.Text = "Mantenimiento de Almacenes";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendedoresToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeProductoDeAltoMovimientoToolStripMenuItem,
            this.reporteDeClientesToolStripMenuItem});
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(65, 20);
            this.menuReportes.Text = "Reportes";
            // 
            // reporteDeProductoDeAltoMovimientoToolStripMenuItem
            // 
            this.reporteDeProductoDeAltoMovimientoToolStripMenuItem.Name = "reporteDeProductoDeAltoMovimientoToolStripMenuItem";
            this.reporteDeProductoDeAltoMovimientoToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.reporteDeProductoDeAltoMovimientoToolStripMenuItem.Text = "Reporte de Producto de alto movimiento";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.ToolStripMenuItem movimientoDeAlmacenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeAlmacenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProductoDeAltoMovimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}