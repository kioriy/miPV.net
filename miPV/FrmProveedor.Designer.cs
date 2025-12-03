namespace miPV
{
    partial class FrmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor));
            this.label7 = new System.Windows.Forms.Label();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.lNotificaciones = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdAgregarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Telefono";
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
            this.cmdActualizar.Location = new System.Drawing.Point(397, 221);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(117, 75);
            this.cmdActualizar.TabIndex = 48;
            this.cmdActualizar.UseVisualStyleBackColor = false;
            this.cmdActualizar.Visible = false;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // lNotificaciones
            // 
            this.lNotificaciones.AutoSize = true;
            this.lNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotificaciones.ForeColor = System.Drawing.Color.Red;
            this.lNotificaciones.Location = new System.Drawing.Point(7, 321);
            this.lNotificaciones.Name = "lNotificaciones";
            this.lNotificaciones.Size = new System.Drawing.Size(153, 25);
            this.lNotificaciones.TabIndex = 47;
            this.lNotificaciones.Text = "Notificaciones:";
            // 
            // cbProveedor
            // 
            this.cbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProveedor.BackColor = System.Drawing.SystemColors.Menu;
            this.cbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(113, 69);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(434, 33);
            this.cbProveedor.TabIndex = 36;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDireccion.Location = new System.Drawing.Point(113, 126);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(434, 31);
            this.txtDireccion.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Dirección";
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
            this.cmdAgregarProducto.Location = new System.Drawing.Point(397, 221);
            this.cmdAgregarProducto.Name = "cmdAgregarProducto";
            this.cmdAgregarProducto.Size = new System.Drawing.Size(117, 75);
            this.cmdAgregarProducto.TabIndex = 41;
            this.cmdAgregarProducto.UseVisualStyleBackColor = false;
            this.cmdAgregarProducto.Click += new System.EventHandler(this.cmdAgregarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelefono.Location = new System.Drawing.Point(113, 179);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(196, 31);
            this.txtTelefono.TabIndex = 55;
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
            this.btnLimpiar.Location = new System.Drawing.Point(487, 15);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 48);
            this.btnLimpiar.TabIndex = 56;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 354);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lNotificaciones);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdAgregarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdActualizar);
            this.Name = "FrmProveedor";
            this.Text = "Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdActualizar;
        private System.Windows.Forms.Label lNotificaciones;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdAgregarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnLimpiar;
    }
}