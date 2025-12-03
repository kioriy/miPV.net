using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace miPV
{
    public class Producto : BD
    {
        #region atributos
        //public List<Producto> _list;
        public int id_producto { get; set; }
        public string codigo { get; set; }
        public string precio_venta { get; set; }
        public string precio_costo { get; set; }
        public string unidad { get; set; }
        public string descripcion { get; set; }
        public string cantidad { get; set; }
        public int fk_id_proveedor { get; set; }
        //private string respuesta = "";

        public string table { get; set; }
        #endregion

        #region constructores
        public Producto()
        {
            table = PRODUCTO;
        }
        #endregion

        #region metodos

        public bool insert()
        {
           return insertar(execute(table, values(),action.insert, ""));//execute(table, values(), action.insert.ToString(), "");
        }

        public bool update(string valor)
        {
            return insertar(execute(table, valoresUpdate(), action.update, $"{WHERE} {id_producto_a} {igual} {valor}"));//execute(table, values(), action.update.ToString(), where);
        }

        public void query(string valuesString, string where)
        {
            consulta(execute(table,id_producto_a,action.query, where),table); //execute(table, $"{valuesString}", action.query.ToString(), where);
        }

        public void buscarProducto(DataGridView dgv, string descripcion, string tabla)
        {
            //bd.llenarDgv(dgv, query.buscarProducto(descripcion), tabla);
        }
        #endregion

        public List<Producto> list()
        {
            List<Producto> list = new List<Producto>();

            foreach (DataRow row in obtenerDatos.Tables[0].Rows)
            {
                Producto p = new Producto()
                {
                    id_producto = Convert.ToInt32(row["id_producto"].ToString()),
                    codigo = row["codigo"].ToString(),
                    unidad = row["unidad"].ToString(),
                    precio_venta = row["precio_venta"].ToString(),
                    precio_costo = row["precio_costo"].ToString(),
                    descripcion = row["descripcion"].ToString(),
                    cantidad = row["cantidad"].ToString(),
                    fk_id_proveedor = Convert.ToInt32(row["fk_id_proveedor"].ToString())
                };

                list.Add(p);
            }
           
            return list;
        }

        public List<Producto> RefreshList()
        {
            query("", "WHERE 1");

            List<Producto> list = new List<Producto>();

            foreach (DataRow row in obtenerDatos.Tables[0].Rows)
            {
                Producto p = new Producto()
                {
                    id_producto = Convert.ToInt32(row["id_producto"].ToString()),
                    codigo = row["codigo"].ToString(),
                    unidad = row["codigo"].ToString(),
                    precio_venta = row["codigo"].ToString(),
                    precio_costo = row["precio_costo"].ToString(),
                    descripcion = row["descripcion"].ToString(),
                    cantidad = row["cantidad"].ToString(),
                    fk_id_proveedor = Convert.ToInt32(row["fk_id_proveedor"].ToString())
                };

                list.Add(p);
            }

            return list;
        }

        #region METODOS INTERFACE
        public void loadComboBox(ComboBox cb, bool codigo_descripcion, ref int entra)
        {
            cb.Items.Clear();

            query("","WHERE 1");

            //list();
            //llenarCombobox(cb,execute(table,id_producto_a,action.query, "WHERE 1"),"descripcion",table,ref entra);
            //query("", $"{WHERE} 1");

            if (list().Count > 0)
            {
                if (!codigo_descripcion)
                {
                    //llenarCombobox(cb, execute(table, id_producto_a, action.query, "WHERE 1"), "descripcion", table,
                    //    ref entra);
                    foreach (var producto in list())
                    {
                        cb.Items.Add(producto.descripcion);
                    }
                }
                else
                {
                    //llenarCombobox(cb, execute(table, id_producto_a, action.query, "WHERE 1"), "codigo", table,
                    //    ref entra);
                    foreach (var producto in list())
                    {
                        cb.Items.Add(producto.codigo);
                    }
                }

                //list();
            }
        }

        public void loadDgv(DataGridView dgv)
        {
            dgv.DataSource = null;

            query("1", $"{WHERE} 1 ORDER BY `descripcion` ASC");

            dgv.DataSource = list();

            dgv.Columns["id_producto"].Visible = false;
            dgv.Columns["fk_id_proveedor"].Visible = false;
            dgv.Columns["table"].Visible = false;
        }

        public void cargarColumnas(DataGridView dgv)
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
        #endregion

        #region VALUES
        public string valoresUpdate()
        {
            return
                $"{codigo_a} {igual} {c}{codigo.ToUpper().Trim()}{c}{cc}" +
                $"{unidad_a} {igual} {c}{unidad.ToUpper().Trim()}{c}{cc}" +
                $"{precio_venta_a} {igual} {c}{precio_venta.ToUpper().Trim()}{c}{cc}" +
                $"{precio_costo_a} {igual} {c}{precio_costo.ToUpper().Trim()}{c}{cc}" +
                $"{descripcion_a} {igual} {c}{descripcion.ToUpper().Trim()}{c}{cc}" +
                $"{cantidad_a} {igual} {c}{cantidad.ToUpper().Trim()}{c}{cc}" +
                $"{fk_id_proveedor_a} {igual} {c}{fk_id_proveedor}{c}";
        }

        public string values()
        {
            return
            $"{codigo.Trim()}{cc}" +
            $"'{unidad.ToUpper().Trim()}'{cc}" +
            $"{precio_venta.Trim()}{cc}" +
            $"{precio_costo.Trim()}{cc}" +
            $"'{descripcion.ToUpper().Trim()}'{cc}" +
            $"{cantidad.Trim()}{cc}"+
            $"{fk_id_proveedor}";
        }
        #endregion
    }
}
