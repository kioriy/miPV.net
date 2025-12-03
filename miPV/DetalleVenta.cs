using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace miPV
{
    class DetalleVenta : BD
    {
        #region variables
        public string id_detalle_venta { get; set; }
        public string cantidad { get; set; }
        public int fk_id_venta { get; set; }
        public string fk_codigo_producto { get; set; }
        //string credito = "";

        string table = "";

        DataTable tablefk_codigo_producto = new DataTable();
        //BD bd;
        //Query query;
        #endregion

        #region constructores
        public DetalleVenta(DataTable tablefk_codigo_producto)
        {
            this.tablefk_codigo_producto = tablefk_codigo_producto;
            this.table = DETALLE_VENTA;
            //bd = new BD();
            //query = new Query();
        }

        public DetalleVenta()
        {
            //this.tablefk_codigo_producto = tablefk_codigo_producto;
            this.table = DETALLE_VENTA;
            //bd = new BD();
            //query = new Query();
        }
        #endregion

        #region metodos

        #region Crud
        public bool insertar()
        {
            foreach (DataRow fila in tablefk_codigo_producto.Rows)
            {
                cantidad = $"{fila["Cantidad"]:N2}";

                fk_codigo_producto = fila["Codigo"].ToString();

                //INSERT INTO `DETALLE_VENTA`(`cantidad`,`fk_id_venta`,`fk_codigo_producto`)"+
                //"VALUES ('" + cantidad + "',(SELECT MAX(id_venta) FROM `VENTA`),'" + fk_codigo_producto + "')"

                insertar(execute(table, values(), action.insert, "")); //!bd.ejecutaComando(query.insertarDetalleVenta(this.cantidad, this.fk_codigo_producto)))           
            }
            return true;
        }

        public void update(string valor)
        {
            insertar(execute(this.table, valoresUpdate(), action.update, $"{WHERE} {id_detalle_venta_a} {igual} {valor}"));
        }

        public void query(string valuesString, string valor)
        {
            consulta(execute(this.table, id_detalle_venta_a, action.query, $"WHERE {id_detalle_venta_a} {igual} {valor}"), table);
        }
        #endregion

        #region eliminar detalle de venta
        public void eliminarDetalleVenta(string query)
        {
            //string where = $"DELETE FROM DETALLE_VENTA WHERE fk_id_venta = (SELECT MAX(id_venta) FROM `{table}`)";
            insertar(execute(table, values(), action.free, query));//queryEliminarDetalleVenta());//bd.ejecutaComando(query.eliminarDetalleVenta());
        }

        public void eliminarProductoDetalleVenta(string query)
        {
            insertar(execute(table, values(), action.free, query));
        }

        public List<DetalleVenta> list()
        {
            List<DetalleVenta> list = new List<DetalleVenta>();

            foreach (DataRow row in obtenerDatos.Tables[0].Rows)
            {
                DetalleVenta dv = new DetalleVenta()
                {
                    id_detalle_venta = row["id_detalle_venta"].ToString(),
                    cantidad = row["cantidad"].ToString(),
                    fk_id_venta = Convert.ToInt32(row["fk_id_venta"].ToString()),
                    fk_codigo_producto = row["fk_codigo_producto"].ToString()
                };

                list.Add(dv);
            }

            return list;
        }
        #endregion

        #region VALUES
        public string valoresUpdate()
        {
            return
                $"cantidad {igual} {c}{cantidad.ToUpper().Trim()}{c}{cc}" +
                $"fk_id_venta {igual} {c}{fk_id_venta}{c}{cc}" +
                $"fk_codigo_producto {igual} {c}{fk_codigo_producto}{c}";
        }

        public string values()
        {
            return
            $"'{cantidad.Trim()}'{cc}" +
            $"{fk_id_venta}{cc}" +
            $"{fk_codigo_producto}";
            //$"{credito}";
        }
        #endregion

        #endregion
    }
}
