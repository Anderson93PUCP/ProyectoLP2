namespace Formularios
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnprod = new System.Windows.Forms.Button();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelVerticalAlmacen = new System.Windows.Forms.Panel();
            this.btnGestionAlmacenes = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.panelVerticalPedidos = new System.Windows.Forms.Panel();
            this.btnGestionPedidos = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.panelVerticalReportes = new System.Windows.Forms.Panel();
            this.btnReporteProductos = new System.Windows.Forms.Button();
            this.btnReporteClientes = new System.Windows.Forms.Button();
            this.panelVertical2 = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnTransportistas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panelVerticalPagos = new System.Windows.Forms.Panel();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelVerticalAlmacen.SuspendLayout();
            this.panelVerticalPedidos.SuspendLayout();
            this.panelVerticalReportes.SuspendLayout();
            this.panelVertical2.SuspendLayout();
            this.panelVerticalPagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.button6);
            this.MenuVertical.Controls.Add(this.button5);
            this.MenuVertical.Controls.Add(this.button4);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.btnprod);
            this.MenuVertical.Controls.Add(this.btnlogoInicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 790);
            this.MenuVertical.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::Formularios.Properties.Resources.reportes;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 301);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 40);
            this.button6.TabIndex = 12;
            this.button6.Text = "Reportes";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Formularios.Properties.Resources.pagos;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-3, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "Pagos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "Almacen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnprod
            // 
            this.btnprod.FlatAppearance.BorderSize = 0;
            this.btnprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprod.ForeColor = System.Drawing.Color.White;
            this.btnprod.Image = ((System.Drawing.Image)(resources.GetObject("btnprod.Image")));
            this.btnprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprod.Location = new System.Drawing.Point(0, 117);
            this.btnprod.Name = "btnprod";
            this.btnprod.Size = new System.Drawing.Size(250, 40);
            this.btnprod.TabIndex = 7;
            this.btnprod.Text = "Mantenimiento";
            this.btnprod.UseVisualStyleBackColor = true;
            this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoInicio.Location = new System.Drawing.Point(0, 0);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(258, 81);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnlogoInicio.TabIndex = 1;
            this.btnlogoInicio.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.btnslide);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(999, 12);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(18, 18);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 7;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(999, 12);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(18, 18);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 6;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(1023, 12);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 5;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.Location = new System.Drawing.Point(6, 9);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(35, 35);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 1;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconmaximizar.Image")));
            this.iconmaximizar.Location = new System.Drawing.Point(999, 12);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(18, 18);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 3;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Visible = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContenedor.Location = new System.Drawing.Point(438, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(862, 740);
            this.panelContenedor.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panelVerticalAlmacen);
            this.panel1.Controls.Add(this.panelVerticalPedidos);
            this.panel1.Controls.Add(this.panelVerticalReportes);
            this.panel1.Controls.Add(this.panelVertical2);
            this.panel1.Controls.Add(this.panelVerticalPagos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(250, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 740);
            this.panel1.TabIndex = 5;
            // 
            // panelVerticalAlmacen
            // 
            this.panelVerticalAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelVerticalAlmacen.Controls.Add(this.btnGestionAlmacenes);
            this.panelVerticalAlmacen.Controls.Add(this.btnProducto);
            this.panelVerticalAlmacen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVerticalAlmacen.Location = new System.Drawing.Point(752, 0);
            this.panelVerticalAlmacen.Name = "panelVerticalAlmacen";
            this.panelVerticalAlmacen.Size = new System.Drawing.Size(220, 740);
            this.panelVerticalAlmacen.TabIndex = 28;
            // 
            // btnGestionAlmacenes
            // 
            this.btnGestionAlmacenes.FlatAppearance.BorderSize = 0;
            this.btnGestionAlmacenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGestionAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionAlmacenes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAlmacenes.ForeColor = System.Drawing.Color.White;
            this.btnGestionAlmacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionAlmacenes.Location = new System.Drawing.Point(3, 77);
            this.btnGestionAlmacenes.Name = "btnGestionAlmacenes";
            this.btnGestionAlmacenes.Size = new System.Drawing.Size(185, 40);
            this.btnGestionAlmacenes.TabIndex = 20;
            this.btnGestionAlmacenes.Text = "Gestion de Almacenes";
            this.btnGestionAlmacenes.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(0, 31);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(185, 40);
            this.btnProducto.TabIndex = 19;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            // 
            // panelVerticalPedidos
            // 
            this.panelVerticalPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelVerticalPedidos.Controls.Add(this.btnGestionPedidos);
            this.panelVerticalPedidos.Controls.Add(this.btnFactura);
            this.panelVerticalPedidos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVerticalPedidos.Location = new System.Drawing.Point(564, 0);
            this.panelVerticalPedidos.Name = "panelVerticalPedidos";
            this.panelVerticalPedidos.Size = new System.Drawing.Size(188, 740);
            this.panelVerticalPedidos.TabIndex = 25;
            // 
            // btnGestionPedidos
            // 
            this.btnGestionPedidos.FlatAppearance.BorderSize = 0;
            this.btnGestionPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGestionPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPedidos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPedidos.ForeColor = System.Drawing.Color.White;
            this.btnGestionPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPedidos.Location = new System.Drawing.Point(0, 77);
            this.btnGestionPedidos.Name = "btnGestionPedidos";
            this.btnGestionPedidos.Size = new System.Drawing.Size(185, 40);
            this.btnGestionPedidos.TabIndex = 18;
            this.btnGestionPedidos.Text = "Gestion de Pedidos";
            this.btnGestionPedidos.UseVisualStyleBackColor = true;
            // 
            // btnFactura
            // 
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.White;
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(0, 31);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(185, 40);
            this.btnFactura.TabIndex = 17;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            // 
            // panelVerticalReportes
            // 
            this.panelVerticalReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelVerticalReportes.Controls.Add(this.btnReporteProductos);
            this.panelVerticalReportes.Controls.Add(this.btnReporteClientes);
            this.panelVerticalReportes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVerticalReportes.Location = new System.Drawing.Point(376, 0);
            this.panelVerticalReportes.Name = "panelVerticalReportes";
            this.panelVerticalReportes.Size = new System.Drawing.Size(188, 740);
            this.panelVerticalReportes.TabIndex = 26;
            // 
            // btnReporteProductos
            // 
            this.btnReporteProductos.FlatAppearance.BorderSize = 0;
            this.btnReporteProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReporteProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteProductos.ForeColor = System.Drawing.Color.White;
            this.btnReporteProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteProductos.Location = new System.Drawing.Point(3, 37);
            this.btnReporteProductos.Name = "btnReporteProductos";
            this.btnReporteProductos.Size = new System.Drawing.Size(185, 40);
            this.btnReporteProductos.TabIndex = 23;
            this.btnReporteProductos.Text = "Reporte Productos";
            this.btnReporteProductos.UseVisualStyleBackColor = true;
            // 
            // btnReporteClientes
            // 
            this.btnReporteClientes.FlatAppearance.BorderSize = 0;
            this.btnReporteClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReporteClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteClientes.ForeColor = System.Drawing.Color.White;
            this.btnReporteClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteClientes.Location = new System.Drawing.Point(3, 83);
            this.btnReporteClientes.Name = "btnReporteClientes";
            this.btnReporteClientes.Size = new System.Drawing.Size(185, 40);
            this.btnReporteClientes.TabIndex = 22;
            this.btnReporteClientes.Text = "Reporte de Clientes";
            this.btnReporteClientes.UseVisualStyleBackColor = true;
            // 
            // panelVertical2
            // 
            this.panelVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelVertical2.Controls.Add(this.btnProveedores);
            this.panelVertical2.Controls.Add(this.btnTransportistas);
            this.panelVertical2.Controls.Add(this.btnClientes);
            this.panelVertical2.Controls.Add(this.btnUsuarios);
            this.panelVertical2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical2.Location = new System.Drawing.Point(188, 0);
            this.panelVertical2.Name = "panelVertical2";
            this.panelVertical2.Size = new System.Drawing.Size(188, 740);
            this.panelVertical2.TabIndex = 23;
            // 
            // btnProveedores
            // 
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(-3, 175);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(185, 40);
            this.btnProveedores.TabIndex = 16;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnTransportistas
            // 
            this.btnTransportistas.FlatAppearance.BorderSize = 0;
            this.btnTransportistas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTransportistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransportistas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportistas.ForeColor = System.Drawing.Color.White;
            this.btnTransportistas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransportistas.Location = new System.Drawing.Point(0, 129);
            this.btnTransportistas.Name = "btnTransportistas";
            this.btnTransportistas.Size = new System.Drawing.Size(185, 40);
            this.btnTransportistas.TabIndex = 15;
            this.btnTransportistas.Text = "Transportistas";
            this.btnTransportistas.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 83);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(185, 40);
            this.btnClientes.TabIndex = 14;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 37);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(185, 40);
            this.btnUsuarios.TabIndex = 13;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // panelVerticalPagos
            // 
            this.panelVerticalPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelVerticalPagos.Controls.Add(this.btnVendedores);
            this.panelVerticalPagos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVerticalPagos.Location = new System.Drawing.Point(0, 0);
            this.panelVerticalPagos.Name = "panelVerticalPagos";
            this.panelVerticalPagos.Size = new System.Drawing.Size(188, 740);
            this.panelVerticalPagos.TabIndex = 24;
            // 
            // btnVendedores
            // 
            this.btnVendedores.FlatAppearance.BorderSize = 0;
            this.btnVendedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendedores.ForeColor = System.Drawing.Color.White;
            this.btnVendedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendedores.Location = new System.Drawing.Point(0, 37);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(185, 40);
            this.btnVendedores.TabIndex = 21;
            this.btnVendedores.Text = "Vendedores";
            this.btnVendedores.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 790);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelVerticalAlmacen.ResumeLayout(false);
            this.panelVerticalPedidos.ResumeLayout(false);
            this.panelVerticalReportes.ResumeLayout(false);
            this.panelVertical2.ResumeLayout(false);
            this.panelVerticalPagos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.PictureBox btnlogoInicio;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnprod;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelVerticalPedidos;
        private System.Windows.Forms.Button btnGestionPedidos;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Panel panelVerticalReportes;
        private System.Windows.Forms.Button btnReporteProductos;
        private System.Windows.Forms.Button btnReporteClientes;
        private System.Windows.Forms.Panel panelVertical2;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnTransportistas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panelVerticalAlmacen;
        private System.Windows.Forms.Button btnGestionAlmacenes;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Panel panelVerticalPagos;
        private System.Windows.Forms.Button btnVendedores;
    }
}