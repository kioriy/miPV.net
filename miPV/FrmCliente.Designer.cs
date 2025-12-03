namespace miPV
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lNotificaciones = new System.Windows.Forms.Label();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAgregarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "Ciudad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 53;
            this.label6.Text = "R.F.C.";
            // 
            // lNotificaciones
            // 
            this.lNotificaciones.AutoSize = true;
            this.lNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotificaciones.ForeColor = System.Drawing.Color.Red;
            this.lNotificaciones.Location = new System.Drawing.Point(17, 403);
            this.lNotificaciones.Name = "lNotificaciones";
            this.lNotificaciones.Size = new System.Drawing.Size(153, 25);
            this.lNotificaciones.TabIndex = 49;
            this.lNotificaciones.Text = "Notificaciones:";
            // 
            // cbNombre
            // 
            this.cbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.cbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(103, 66);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(362, 33);
            this.cbNombre.TabIndex = 36;
            this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.cbNombre_SelectedIndexChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelefono.Location = new System.Drawing.Point(103, 342);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(190, 31);
            this.txtTelefono.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Telefono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCorreo.Location = new System.Drawing.Point(103, 287);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(190, 31);
            this.txtCorreo.TabIndex = 41;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.Control;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEstado.Location = new System.Drawing.Point(103, 232);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(121, 31);
            this.txtEstado.TabIndex = 39;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDireccion.Location = new System.Drawing.Point(103, 123);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(362, 31);
            this.txtDireccion.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Correo";
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
            this.cmdAgregarProducto.Location = new System.Drawing.Point(326, 305);
            this.cmdAgregarProducto.Name = "cmdAgregarProducto";
            this.cmdAgregarProducto.Size = new System.Drawing.Size(117, 75);
            this.cmdAgregarProducto.TabIndex = 43;
            this.cmdAgregarProducto.UseVisualStyleBackColor = false;
            this.cmdAgregarProducto.Click += new System.EventHandler(this.cmdAgregarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nombre";
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
            this.cmdActualizar.Location = new System.Drawing.Point(326, 294);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(117, 75);
            this.cmdActualizar.TabIndex = 50;
            this.cmdActualizar.UseVisualStyleBackColor = false;
            this.cmdActualizar.Visible = false;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(403, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 48);
            this.btnLimpiar.TabIndex = 55;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.SystemColors.Control;
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCiudad.Location = new System.Drawing.Point(103, 176);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(362, 31);
            this.txtCiudad.TabIndex = 56;
            // 
            // txtRfc
            // 
            this.txtRfc.BackColor = System.Drawing.SystemColors.Control;
            this.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRfc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRfc.Location = new System.Drawing.Point(299, 232);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(166, 31);
            this.txtRfc.TabIndex = 57;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 437);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lNotificaciones);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdAgregarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdActualizar);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lNotificaciones;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdAgregarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtRfc;
    }
}