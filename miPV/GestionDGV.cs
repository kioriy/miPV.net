using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPV
{
    class GestionDGV
    {
        #region variables;
        private DataGridView dgv;
        #endregion

        #region constructor
        public GestionDGV(DataGridView dgv)
        {
            this.dgv = dgv;
        }
        #endregion

        #region metodos

        public void inicializarDgv()
        {
            foreach (DataGridViewColumn col in this.dgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            //DataGridViewRow row = this.dgv.Rows[0];
            //row.Height = 35;

            this.dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dgv.Columns[1].Width = 90;
            dgv.Columns[2].Width = 220;
            dgv.Columns[3].Width = 90;
            dgv.Columns[4].Width = 90;
        }

        public void cargarColumnas()
        {
            dgv.ColumnCount = 5;

            dgv.Columns[0].HeaderText = "CODIGO";
            dgv.Columns[1].HeaderText = "CANTIDAD";
            dgv.Columns[2].HeaderText = "DESCRIPCION";
            dgv.Columns[3].HeaderText = "PRECIO U.";
            dgv.Columns[4].HeaderText = "TOTAL";

            dgv.Columns[0].Name = "cCodigo";
            dgv.Columns[1].Name = "cCantidad";
            dgv.Columns[2].Name = "cDescripcion";
            dgv.Columns[3].Name = "cPrecioUnitario";
            dgv.Columns[4].Name = "cTotal";

            dgv.Columns["cCodigo"].Visible = false;
        }

         public void cargarDgvProductos(Producto producto, bool vengoDeCargarDetalleVenta)
        {
            int idProducto = producto.id_producto;
            string codigo = producto.codigo;
            string precioCosto = producto.precio_costo;
            decimal precioVenta = Convert.ToDecimal(producto.precio_venta);
            string descripcion = producto.descripcion;
            decimal cantidad = Convert.ToDecimal(producto.cantidad);
            decimal total = precioVenta;

            if (!vengoDeCargarDetalleVenta)
            {
                if (!sumarProductoExistente(dgv, codigo))
                {
                    dgv.Rows.Add(codigo, 1, descripcion, string.Format("{0:N2}", precioVenta), string.Format("{0:N2}", total));
                }
            }
            else
            {
                if (!sumarProductoExistente(dgv, codigo))
                {
                    total = cantidad * precioVenta; 
                    dgv.Rows.Add(codigo, cantidad, descripcion, string.Format("{0:N2}", precioVenta), string.Format("{0:N2}", total));
                }
            }
        }

        public bool sumarProductoExistente(DataGridView dgv, string codigo)
        {
            foreach(DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["cCodigo"].Value.ToString() == codigo)
                {
                    decimal cantidad = Convert.ToDecimal(row.Cells["cCantidad"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["cPrecioUnitario"].Value);
                    decimal total = 0.0M;
                    cantidad++;
                    row.Cells["cCantidad"].Value = cantidad.ToString();
                    total = cantidad * precio;
                    row.Cells["cTotal"].Value = string.Format("{0:N2}", total);
                    return true;
                }
            }
            return false;
        }

        public string sumarTotalPagado(DataGridView dgv)
        {
            double suma = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["cTotal"].Value == DBNull.Value)
                    continue;

                double valorcell = 0;
                double.TryParse(Convert.ToString(row.Cells["cTotal"].Value), out valorcell);

                suma += Convert.ToDouble(valorcell);
            }

            return string.Format("{0:N2}", suma);//suma.ToString("C"); 
        }

        public List<string> listaColumna(string columna)
        {
            List<string> lista_columna = new List<string>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[columna].Value == DBNull.Value)
                    continue;

                lista_columna.Add(string.Format("{0:N2}", row.Cells[columna].Value.ToString()));
                //double valorcell = 0;
                //double.TryParse(Convert.ToString(row.Cells["cTotal"].Value), out valorcell);
                //suma += Convert.ToDouble(valorcell);
            }
            return lista_columna;
        }

        public void sumarFilas(DataGridViewCellEventArgs e)
        {
            if (this.dgv.Columns[e.ColumnIndex].Name == "cCantidad")
            {
                decimal cantidad = Convert.ToDecimal(this.dgv.CurrentRow.Cells["cCantidad"].Value);
                decimal precioU = Convert.ToDecimal(this.dgv.CurrentRow.Cells["cPrecioUnitario"].Value);
                decimal total = cantidad * precioU;

                this.dgv.CurrentRow.Cells["cTotal"].Value = string.Format("{0:N2}", total);
            }
        }

        #endregion
    }
}
