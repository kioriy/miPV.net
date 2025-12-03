namespace miPV
{
    partial class PuntoDeVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntoDeVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdPagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lBusqueda = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.lNotificaciones = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdBuscarProducto = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnProducto = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCliente = new System.Windows.Forms.ToolStripButton();
            this.tsBtnProveedor = new System.Windows.Forms.ToolStripButton();
            this.tsBtnConsulta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBascula = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnActualizarVenta = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancelarVenta = new System.Windows.Forms.ToolStripButton();
            this.tsBtnReimprimirTicket = new System.Windows.Forms.ToolStripButton();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.btnMostrarCbCliente = new System.Windows.Forms.Button();
            this.chbCredito = new System.Windows.Forms.CheckBox();
            this.lClienteVenta = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lDescuento = new System.Windows.Forms.Label();
            this.chkDescuento = new System.Windows.Forms.CheckBox();
            this.btnVenta = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPagar
            // 
            this.cmdPagar.BackColor = System.Drawing.Color.Transparent;
            this.cmdPagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPagar.BackgroundImage")));
            this.cmdPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdPagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdPagar.FlatAppearance.BorderSize = 0;
            this.cmdPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPagar.Location = new System.Drawing.Point(565, 433);
            this.cmdPagar.Name = "cmdPagar";
            this.cmdPagar.Size = new System.Drawing.Size(117, 75);
            this.cmdPagar.TabIndex = 4;
            this.cmdPagar.Text = " ";
            this.cmdPagar.UseVisualStyleBackColor = false;
            this.cmdPagar.Click += new System.EventHandler(this.cmdPagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(787, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // txtPago
            // 
            this.txtPago.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.ForeColor = System.Drawing.Color.Lime;
            this.txtPago.Location = new System.Drawing.Point(15, 458);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(150, 53);
            this.txtPago.TabIndex = 2;
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // lBusqueda
            // 
            this.lBusqueda.AutoSize = true;
            this.lBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBusqueda.Location = new System.Drawing.Point(11, 101);
            this.lBusqueda.Name = "lBusqueda";
            this.lBusqueda.Size = new System.Drawing.Size(68, 24);
            this.lBusqueda.TabIndex = 13;
            this.lBusqueda.Text = "codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Red;
            this.txtCodigo.Location = new System.Drawing.Point(79, 98);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(574, 31);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lTotal.Location = new System.Drawing.Point(733, 461);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(75, 46);
            this.lTotal.TabIndex = 16;
            this.lTotal.Text = "0.0";
            // 
            // lNotificaciones
            // 
            this.lNotificaciones.AutoSize = true;
            this.lNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotificaciones.ForeColor = System.Drawing.Color.Red;
            this.lNotificaciones.Location = new System.Drawing.Point(12, 524);
            this.lNotificaciones.Name = "lNotificaciones";
            this.lNotificaciones.Size = new System.Drawing.Size(153, 25);
            this.lNotificaciones.TabIndex = 18;
            this.lNotificaciones.Text = "Notificaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(700, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 46);
            this.label6.TabIndex = 19;
            this.label6.Text = "$";
            // 
            // cmdBuscarProducto
            // 
            this.cmdBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.cmdBuscarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdBuscarProducto.BackgroundImage")));
            this.cmdBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdBuscarProducto.FlatAppearance.BorderSize = 0;
            this.cmdBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.cmdBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscarProducto.Location = new System.Drawing.Point(734, 97);
            this.cmdBuscarProducto.Name = "cmdBuscarProducto";
            this.cmdBuscarProducto.Size = new System.Drawing.Size(39, 32);
            this.cmdBuscarProducto.TabIndex = 21;
            this.cmdBuscarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdBuscarProducto.UseVisualStyleBackColor = false;
            this.cmdBuscarProducto.Click += new System.EventHandler(this.cmdBuscarProducto_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.Transparent;
            this.btnActividades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActividades.BackgroundImage")));
            this.btnActividades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActividades.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnActividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.Location = new System.Drawing.Point(349, 438);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(117, 75);
            this.btnActividades.TabIndex = 27;
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Visible = false;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnProducto,
            this.tsBtnCliente,
            this.tsBtnProveedor,
            this.tsBtnConsulta,
            this.toolStripSeparator1,
            this.tsBtnBascula,
            this.tsBtnLimpiar,
            this.tsBtnActualizarVenta,
            this.tsBtnCancelarVenta,
            this.tsBtnReimprimirTicket});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(940, 87);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnProducto
            // 
            this.tsBtnProducto.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnProducto.Image")));
            this.tsBtnProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnProducto.Name = "tsBtnProducto";
            this.tsBtnProducto.Size = new System.Drawing.Size(68, 84);
            this.tsBtnProducto.Text = "Producto";
            this.tsBtnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnProducto.Click += new System.EventHandler(this.tsBtnProducto_Click);
            // 
            // tsBtnCliente
            // 
            this.tsBtnCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCliente.Image")));
            this.tsBtnCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCliente.Name = "tsBtnCliente";
            this.tsBtnCliente.Size = new System.Drawing.Size(68, 84);
            this.tsBtnCliente.Text = "Cliente";
            this.tsBtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnCliente.Click += new System.EventHandler(this.tsBtnCliente_Click);
            // 
            // tsBtnProveedor
            // 
            this.tsBtnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnProveedor.Image")));
            this.tsBtnProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnProveedor.Name = "tsBtnProveedor";
            this.tsBtnProveedor.Size = new System.Drawing.Size(68, 84);
            this.tsBtnProveedor.Text = "Proveedor";
            this.tsBtnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnProveedor.Click += new System.EventHandler(this.tsBtnProveedor_Click);
            // 
            // tsBtnConsulta
            // 
            this.tsBtnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnConsulta.Image")));
            this.tsBtnConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnConsulta.Name = "tsBtnConsulta";
            this.tsBtnConsulta.Size = new System.Drawing.Size(68, 84);
            this.tsBtnConsulta.Text = "Consulta";
            this.tsBtnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnConsulta.Click += new System.EventHandler(this.tsBtnConsulta_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 87);
            // 
            // tsBtnBascula
            // 
            this.tsBtnBascula.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBascula.Image")));
            this.tsBtnBascula.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnBascula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBascula.Name = "tsBtnBascula";
            this.tsBtnBascula.Size = new System.Drawing.Size(69, 84);
            this.tsBtnBascula.Text = "Bascula";
            this.tsBtnBascula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnBascula.Click += new System.EventHandler(this.tsBtnBascula_Click);
            // 
            // tsBtnLimpiar
            // 
            this.tsBtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLimpiar.Image")));
            this.tsBtnLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLimpiar.Name = "tsBtnLimpiar";
            this.tsBtnLimpiar.Size = new System.Drawing.Size(68, 84);
            this.tsBtnLimpiar.Text = "Limpiar";
            this.tsBtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnLimpiar.Click += new System.EventHandler(this.tsBtnLimpiar_Click_1);
            // 
            // tsBtnActualizarVenta
            // 
            this.tsBtnActualizarVenta.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnActualizarVenta.Image")));
            this.tsBtnActualizarVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnActualizarVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnActualizarVenta.Name = "tsBtnActualizarVenta";
            this.tsBtnActualizarVenta.Size = new System.Drawing.Size(95, 84);
            this.tsBtnActualizarVenta.Text = "Actualizar venta";
            this.tsBtnActualizarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnActualizarVenta.Visible = false;
            this.tsBtnActualizarVenta.Click += new System.EventHandler(this.tsBtnActualizarVenta_Click);
            // 
            // tsBtnCancelarVenta
            // 
            this.tsBtnCancelarVenta.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCancelarVenta.Image")));
            this.tsBtnCancelarVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCancelarVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancelarVenta.Name = "tsBtnCancelarVenta";
            this.tsBtnCancelarVenta.Size = new System.Drawing.Size(89, 84);
            this.tsBtnCancelarVenta.Text = "Cancelar venta";
            this.tsBtnCancelarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnCancelarVenta.Visible = false;
            // 
            // tsBtnReimprimirTicket
            // 
            this.tsBtnReimprimirTicket.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnReimprimirTicket.Image")));
            this.tsBtnReimprimirTicket.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnReimprimirTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnReimprimirTicket.Name = "tsBtnReimprimirTicket";
            this.tsBtnReimprimirTicket.Size = new System.Drawing.Size(102, 84);
            this.tsBtnReimprimirTicket.Text = "Reimprimir ticket";
            this.tsBtnReimprimirTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnReimprimirTicket.Visible = false;
            this.tsBtnReimprimirTicket.Click += new System.EventHandler(this.tsBtnReimprimirTicket_Click);
            // 
            // cbClientes
            // 
            this.cbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(79, 97);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(574, 32);
            this.cbClientes.TabIndex = 29;
            this.cbClientes.Visible = false;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // cbProductos
            // 
            this.cbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(79, 97);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(575, 32);
            this.cbProductos.TabIndex = 30;
            this.cbProductos.Visible = false;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // btnMostrarCbCliente
            // 
            this.btnMostrarCbCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarCbCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarCbCliente.BackgroundImage")));
            this.btnMostrarCbCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarCbCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarCbCliente.FlatAppearance.BorderSize = 0;
            this.btnMostrarCbCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarCbCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnMostrarCbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCbCliente.Location = new System.Drawing.Point(788, 98);
            this.btnMostrarCbCliente.Name = "btnMostrarCbCliente";
            this.btnMostrarCbCliente.Size = new System.Drawing.Size(39, 32);
            this.btnMostrarCbCliente.TabIndex = 31;
            this.btnMostrarCbCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostrarCbCliente.UseVisualStyleBackColor = false;
            this.btnMostrarCbCliente.Click += new System.EventHandler(this.btnMostrarCbCliente_Click);
            // 
            // chbCredito
            // 
            this.chbCredito.AutoSize = true;
            this.chbCredito.Location = new System.Drawing.Point(594, 514);
            this.chbCredito.Name = "chbCredito";
            this.chbCredito.Size = new System.Drawing.Size(59, 17);
            this.chbCredito.TabIndex = 32;
            this.chbCredito.Text = "Credito";
            this.chbCredito.UseVisualStyleBackColor = true;
            // 
            // lClienteVenta
            // 
            this.lClienteVenta.AutoSize = true;
            this.lClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClienteVenta.Location = new System.Drawing.Point(549, 59);
            this.lClienteVenta.Name = "lClienteVenta";
            this.lClienteVenta.Size = new System.Drawing.Size(12, 18);
            this.lClienteVenta.TabIndex = 33;
            this.lClienteVenta.Text = ".";
            this.lClienteVenta.Click += new System.EventHandler(this.lClienteVenta_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.ForeColor = System.Drawing.Color.Lime;
            this.txtDescuento.Location = new System.Drawing.Point(171, 458);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(150, 53);
            this.txtDescuento.TabIndex = 3;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // lDescuento
            // 
            this.lDescuento.AutoSize = true;
            this.lDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescuento.Location = new System.Drawing.Point(166, 430);
            this.lDescuento.Name = "lDescuento";
            this.lDescuento.Size = new System.Drawing.Size(127, 25);
            this.lDescuento.TabIndex = 35;
            this.lDescuento.Text = "$Descuento";
            // 
            // chkDescuento
            // 
            this.chkDescuento.AutoSize = true;
            this.chkDescuento.Location = new System.Drawing.Point(306, 438);
            this.chkDescuento.Name = "chkDescuento";
            this.chkDescuento.Size = new System.Drawing.Size(15, 14);
            this.chkDescuento.TabIndex = 36;
            this.chkDescuento.UseVisualStyleBackColor = true;
            this.chkDescuento.CheckedChanged += new System.EventHandler(this.chkDescuento_CheckedChanged);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVenta.BackgroundImage")));
            this.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Location = new System.Drawing.Point(679, 98);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(39, 32);
            this.btnVenta.TabIndex = 37;
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductos.Location = new System.Drawing.Point(17, 134);
            this.dgvProductos.Name = "dgvProductos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductos.RowTemplate.Height = 35;
            this.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(911, 293);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellValueChanged);
            this.dgvProductos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProductos_RowsRemoved);
            // 
            // PuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(940, 557);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.chkDescuento);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lDescuento);
            this.Controls.Add(this.lClienteVenta);
            this.Controls.Add(this.chbCredito);
            this.Controls.Add(this.btnMostrarCbCliente);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnActividades);
            this.Controls.Add(this.cmdBuscarProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lNotificaciones);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.lBusqueda);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdPagar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.txtCodigo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PuntoDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de venta - Release 14";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PuntoDeVenta_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label lBusqueda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lNotificaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdBuscarProducto;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnProducto;
        private System.Windows.Forms.ToolStripButton tsBtnProveedor;
        private System.Windows.Forms.ToolStripButton tsBtnCliente;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Button btnMostrarCbCliente;
        private System.Windows.Forms.ToolStripButton tsBtnActualizarVenta;
        private System.Windows.Forms.CheckBox chbCredito;
        private System.Windows.Forms.Label lClienteVenta;
        private System.Windows.Forms.ToolStripButton tsBtnConsulta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lDescuento;
        private System.Windows.Forms.CheckBox chkDescuento;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.ToolStripButton tsBtnLimpiar;
        private System.Windows.Forms.ToolStripButton tsBtnCancelarVenta;
        private System.Windows.Forms.ToolStripButton tsBtnBascula;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ToolStripButton tsBtnReimprimirTicket;
    }
}

