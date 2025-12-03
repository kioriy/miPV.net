namespace miPV
{
    partial class FrmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnInventario = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCredito = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCorteCaja = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnPdf = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPagar = new System.Windows.Forms.ToolStripButton();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lCorteCaja = new System.Windows.Forms.Label();
            this.lUtilidad = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnInventario,
            this.tsBtnCredito,
            this.tsBtnCorteCaja,
            this.toolStripSeparator1,
            this.tsBtnPdf,
            this.tsBtnPagar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 87);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnInventario
            // 
            this.tsBtnInventario.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnInventario.Image")));
            this.tsBtnInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnInventario.Name = "tsBtnInventario";
            this.tsBtnInventario.Size = new System.Drawing.Size(69, 84);
            this.tsBtnInventario.Text = "Inventario";
            this.tsBtnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnInventario.Click += new System.EventHandler(this.tsBtnInventario_Click);
            // 
            // tsBtnCredito
            // 
            this.tsBtnCredito.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCredito.Image")));
            this.tsBtnCredito.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCredito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCredito.Name = "tsBtnCredito";
            this.tsBtnCredito.Size = new System.Drawing.Size(68, 84);
            this.tsBtnCredito.Text = "Credito";
            this.tsBtnCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnCredito.Visible = false;
            this.tsBtnCredito.Click += new System.EventHandler(this.tsBtnCredito_Click);
            // 
            // tsBtnCorteCaja
            // 
            this.tsBtnCorteCaja.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCorteCaja.Image")));
            this.tsBtnCorteCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCorteCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCorteCaja.Name = "tsBtnCorteCaja";
            this.tsBtnCorteCaja.Size = new System.Drawing.Size(68, 84);
            this.tsBtnCorteCaja.Text = "Corte caja";
            this.tsBtnCorteCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnCorteCaja.Click += new System.EventHandler(this.tsBtnCorteCaja_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 87);
            this.toolStripSeparator1.Visible = false;
            // 
            // tsBtnPdf
            // 
            this.tsBtnPdf.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPdf.Image")));
            this.tsBtnPdf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnPdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPdf.Name = "tsBtnPdf";
            this.tsBtnPdf.Size = new System.Drawing.Size(69, 84);
            this.tsBtnPdf.Text = "PDF";
            this.tsBtnPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnPdf.Visible = false;
            // 
            // tsBtnPagar
            // 
            this.tsBtnPagar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPagar.Image")));
            this.tsBtnPagar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnPagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPagar.Name = "tsBtnPagar";
            this.tsBtnPagar.Size = new System.Drawing.Size(81, 84);
            this.tsBtnPagar.Text = "Pagar credito";
            this.tsBtnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnPagar.Visible = false;
            this.tsBtnPagar.Click += new System.EventHandler(this.tsBtnPagar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 90);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(771, 415);
            this.dgvConsulta.TabIndex = 30;
            this.dgvConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellClick);
            this.dgvConsulta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellEndEdit);
            // 
            // lCorteCaja
            // 
            this.lCorteCaja.AutoSize = true;
            this.lCorteCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCorteCaja.Location = new System.Drawing.Point(478, 9);
            this.lCorteCaja.Name = "lCorteCaja";
            this.lCorteCaja.Size = new System.Drawing.Size(22, 31);
            this.lCorteCaja.TabIndex = 31;
            this.lCorteCaja.Text = ".";
            // 
            // lUtilidad
            // 
            this.lUtilidad.AutoSize = true;
            this.lUtilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUtilidad.Location = new System.Drawing.Point(478, 56);
            this.lUtilidad.Name = "lUtilidad";
            this.lUtilidad.Size = new System.Drawing.Size(22, 31);
            this.lUtilidad.TabIndex = 32;
            this.lUtilidad.Text = ".";
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 517);
            this.Controls.Add(this.lUtilidad);
            this.Controls.Add(this.lCorteCaja);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmConsulta";
            this.Text = "Consulta";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnInventario;
        private System.Windows.Forms.ToolStripButton tsBtnCorteCaja;
        private System.Windows.Forms.ToolStripButton tsBtnPagar;
        private System.Windows.Forms.ToolStripButton tsBtnCredito;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnPdf;
        private System.Windows.Forms.Label lCorteCaja;
        private System.Windows.Forms.Label lUtilidad;
    }
}