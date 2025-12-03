namespace miPV
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.label5 = new System.Windows.Forms.Label();
            this.cmdAgregarProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lNotificaciones = new System.Windows.Forms.Label();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Código";
            // 
            // cmdAgregarProducto
            // 
            this.cmdAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.cmdAgregarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAgregarProducto.BackgroundImage")));
            this.cmdAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdAgregarProducto.FlatAppearance.BorderSize = 0;
            this.cmdAgregarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregarProducto.Location = new System.Drawing.Point(293, 289);
            this.cmdAgregarProducto.Name = "cmdAgregarProducto";
            this.cmdAgregarProducto.Size = new System.Drawing.Size(117, 75);
            this.cmdAgregarProducto.TabIndex = 8;
            this.cmdAgregarProducto.UseVisualStyleBackColor = false;
            this.cmdAgregarProducto.Click += new System.EventHandler(this.cmdAgregarProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescripcion.Location = new System.Drawing.Point(128, 118);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(306, 31);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCantidad.Location = new System.Drawing.Point(128, 227);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(111, 31);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCosto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrecioCosto.Location = new System.Drawing.Point(128, 282);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(111, 31);
            this.txtPrecioCosto.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Precio venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrecioVenta.Location = new System.Drawing.Point(128, 337);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(111, 31);
            this.txtPrecioVenta.TabIndex = 7;
            // 
            // lNotificaciones
            // 
            this.lNotificaciones.AutoSize = true;
            this.lNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotificaciones.ForeColor = System.Drawing.Color.Red;
            this.lNotificaciones.Location = new System.Drawing.Point(7, 394);
            this.lNotificaciones.Name = "lNotificaciones";
            this.lNotificaciones.Size = new System.Drawing.Size(153, 25);
            this.lNotificaciones.TabIndex = 25;
            this.lNotificaciones.Text = "Notificaciones:";
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.BackColor = System.Drawing.Color.Transparent;
            this.cmdActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdActualizar.BackgroundImage")));
            this.cmdActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdActualizar.FlatAppearance.BorderSize = 0;
            this.cmdActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdActualizar.Location = new System.Drawing.Point(293, 289);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(117, 75);
            this.cmdActualizar.TabIndex = 26;
            this.cmdActualizar.UseVisualStyleBackColor = false;
            this.cmdActualizar.Visible = false;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // cbCodigo
            // 
            this.cbCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCodigo.BackColor = System.Drawing.SystemColors.Menu;
            this.cbCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(128, 61);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(306, 33);
            this.cbCodigo.TabIndex = 1;
            this.cbCodigo.SelectedIndexChanged += new System.EventHandler(this.cbCodigo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Unidad";
            // 
            // cbUnidad
            // 
            this.cbUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUnidad.BackColor = System.Drawing.SystemColors.Menu;
            this.cbUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Items.AddRange(new object[] {
            "kg",
            "pieza",
            "bolsa",
            "caja",
            "paquete"});
            this.cbUnidad.Location = new System.Drawing.Point(321, 227);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(113, 33);
            this.cbUnidad.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProveedor.BackColor = System.Drawing.SystemColors.Menu;
            this.cbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(128, 171);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(306, 33);
            this.cbProveedor.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(372, 7);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 48);
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 428);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbUnidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lNotificaciones);
            this.Controls.Add(this.cbCodigo);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdAgregarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdActualizar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProducto_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdAgregarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lNotificaciones;
        private System.Windows.Forms.Button cmdActualizar;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUnidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Button btnLimpiar;
    }
}