using System.Windows.Forms;

namespace miPV
{
    partial class AdministradorUsuarios
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
            this.txcontraseña = new System.Windows.Forms.TextBox();
            this.cbusuario = new System.Windows.Forms.ComboBox();
            this.lb_cbusuario = new System.Windows.Forms.Label();
            this.btmodificar = new System.Windows.Forms.Button();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txnombre = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.lb_Idcajero = new System.Windows.Forms.Label();
            this.lbRoll = new System.Windows.Forms.Label();
            this.txRoll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txcontraseña
            // 
            this.txcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcontraseña.Location = new System.Drawing.Point(16, 166);
            this.txcontraseña.Name = "txcontraseña";
            this.txcontraseña.Size = new System.Drawing.Size(121, 24);
            this.txcontraseña.TabIndex = 0;
            // 
            // cbusuario
            // 
            this.cbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbusuario.FormattingEnabled = true;
            this.cbusuario.Location = new System.Drawing.Point(16, 32);
            this.cbusuario.Name = "cbusuario";
            this.cbusuario.Size = new System.Drawing.Size(121, 26);
            this.cbusuario.TabIndex = 1;
            this.cbusuario.TextChanged += new System.EventHandler(this.cbusuario_TextChanged);
            this.cbusuario.Enter += new System.EventHandler(this.comboBox1_Enter);
            // 
            // lb_cbusuario
            // 
            this.lb_cbusuario.AutoSize = true;
            this.lb_cbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cbusuario.Location = new System.Drawing.Point(12, 9);
            this.lb_cbusuario.Name = "lb_cbusuario";
            this.lb_cbusuario.Size = new System.Drawing.Size(65, 20);
            this.lb_cbusuario.TabIndex = 2;
            this.lb_cbusuario.Text = "usuario.";
            // 
            // btmodificar
            // 
            this.btmodificar.Location = new System.Drawing.Point(240, 214);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(75, 23);
            this.btmodificar.TabIndex = 4;
            this.btmodificar.Text = "modificar";
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.Location = new System.Drawing.Point(12, 143);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(92, 20);
            this.lbContraseña.TabIndex = 5;
            this.lbContraseña.Text = "Contraseña";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(12, 93);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(65, 20);
            this.lbNombre.TabIndex = 7;
            this.lbNombre.Text = "Nombre";
            // 
            // txnombre
            // 
            this.txnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txnombre.Location = new System.Drawing.Point(16, 116);
            this.txnombre.Name = "txnombre";
            this.txnombre.Size = new System.Drawing.Size(121, 24);
            this.txnombre.TabIndex = 6;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(236, 32);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(23, 20);
            this.lbid.TabIndex = 9;
            this.lbid.Text = "Id";
            this.lbid.Visible = false;
            // 
            // lb_Idcajero
            // 
            this.lb_Idcajero.AutoSize = true;
            this.lb_Idcajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Idcajero.Location = new System.Drawing.Point(250, 62);
            this.lb_Idcajero.Name = "lb_Idcajero";
            this.lb_Idcajero.Size = new System.Drawing.Size(0, 20);
            this.lb_Idcajero.TabIndex = 10;
            // 
            // lbRoll
            // 
            this.lbRoll.AutoSize = true;
            this.lbRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoll.Location = new System.Drawing.Point(12, 191);
            this.lbRoll.Name = "lbRoll";
            this.lbRoll.Size = new System.Drawing.Size(36, 20);
            this.lbRoll.TabIndex = 12;
            this.lbRoll.Text = "Roll";
            // 
            // txRoll
            // 
            this.txRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRoll.Location = new System.Drawing.Point(16, 214);
            this.txRoll.Name = "txRoll";
            this.txRoll.Size = new System.Drawing.Size(121, 24);
            this.txRoll.TabIndex = 11;
            // 
            // AdministradorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 249);
            this.Controls.Add(this.lbRoll);
            this.Controls.Add(this.txRoll);
            this.Controls.Add(this.lb_Idcajero);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txnombre);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.lb_cbusuario);
            this.Controls.Add(this.cbusuario);
            this.Controls.Add(this.txcontraseña);
            this.Name = "AdministradorUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministradorUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txcontraseña;
        private System.Windows.Forms.ComboBox cbusuario;
        private System.Windows.Forms.Label lb_cbusuario;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txnombre;
        private System.Windows.Forms.Label lbid;
        private Label lb_Idcajero;
        private Label lbRoll;
        private TextBox txRoll;

        public ComboBox Cbusuario
        {
            get
            {
                return cbusuario;
            }

            set
            {
                cbusuario = value;
            }
        }
    }
}