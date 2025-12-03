using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace miPV
{
    class Venta : BD
    {
        #region variables
        public int id_venta { get; set; }
        public string folio { get; set; }
        public string cliente { get; set; }
        public string fecha { get; set; }
        public int fk_id_cliente { get; set; }
        public string credito { get; set; }
        public string descuento { get; set; }
        
        //public string descripcion { get; set; }
        public string total { get; set; }
        public string costo { get; set; }         
        public string abono { get; set; } = "0";

        string table = "";
        //BD bd;
        //Query query;
        Actividades actividad = new Actividades();
        #endregion

        #region constructores
        public Venta()
        {
            this.table = VENTA;
        }
        #endregion

        #region METODOS
        public bool insert()
        {
            return insertar(execute(this.table, values(), action.insert, ""));
        }

        public void update(string valor)
        {
            insertar(execute(this.table, valoresUpdate(), action.update, $"WHERE {id_venta_a} {igual} {valor}"));
        }

        public void query(string valuesString, string where)
        {
            consulta(execute(this.table, id_venta_a, action.query, where),table);
        }

        public void free(string query)
        {
            execute(table, "", action.free, query);
        }

        //public void loadVenta()
        //{
        //    RefreshList();//execute(this.table, "", action.free, maxId(this.table, id_venta_a));
        //}

        public void clienteCredito(string query)
        {
            //string where = $"DELETE FROM DETALLE_VENTA WHERE fk_id_venta = (SELECT MAX(id_venta) FROM `{table}`)";
            consulta(execute(table, "1", action.free, query),table);//bd.ejecutaComando(query.eliminarDetalleVenta());
        }

        public void corteCaja(string query)
        {
            //string where = $"DELETE FROM DETALLE_VENTA WHERE fk_id_venta = (SELECT MAX(id_venta) FROM `{table}`)";
            consulta(execute(table, "", action.free, query),table);//bd.ejecutaComando(query.eliminarDetalleVenta());
        }

        public List<Venta> list(bool venta)
        {
            List<Venta> list = new List<Venta>();

            if (venta)
            {
                foreach (DataRow row in obtenerDatos.Tables[0].Rows)
                {
                    Venta v = new Venta()
                    {
                        id_venta = Convert.ToInt32(row["id_venta"].ToString()),
                        //folio = row["folio"].ToString(),
                        //cliente = row["cliente"].ToString(),
                        fecha = row["fecha"].ToString(),
                        //fk_id_cliente = Convert.ToInt32(row["fk_id_cliente"].ToString()),
                        //total = row["total"].ToString(),
                        //costo = row["costo"].ToString(),
                        //credito = row["credito"].ToString(),
                        descuento = row["descuento"].ToString(),
                    };

                    list.Add(v);
                }

            }
            else
            {
                foreach (DataRow row in obtenerDatos.Tables[0].Rows)
                {
                    Venta v = new Venta()
                    {
                        //id_venta = Convert.ToInt32(row["folio"].ToString()),
                        folio = row["folio"].ToString(),
                        cliente = row["cliente"].ToString(),
                        fecha = row["fecha"].ToString(),
                        //fk_id_cliente = Convert.ToInt32(row["fk_id_cliente"].ToString()),
                        total = row["total"].ToString(),
                        costo = row["costo"].ToString(),
                        //credito = row["credito"].ToString(),
                        descuento = row["descuento"].ToString(),
                    };

                    list.Add(v);
                }    
            }

            return list;
        }

        public List<Venta> RefreshList()
        {
            query("", "WHERE 1");

            List<Venta> list = new List<Venta>();

            foreach (DataRow row in obtenerDatos.Tables[0].Rows)
            {
                Venta v = new Venta()
                {
                    id_venta = Convert.ToInt32(row["id_venta"].ToString()),
                    //folio = row["folio"].ToString(),
                    //cliente = row["cliente"].ToString(),
                    fecha = row["fecha"].ToString(),
                    fk_id_cliente = Convert.ToInt32(row["fk_id_cliente"].ToString()),
                    credito = row["credito"].ToString(),
                    descuento = row["descuento"].ToString(),
                };

                list.Add(v);
            }

            return list;
        }

        public void loadDgv(DataGridView dgv, string query)
        {
            dgv.DataSource = null;

            clienteCredito(query);

            if (list(true) != null)
            {
                dgv.DataSource = list(true);

                dgv.Columns["id_venta"].Visible = false;
                dgv.Columns["credito"].Visible = false;
                dgv.Columns["fk_id_cliente"].Visible = false;
            }
        }

        public void loadDgvC(DataGridView dgv, string query)
        {
            dgv.DataSource = null;

            corteCaja(query);

            dgv.DataSource = list(false);
     
            dgv.Columns["id_venta"].Visible = false;
            dgv.Columns["credito"].Visible = false;
            dgv.Columns["fk_id_cliente"].Visible = false;
        }

        #region eliminar venta
        /*public bool eliminarVenta()
        {
            //Check de Eliminar venta
            actividad.insertar_actividad("Elimino venta", "Persona X");
            return bd.ejecutaComando(query.eliminarVenta());
        }*/
        #endregion

        #endregion

        #region VALUES
        public string valoresUpdate()
        {
            return
                //$"folio {igual} {c}{folio.ToUpper().Trim()}{c}{cc}" +
                //$"cliente {igual} {c}{cliente.ToUpper().Trim()}{c}{cc}" +
                $"fecha {igual} {c}{fecha.ToUpper().Trim()}{c}{cc}" +
                $"fk_id_cliente {igual} {c}{fk_id_cliente}{c}{cc}" +
                $"credito {igual} {c}{credito.ToUpper().Trim()}{c}{cc}" +
                $"descuento {igual} {c}{descuento}{c}";
        }

        public string values()
        {
            return
            $"'{fecha.Trim()}'{cc}" +
            $"{fk_id_cliente}{cc}" +
            $"{credito}{cc}" +
            $"{descuento}{cc}" +
            $"{abono}";
        }
        #endregion
    }
}
