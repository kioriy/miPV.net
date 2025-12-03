namespace miPV
{
    partial class frmInicioSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSession));
            this.labelUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIniciarSession = new System.Windows.Forms.Button();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.txtContraseñaAdmin = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelContraseña2 = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lRegistrar = new System.Windows.Forms.Label();
            this.lNuevoUsuario = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lRol = new System.Windows.Forms.Label();
            this.liniciar = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(41, 164);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(49, 12);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "USUARIO";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(68, 348);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(185, 26);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Visible = false;
            // 
            // btnIniciarSession
            // 
            this.btnIniciarSession.BackColor = System.Drawing.Color.Black;
            this.btnIniciarSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSession.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSession.Location = new System.Drawing.Point(81, 274);
            this.btnIniciarSession.Name = "btnIniciarSession";
            this.btnIniciarSession.Size = new System.Drawing.Size(116, 50);
            this.btnIniciarSession.TabIndex = 2;
            this.btnIniciarSession.Text = "Iniciar Session";
            this.btnIniciarSession.UseVisualStyleBackColor = false;
            this.btnIniciarSession.Click += new System.EventHandler(this.btnIniciarSession_Click);
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña1.Location = new System.Drawing.Point(43, 230);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.PasswordChar = '*';
            this.txtContraseña1.Size = new System.Drawing.Size(185, 26);
            this.txtContraseña1.TabIndex = 3;
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña2.Location = new System.Drawing.Point(333, 348);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(185, 26);
            this.txtContraseña2.TabIndex = 4;
            this.txtContraseña2.Visible = false;
            // 
            // txtContraseñaAdmin
            // 
            this.txtContraseñaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaAdmin.Location = new System.Drawing.Point(333, 450);
            this.txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            this.txtContraseñaAdmin.PasswordChar = '*';
            this.txtContraseñaAdmin.Size = new System.Drawing.Size(185, 26);
            this.txtContraseñaAdmin.TabIndex = 5;
            this.txtContraseñaAdmin.Visible = false;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(41, 215);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(71, 12);
            this.labelContraseña.TabIndex = 6;
            this.labelContraseña.Text = "CONTRASEÑA";
            // 
            // labelContraseña2
            // 
            this.labelContraseña2.AutoSize = true;
            this.labelContraseña2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña2.Location = new System.Drawing.Point(331, 333);
            this.labelContraseña2.Name = "labelContraseña2";
            this.labelContraseña2.Size = new System.Drawing.Size(126, 12);
            this.labelContraseña2.TabIndex = 7;
            this.labelContraseña2.Text = "VERIFICAR CONTRASEÑA";
            this.labelContraseña2.Visible = false;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(331, 435);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(155, 12);
            this.labelAdmin.TabIndex = 8;
            this.labelAdmin.Text = "CONTRASEÑA ADMINISTRADOR";
            this.labelAdmin.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lRegistrar
            // 
            this.lRegistrar.AutoSize = true;
            this.lRegistrar.Location = new System.Drawing.Point(330, 321);
            this.lRegistrar.Name = "lRegistrar";
            this.lRegistrar.Size = new System.Drawing.Size(49, 13);
            this.lRegistrar.TabIndex = 12;
            this.lRegistrar.Text = "Registrar";
            this.lRegistrar.Visible = false;
            // 
            // lNuevoUsuario
            // 
            this.lNuevoUsuario.AutoSize = true;
            this.lNuevoUsuario.ForeColor = System.Drawing.Color.Blue;
            this.lNuevoUsuario.Location = new System.Drawing.Point(85, 258);
            this.lNuevoUsuario.Name = "lNuevoUsuario";
            this.lNuevoUsuario.Size = new System.Drawing.Size(74, 13);
            this.lNuevoUsuario.TabIndex = 13;
            this.lNuevoUsuario.Text = "nuevo usuario";
            this.lNuevoUsuario.Visible = false;
            this.lNuevoUsuario.Click += new System.EventHandler(this.lNuevoUsuario_Click);
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "CAJERO"});
            this.cbRol.Location = new System.Drawing.Point(333, 399);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(185, 21);
            this.cbRol.TabIndex = 14;
            this.cbRol.Visible = false;
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(332, 384);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(90, 12);
            this.lRol.TabIndex = 15;
            this.lRol.Text = "ROL DEL USUARIO";
            this.lRol.Visible = false;
            // 
            // liniciar
            // 
            this.liniciar.AutoSize = true;
            this.liniciar.ForeColor = System.Drawing.Color.Blue;
            this.liniciar.Location = new System.Drawing.Point(182, 405);
            this.liniciar.Name = "liniciar";
            this.liniciar.Size = new System.Drawing.Size(72, 13);
            this.liniciar.TabIndex = 17;
            this.liniciar.Text = "iniciar session";
            this.liniciar.Visible = false;
            this.liniciar.Click += new System.EventHandler(this.liniciar_Click);
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "CAJERO"});
            this.cbUsuario.Location = new System.Drawing.Point(43, 179);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(185, 21);
            this.cbUsuario.TabIndex = 18;
            // 
            // frmInicioSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(267, 346);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.liniciar);
            this.Controls.Add(this.lRol);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.lNuevoUsuario);
            this.Controls.Add(this.lRegistrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.labelContraseña2);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.txtContraseñaAdmin);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtContraseña1);
            this.Controls.Add(this.btnIniciarSession);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Name = "frmInicioSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIniciarSession;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.TextBox txtContraseñaAdmin;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelContraseña2;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lRegistrar;
        private System.Windows.Forms.Label lNuevoUsuario;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label liniciar;
        private System.Windows.Forms.ComboBox cbUsuario;
    }
}