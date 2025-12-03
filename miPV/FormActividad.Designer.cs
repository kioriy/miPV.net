namespace miPV
{
    partial class FormActividad
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
            this.GridViewActividades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.FECHA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewActividades
            // 
            this.GridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewActividades.Location = new System.Drawing.Point(30, 66);
            this.GridViewActividades.Name = "GridViewActividades";
            this.GridViewActividades.Size = new System.Drawing.Size(536, 273);
            this.GridViewActividades.TabIndex = 0;
            this.GridViewActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "USUARIOS";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(30, 32);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(202, 21);
            this.comboBoxUsuario.TabIndex = 3;
            this.comboBoxUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuario_SelectedIndexChanged);
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(278, 32);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(168, 20);
            this.DateTime.TabIndex = 5;
            this.DateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FECHA
            // 
            this.FECHA.AutoSize = true;
            this.FECHA.Location = new System.Drawing.Point(275, 13);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(42, 13);
            this.FECHA.TabIndex = 6;
            this.FECHA.Text = "FECHA";
            // 
            // FormActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 360);
            this.Controls.Add(this.FECHA);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewActividades);
            this.Name = "FormActividad";
            this.Text = "Actividades";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Label FECHA;
    }
}