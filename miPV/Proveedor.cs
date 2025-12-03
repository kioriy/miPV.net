using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace miPV
{
    class Proveedor : BD
    {
        public int id_proveedor { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        string table = "";

        public Proveedor()
        {
            table = PROVEEDOR;
        }

        #region METODOS
        public void insert()
        {
            insertar(execute(table, values(), action.insert, ""));
        }

        public void update(string valor)
        {
            insertar(execute(table, valoresUpdate(), action.update, $"{WHERE} {id_proveedor_a} {igual} {valor}"));
        }

        public void query(string valuesString, string where)
        {
            consulta(execute(table, id_proveedor_a, action.query, where), table);
        }

        public int idProveedor(string nombre)
        {
            return list().Find(x => x.nombre == nombre).id_proveedor;
        }

        public List<Proveedor> list()
        {
            List<Proveedor> list = new List<Proveedor>();

            foreach (DataRow row in obtenerDatos.Tables[0].Rows)
            {
                Proveedor p = new Proveedor()
                {
                    id_proveedor = Convert.ToInt32(row["id_proveedor"].ToString()),
                    nombre = row["nombre"].ToString(),
                    direccion = row["direccion"].ToString(),
                    telefono = row["telefono"].ToString(),
                };

                list.Add(p);
            }

            return list;
        }
        #endregion

        #region METODOS INTERFACE
        public void loadComboBox(ComboBox cb)
        {
            cb.Items.Clear();

            query("", "WHERE 1");

            //deserializeJson();

            /*cb.DataSource = user_list.Select(user => user.nombre).ToList();

            cb.SelectedIndex = -1;*/

            foreach (var proveedor in list())
            {
                cb.Items.Add(proveedor.nombre);
            }
        }
        #endregion

        #region VALUES
        public string valoresUpdate()
        {
            return
                $"nombre {igual} {c}{nombre.ToUpper().Trim()}{c}{cc}" +
                $"direccion {igual} {c}{direccion.ToUpper().Trim()}{c}{cc}" +
                $"telefono {igual} {c}{telefono}{c}";
        }

        public string values()
        {
            return
            $"{nombre.ToUpper().Trim()}{cc}" +
            $"{direccion.ToUpper().Trim()}{cc}" +
            $"{telefono.Trim()}";
        }
        #endregion
    }
}
