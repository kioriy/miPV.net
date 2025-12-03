using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace miPV
{
    class Cliente : BD
    {
        #region atributos
        //public List<Producto> listaIdProducto;
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string estado { get; set; }
        public string rfc { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        //private string respuesta = "";

        public string table { get; set; }
        #endregion

        #region constructores
        public Cliente()
        {
            table = CLIENTE;
        }
        #endregion

        #region metodos


        public bool insert()
        {
            return insertar(execute(table, values(), action.insert, ""));
        }

        public bool update(string valor)
        {
            return insertar(execute(table, valoresUpdate(), action.update, $"WHERE {id_cliente_a} {igual} {valor}"));
        }

        public void query(string valuesString, string valor)
        {
            //consulta(execute(table, id_cliente_a, action.query, $"WHERE {id_cliente_a} {igual} {valor}"), table);
            consulta(execute(table, id_cliente_a, action.query, $"WHERE 1"), table);
        }

        public int idCliente(string nombre)
        {
            if (nombre == "")
            {
                nombre = "PUBLICO EN GENERAL";
            }

            return list().Find(x => x.nombre == nombre).id_cliente;//bd.llenarDgv(dgv, query.buscarProducto(rfc), tabla);
        }

        public List<Cliente> list()
        {
            List<Cliente> list = new List<Cliente>();

            foreach (DataRow row in obtenerDatos.Tables[0].Rows)
            {
                Cliente c = new Cliente()
                {
                    id_cliente = Convert.ToInt32(row["id_cliente"].ToString()),
                    nombre = row["nombre"].ToString(),
                    direccion = row["direccion"].ToString(),
                    ciudad = row["ciudad"].ToString(),
                    estado = row["estado"].ToString(),
                    rfc = row["rfc"].ToString(),
                    correo = row["correo"].ToString(),
                    telefono = row["telefono"].ToString()
                };

                list.Add(c);
            }

            return list;
        }

        #endregion

        #region METODOS INTERFACE
        public void loadComboBox(ComboBox cb)
        {
            cb.Items.Clear();
            query("", "1");
            //query("1", $"{WHERE} ?");

            //deserializeJson();

            /*cb.DataSource = user_list.Select(user => user.nombre).ToList();

            cb.SelectedIndex = -1;*/

            foreach (var cliente in list())
            {
                cb.Items.Add(cliente.nombre);
            }
        }

        //public void loadDgv(DataGridView dgv)
        //{
        //    dgv.Rows.Clear();

        //    query("1", $"{WHERE} ?");

        //    deserializeJson();

        //    /*cb.DataSource = user_list.Select(user => user.nombre).ToList();

        //    cb.SelectedIndex = -1;*/

        //    foreach (var cliente in list<Cliente>())
        //    {
        //        dgv.Rows.Add();
        //    }
        //}
        #endregion

        #region VALUES
        public string valoresUpdate()
        {
            return
                $"nombre {igual} {c}{nombre.ToUpper().Trim()}{c}{cc}" +
                $"direccion {igual} {c}{direccion.ToUpper().Trim()}{c}{cc}" +
                $"ciudad {igual} {c}{ciudad.ToUpper().Trim()}{c}{cc}" +
                $"estado {igual} {c}{estado.ToUpper().Trim()}{c}{cc}" +
                $"rfc {igual} {c}{rfc.ToUpper().Trim()}{c}{cc}" +
                $"correo {igual} {c}{correo.ToUpper().Trim()}{c}{cc}" +
                $"telefono {igual} {c}{telefono}{c}";
        }

        public string values()
        {
            return
            $"'{nombre.ToUpper().Trim()}'{cc}" +
            $"'{direccion.ToUpper().Trim()}'{cc}" +
            $"'{ciudad.ToUpper().Trim()}'{cc}" +
            $"'{estado.ToUpper().Trim()}'{cc}" +
            $"'{rfc.ToUpper().Trim()}'{cc}" +
            $"'{correo.Trim()}'{cc}" +
            $"'{telefono}'";
        }
        #endregion
    }
}
