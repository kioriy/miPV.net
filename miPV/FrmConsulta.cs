using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPV
{
    public partial class FrmConsulta : Form
    {
        Venta venta = new Venta();
        Producto producto = new Producto();

        bool is_selected_corte_caja = false;
        
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void tsBtnInventario_Click(object sender, EventArgs e)
        {
            tsBtnPagar.Visible = false;
            is_selected_corte_caja = false;
            producto.loadDgv(dgvConsulta);
        }

        private void tsBtnCredito_Click(object sender, EventArgs e)
        {
            tsBtnPagar.Visible = true;
            is_selected_corte_caja = false;
            venta.loadDgv(dgvConsulta, venta.clienteCredito());
        }

        private void tsBtnCorteCaja_Click(object sender, EventArgs e)
        {
            tsBtnPagar.Visible = false;
            is_selected_corte_caja = true;
            venta.loadDgvC(dgvConsulta, venta.corteCaja());
        }

        private void tsBtnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvConsulta.CurrentRow;

                string id_venta = row.Cells["folio"].Value.ToString();

                Venta update_venta = venta.list(true).Find(x => x.folio == id_venta);

                //update_venta.credito = "0";

                update_venta.free($"UPDATE `venta` SET `credito`= '0' WHERE `id_venta` = '{id_venta}'");

                venta.loadDgv(dgvConsulta, venta.clienteCredito());
                //update_venta.update($"WHERE {venta.id_venta_a} = {id_venta}");
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una registro");
            }
        }

        private void dgvConsulta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (tsBtnPagar.Visible == true)
              {
                DataGridViewRow row = dgvConsulta.CurrentRow;

                string id_venta = row.Cells["folio"].Value.ToString();

                Venta update_venta = venta.list(true).Find(x => x.folio == id_venta);

                string abono = row.Cells[8].Value.ToString();

                update_venta.free($"UPDATE `venta` SET `abono`= '{abono}' WHERE `id_venta` = '{id_venta}'");
                //update_venta.update($"WHERE {venta.id_venta_a} = {id_venta}");
            }
        }

        public string sumarTotalPagado(DataGridView dgv, string fila)
        {
            if (is_selected_corte_caja)
            {
                double suma = 0;
                string fecha = Convert.ToDateTime(dgv.CurrentRow.Cells["fecha"].Value).ToString("dd-MM-yyyy");

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells["total"].Value == DBNull.Value)
                        continue;

                    double valorcell = 0;
                    double.TryParse(Convert.ToString(row.Cells[fila].Value), out valorcell);


                    if (Convert.ToDateTime(row.Cells["fecha"].Value).ToString("dd-MM-yyyy") == fecha)
                    {
                        suma += Convert.ToDouble(valorcell);
                    }
                }

                return $"{suma:N2}";//suma.ToString("C"); 
            }
            return "";
        }

        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            lCorteCaja.Text = $@"Total: $ {sumarTotalPagado(dgvConsulta, "total")}";

            decimal corteCaja = Convert.ToDecimal($"{sumarTotalPagado(dgvConsulta, "total")}");
            decimal costo = Convert.ToDecimal($"{sumarTotalPagado(dgvConsulta, "costo")}");

            decimal utilidad = corteCaja - costo; 

            lUtilidad.Text = $@"Utilidad: $ {utilidad}";
        }
    }
}
